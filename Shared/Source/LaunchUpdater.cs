using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace MuLauncher
{
    /// <summary>
    /// Modelo de dados para um arquivo listado no manifesto remoto de atualização.
    /// </summary>
    public class UpdateFileItem
    {
        [JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = string.Empty;

        [JsonPropertyName("size")]
        public long Size { get; set; } = 0;
    }

    /// <summary>
    /// Estrutura para reporte de progresso em tempo real para a Interface (UI).
    /// </summary>
    public class UpdateProgressReport
    {
        public string StatusMessage { get; set; } = string.Empty;
        public double CurrentFilePercent { get; set; } = 0;
        public double TotalPercent { get; set; } = 0;
        public string CurrentFileName { get; set; } = string.Empty;
    }

    /// <summary>
    /// Motor de Atualização Híbrido Assíncrono com Hash MD5 Nativo.
    /// Suporta Servidores HTTP Tradicionais e Repositórios GitHub (Públicos ou Privados com Token).
    /// Projetado para ultra performance e baixo consumo de memória RAM via FileStream Buffering.
    /// </summary>
    public class LaunchUpdater
    {
        private readonly string _baseUrl;
        private readonly string _localBaseDir;
        private readonly HttpClient _httpClient;

        // Configurações do Provedor GitHub
        private readonly string _updateProvider; // "Http" ou "GitHub"
        private readonly string _gitHubOwner;
        private readonly string _gitHubRepo;
        private readonly string _gitHubBranch;
        private readonly string _gitHubToken;
        private readonly bool _useGitHubReleases;

        // Mapeamento dinâmico de URLs de download direto (ex: Assets de Release do GitHub)
        private readonly Dictionary<string, string> _customDownloadUrls = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public string ExecutableName { get; set; } = "main.exe";
        public string? RemoteMainHash { get; private set; }
        public List<UpdateFileItem> ServerFiles { get; private set; } = new List<UpdateFileItem>();

        public bool IsGitHubProvider => string.Equals(_updateProvider, "GitHub", StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Inicializa o motor de update a partir das configurações centralizadas do servidor.
        /// </summary>
        public LaunchUpdater(LauncherConfig config, string? localBaseDir = null)
        {
            _updateProvider = string.IsNullOrWhiteSpace(config.UpdateProvider) ? "Http" : config.UpdateProvider;
            _baseUrl = (config.UpdateServerUrl ?? "").TrimEnd('/');
            _gitHubOwner = (config.GitHubOwner ?? "").Trim();
            _gitHubRepo = (config.GitHubRepo ?? "").Trim();
            _gitHubBranch = string.IsNullOrWhiteSpace(config.GitHubBranch) ? "main" : config.GitHubBranch.Trim();
            _gitHubToken = (config.GitHubToken ?? "").Trim();
            _useGitHubReleases = config.UseGitHubReleases;
            ExecutableName = string.IsNullOrWhiteSpace(config.ExecutableName) ? "main.exe" : config.ExecutableName.Trim();

            _localBaseDir = localBaseDir ?? AppDomain.CurrentDomain.BaseDirectory;
            _httpClient = CreateHttpClient(_gitHubToken);
        }

        /// <summary>
        /// Construtor legado para inicialização direta via URL base HTTP.
        /// </summary>
        public LaunchUpdater(string baseUrl, string? localBaseDir = null)
        {
            _updateProvider = "Http";
            _baseUrl = (baseUrl ?? "").TrimEnd('/');
            _gitHubOwner = "";
            _gitHubRepo = "";
            _gitHubBranch = "main";
            _gitHubToken = "";
            _useGitHubReleases = true;

            _localBaseDir = localBaseDir ?? AppDomain.CurrentDomain.BaseDirectory;
            _httpClient = CreateHttpClient(null);
        }

        private static HttpClient CreateHttpClient(string? gitHubToken)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            };

            var client = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(60)
            };

            client.DefaultRequestHeaders.UserAgent.ParseAdd("MuOnlineLauncher/1.0");

            if (!string.IsNullOrWhiteSpace(gitHubToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", gitHubToken);
            }

            return client;
        }

        /// <summary>
        /// Executa a rotina assíncrona de verificação de hashes MD5 e download dos arquivos faltantes ou desatualizados.
        /// </summary>
        public async Task<bool> StartCheckAndUpdateAsync(
            IProgress<UpdateProgressReport> progress,
            CancellationToken cancellationToken = default)
        {
            try
            {
                string connectMsg = IsGitHubProvider
                    ? $"Conectando ao GitHub ({_gitHubOwner}/{_gitHubRepo})..."
                    : "Conectando ao servidor de atualização...";

                ReportProgress(progress, connectMsg, 0, 0);

                // 1. Obter lista de arquivos do servidor
                List<UpdateFileItem> serverFiles = await FetchManifestAsync(cancellationToken);
                ServerFiles = serverFiles;

                // Captura a hash remota do executável se presente no manifesto
                foreach (var file in serverFiles)
                {
                    if (string.Equals(file.Path, ExecutableName, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(Path.GetFileName(file.Path), ExecutableName, StringComparison.OrdinalIgnoreCase))
                    {
                        RemoteMainHash = file.Hash;
                        break;
                    }
                }

                if (serverFiles.Count == 0)
                {
                    ReportProgress(progress, "Nenhum arquivo para atualizar. Jogo pronto!", 100, 100);
                    return true;
                }

                ReportProgress(progress, "Verificando integridade dos arquivos locais...", 0, 0);

                List<UpdateFileItem> downloadQueue = new List<UpdateFileItem>();
                long totalDownloadBytes = 0;

                // 2. Fazer scan da pasta local e comparar Hashes MD5
                for (int i = 0; i < serverFiles.Count; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var item = serverFiles[i];
                    string localPath = System.IO.Path.Combine(_localBaseDir, item.Path);

                    double checkPercent = ((double)(i + 1) / serverFiles.Count) * 100.0;
                    ReportProgress(progress, $"Verificando: {item.Path}", 100, checkPercent, item.Path);

                    bool needsDownload = false;

                    if (!File.Exists(localPath))
                    {
                        needsDownload = true;
                    }
                    else
                    {
                        // Checagem rápida por tamanho primeiro (evita I/O desnecessário)
                        FileInfo fileInfo = new FileInfo(localPath);
                        if (item.Size > 0 && fileInfo.Length != item.Size)
                        {
                            needsDownload = true;
                        }
                        else
                        {
                            // Validação rigorosa via MD5 em streaming nativo
                            string localHash = await CalculateFileMD5Async(localPath, cancellationToken);
                            if (!string.Equals(localHash, item.Hash, StringComparison.OrdinalIgnoreCase))
                            {
                                needsDownload = true;
                            }
                        }
                    }

                    if (needsDownload)
                    {
                        downloadQueue.Add(item);
                        totalDownloadBytes += item.Size > 0 ? item.Size : 1024;
                    }
                }

                // Se todos os hashes baterem 100%
                if (downloadQueue.Count == 0)
                {
                    ReportProgress(progress, "Todos os arquivos estão 100% atualizados!", 100, 100);
                    return true;
                }

                // 3. Efetuar o download sequencial da fila de arquivos pendentes
                ReportProgress(progress, $"Baixando {downloadQueue.Count} arquivo(s) pendente(s)...", 0, 0);
                long bytesDownloadedAccumulated = 0;

                for (int i = 0; i < downloadQueue.Count; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var itemToDownload = downloadQueue[i];
                    string destinationPath = System.IO.Path.Combine(_localBaseDir, itemToDownload.Path);

                    // Cria os diretórios necessários
                    string? dir = System.IO.Path.GetDirectoryName(destinationPath);
                    if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    string fileUrl = ResolveFileUrl(itemToDownload.Path);

                    await DownloadFileWithProgressAsync(
                        fileUrl,
                        destinationPath,
                        itemToDownload.Path,
                        itemToDownload.Size,
                        bytesDownloadedAccumulated,
                        totalDownloadBytes,
                        progress,
                        cancellationToken);

                    bytesDownloadedAccumulated += itemToDownload.Size > 0 ? itemToDownload.Size : 1024;
                }

                ReportProgress(progress, "Atualização concluída com sucesso!", 100, 100);
                return true;
            }
            catch (OperationCanceledException)
            {
                ReportProgress(progress, "Atualização cancelada.", 0, 0);
                return false;
            }
            catch (Exception ex)
            {
                ReportProgress(progress, $"Falha na atualização: {ex.Message}", 0, 0);
                return false;
            }
        }

        /// <summary>
        /// Resolve a URL de download para um arquivo relativo com base no provedor ativo (HTTP ou GitHub).
        /// </summary>
        private string ResolveFileUrl(string relativePath)
        {
            string normalizedPath = relativePath.Replace('\\', '/');
            string fileName = Path.GetFileName(normalizedPath);

            // 1. Se estiver mapeado diretamente em Assets de Release do GitHub
            if (_customDownloadUrls.TryGetValue(normalizedPath, out var customUrl) ||
                _customDownloadUrls.TryGetValue(fileName, out customUrl))
            {
                return customUrl;
            }

            // 2. Se o provedor for GitHub (Raw / Branch)
            if (IsGitHubProvider)
            {
                string encodedPath = string.Join("/", normalizedPath.Split('/').Select(Uri.EscapeDataString));
                return $"https://raw.githubusercontent.com/{_gitHubOwner}/{_gitHubRepo}/{_gitHubBranch}/{encodedPath}";
            }

            // 3. Provedor HTTP Tradicional
            return $"{_baseUrl}/{normalizedPath}";
        }

        /// <summary>
        /// Cria o HttpRequestMessage correto configurando headers especiais para APIs do GitHub quando aplicável.
        /// </summary>
        private HttpRequestMessage CreateDownloadRequest(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            if (url.Contains("api.github.com") && url.Contains("/assets/"))
            {
                request.Headers.Accept.Clear();
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            }
            else if (url.Contains("api.github.com") && url.Contains("/contents/"))
            {
                request.Headers.Accept.Clear();
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.raw+json"));
            }

            return request;
        }

        /// <summary>
        /// Baixa e restaura diretamente um arquivo específico (como o main.exe) do servidor de atualização.
        /// </summary>
        public async Task<bool> RepairFileAsync(
            string relativePath,
            IProgress<UpdateProgressReport> progress,
            CancellationToken cancellationToken = default)
        {
            try
            {
                ReportProgress(progress, $"Conectando para restaurar {relativePath}...", 0, 0);

                var serverFiles = await FetchManifestAsync(cancellationToken);
                var targetItem = serverFiles.Find(f =>
                    string.Equals(f.Path, relativePath, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(Path.GetFileName(f.Path), relativePath, StringComparison.OrdinalIgnoreCase));

                string destinationPath = Path.Combine(_localBaseDir, relativePath);
                string fileUrl = ResolveFileUrl(relativePath);
                long size = targetItem?.Size ?? 0;

                string? dir = Path.GetDirectoryName(destinationPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                await DownloadFileWithProgressAsync(
                    fileUrl,
                    destinationPath,
                    relativePath,
                    size,
                    0,
                    size > 0 ? size : 1024,
                    progress,
                    cancellationToken);

                ReportProgress(progress, $"{relativePath} restaurado com sucesso!", 100, 100);
                return true;
            }
            catch (Exception ex)
            {
                ReportProgress(progress, $"Falha ao restaurar {relativePath}: {ex.Message}", 0, 0);
                return false;
            }
        }

        /// <summary>
        /// Executa uma checagem rápida de integridade de todos os arquivos do manifesto remoto.
        /// Retorna todos os arquivos que estão ausentes, renomeados ou com tamanho/hash divergentes.
        /// </summary>
        public async Task<List<UpdateFileItem>> CheckMissingOrModifiedFilesAsync(CancellationToken cancellationToken = default)
        {
            var compromised = new List<UpdateFileItem>();

            if (ServerFiles.Count == 0)
            {
                try
                {
                    ServerFiles = await FetchManifestAsync(cancellationToken);
                }
                catch
                {
                    return compromised;
                }
            }

            foreach (var item in ServerFiles)
            {
                string localPath = Path.Combine(_localBaseDir, item.Path);

                // 1. Arquivo deletado ou renomeado
                if (!File.Exists(localPath))
                {
                    compromised.Add(item);
                    continue;
                }

                // 2. Checagem rápida de tamanho em disco
                if (item.Size > 0)
                {
                    var fi = new FileInfo(localPath);
                    if (fi.Length != item.Size)
                    {
                        compromised.Add(item);
                        continue;
                    }
                }

                // 3. Checagem rigorosa de Hash para arquivos DLL e executáveis
                string ext = Path.GetExtension(item.Path);
                if (ext.Equals(".dll", StringComparison.OrdinalIgnoreCase) ||
                    ext.Equals(".exe", StringComparison.OrdinalIgnoreCase))
                {
                    string localHash = await CalculateFileMD5Async(localPath, cancellationToken);
                    if (!string.Equals(localHash, item.Hash, StringComparison.OrdinalIgnoreCase))
                    {
                        compromised.Add(item);
                    }
                }
            }

            return compromised;
        }

        /// <summary>
        /// Baixa e restaura em lote uma lista de arquivos que foram detectados como ausentes ou adulterados.
        /// </summary>
        public async Task<bool> DownloadSpecificFilesAsync(
            List<UpdateFileItem> filesToDownload,
            IProgress<UpdateProgressReport> progress,
            CancellationToken cancellationToken = default)
        {
            if (filesToDownload == null || filesToDownload.Count == 0) return true;

            try
            {
                long totalBytes = filesToDownload.Sum(f => f.Size > 0 ? f.Size : 1024);
                long accumulatedBytes = 0;

                for (int i = 0; i < filesToDownload.Count; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var item = filesToDownload[i];
                    string destinationPath = Path.Combine(_localBaseDir, item.Path);
                    string? dir = Path.GetDirectoryName(destinationPath);
                    if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    string fileUrl = ResolveFileUrl(item.Path);

                    await DownloadFileWithProgressAsync(
                        fileUrl,
                        destinationPath,
                        item.Path,
                        item.Size,
                        accumulatedBytes,
                        totalBytes,
                        progress,
                        cancellationToken);

                    accumulatedBytes += item.Size > 0 ? item.Size : 1024;
                }

                ReportProgress(progress, "Todos os arquivos foram restaurados com sucesso!", 100, 100);
                return true;
            }
            catch (Exception ex)
            {
                ReportProgress(progress, $"Falha na restauração: {ex.Message}", 0, 0);
                return false;
            }
        }

        /// <summary>
        /// Baixa o manifesto remoto. Roteia dinamicamente para GitHub ou Servidor HTTP.
        /// </summary>
        private async Task<List<UpdateFileItem>> FetchManifestAsync(CancellationToken cancellationToken)
        {
            if (IsGitHubProvider)
            {
                return await FetchManifestFromGitHubAsync(cancellationToken);
            }
            else
            {
                return await FetchManifestFromHttpAsync(cancellationToken);
            }
        }

        /// <summary>
        /// Baixa o manifesto a partir do GitHub (suporta Releases com Assets ou arquivos na branch Raw).
        /// </summary>
        private async Task<List<UpdateFileItem>> FetchManifestFromGitHubAsync(CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(_gitHubOwner) || string.IsNullOrWhiteSpace(_gitHubRepo))
            {
                throw new InvalidOperationException("Configuração do GitHub incompleta: 'Owner' e 'Repositório' são obrigatórios.");
            }

            _customDownloadUrls.Clear();

            // 1. Tentar ler da Release mais recente (se use_github_releases estiver ativo)
            if (_useGitHubReleases)
            {
                try
                {
                    string releaseApiUrl = $"https://api.github.com/repos/{_gitHubOwner}/{_gitHubRepo}/releases/latest";
                    using var request = new HttpRequestMessage(HttpMethod.Get, releaseApiUrl);
                    using var response = await _httpClient.SendAsync(request, cancellationToken);

                    if (response.IsSuccessStatusCode)
                    {
                        string releaseJson = await response.Content.ReadAsStringAsync(cancellationToken);
                        using var doc = JsonDocument.Parse(releaseJson);
                        var root = doc.RootElement;

                        if (root.TryGetProperty("assets", out var assetsElem) && assetsElem.ValueKind == JsonValueKind.Array)
                        {
                            JsonElement? manifestAsset = null;
                            string manifestName = "";

                            foreach (var asset in assetsElem.EnumerateArray())
                            {
                                string name = asset.GetProperty("name").GetString() ?? "";
                                string assetApiUrl = asset.GetProperty("url").GetString() ?? "";
                                string browserUrl = asset.TryGetProperty("browser_download_url", out var bUrl) ? bUrl.GetString() ?? "" : "";

                                string downloadUrl = !string.IsNullOrWhiteSpace(_gitHubToken) ? assetApiUrl : (!string.IsNullOrWhiteSpace(browserUrl) ? browserUrl : assetApiUrl);
                                _customDownloadUrls[name] = downloadUrl;

                                if (string.Equals(name, "update.json", StringComparison.OrdinalIgnoreCase) ||
                                    string.Equals(name, "hash.json", StringComparison.OrdinalIgnoreCase) ||
                                    string.Equals(name, "lista.txt", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (manifestAsset == null || string.Equals(name, "update.json", StringComparison.OrdinalIgnoreCase))
                                    {
                                        manifestAsset = asset;
                                        manifestName = name;
                                    }
                                }
                            }

                            if (manifestAsset.HasValue)
                            {
                                string manifestUrl = _customDownloadUrls[manifestName];
                                using var manifestReq = CreateDownloadRequest(manifestUrl);
                                using var manifestRes = await _httpClient.SendAsync(manifestReq, cancellationToken);
                                if (manifestRes.IsSuccessStatusCode)
                                {
                                    string content = await manifestRes.Content.ReadAsStringAsync(cancellationToken);
                                    var items = ParseManifestContent(content);
                                    if (items.Count > 0) return items;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[LaunchUpdater] Falha ao ler release do GitHub: {ex.Message}. Tentando branch raw...");
                }
            }

            // 2. Fallback para ler do repositório / branch (update.json, hash.json ou lista.txt)
            string[] manifestFiles = { "update.json", "hash.json", "lista.txt" };
            foreach (var manifestName in manifestFiles)
            {
                try
                {
                    // Tenta via raw.githubusercontent.com
                    string rawUrl = $"https://raw.githubusercontent.com/{_gitHubOwner}/{_gitHubRepo}/{_gitHubBranch}/{manifestName}";
                    using var rawReq = new HttpRequestMessage(HttpMethod.Get, rawUrl);
                    using var rawRes = await _httpClient.SendAsync(rawReq, cancellationToken);

                    if (rawRes.IsSuccessStatusCode)
                    {
                        string content = await rawRes.Content.ReadAsStringAsync(cancellationToken);
                        var items = ParseManifestContent(content);
                        if (items.Count > 0) return items;
                    }
                    else
                    {
                        // Tenta via Contents API com header raw
                        string contentApiUrl = $"https://api.github.com/repos/{_gitHubOwner}/{_gitHubRepo}/contents/{manifestName}?ref={_gitHubBranch}";
                        using var apiReq = new HttpRequestMessage(HttpMethod.Get, contentApiUrl);
                        apiReq.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.raw+json"));
                        using var apiRes = await _httpClient.SendAsync(apiReq, cancellationToken);

                        if (apiRes.IsSuccessStatusCode)
                        {
                            string content = await apiRes.Content.ReadAsStringAsync(cancellationToken);
                            var items = ParseManifestContent(content);
                            if (items.Count > 0) return items;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[LaunchUpdater] Tentativa de ler {manifestName} no GitHub falhou: {ex.Message}");
                }
            }

            throw new InvalidOperationException($"Não foi possível carregar o manifesto de atualização no repositório GitHub '{_gitHubOwner}/{_gitHubRepo}' (branch '{_gitHubBranch}'). Verifique se o repositório existe e contém 'update.json' ou 'hash.json'.");
        }

        /// <summary>
        /// Baixa o manifesto a partir do Servidor HTTP tradicional (update.json, hash.json ou lista.txt).
        /// </summary>
        private async Task<List<UpdateFileItem>> FetchManifestFromHttpAsync(CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(_baseUrl))
            {
                throw new InvalidOperationException("URL do servidor de atualização (HTTP) não está configurada.");
            }

            string[] manifestFiles = { "update.json", "hash.json", "lista.txt" };
            foreach (var manifestName in manifestFiles)
            {
                try
                {
                    string url = $"{_baseUrl}/{manifestName}";
                    using var response = await _httpClient.GetAsync(url, cancellationToken);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync(cancellationToken);
                        var items = ParseManifestContent(content);
                        if (items.Count > 0) return items;
                    }
                }
                catch
                {
                    // Fallback para próximo arquivo
                }
            }

            throw new InvalidOperationException($"Erro ao carregar o manifesto de atualização do servidor HTTP '{_baseUrl}'.");
        }

        /// <summary>
        /// Converte o conteúdo de texto do manifesto (JSON ou lista.txt) em lista de UpdateFileItem.
        /// </summary>
        private static List<UpdateFileItem> ParseManifestContent(string content)
        {
            var list = new List<UpdateFileItem>();
            if (string.IsNullOrWhiteSpace(content)) return list;

            content = content.Trim();

            // 1. Tenta deserializar formato JSON
            if (content.StartsWith("["))
            {
                try
                {
                    var items = JsonSerializer.Deserialize<List<UpdateFileItem>>(content);
                    if (items != null && items.Count > 0) return items;
                }
                catch { }
            }

            // 2. Formato linha a linha: caminho_relativo|hash_md5|tamanho_bytes
            using var reader = new StringReader(content);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;

                string[] parts = line.Split('|');
                if (parts.Length >= 2)
                {
                    list.Add(new UpdateFileItem
                    {
                        Path = parts[0].Trim(),
                        Hash = parts[1].Trim(),
                        Size = parts.Length >= 3 && long.TryParse(parts[2].Trim(), out long size) ? size : 0
                    });
                }
            }

            return list;
        }

        /// <summary>
        /// Calcula a Hash MD5 de um arquivo via streaming com buffer nativo.
        /// Mantém o consumo de RAM extremamente baixo mesmo para arquivos gigantes do cliente.
        /// </summary>
        public static async Task<string> CalculateFileMD5Async(string filePath, CancellationToken cancellationToken = default)
        {
            if (!File.Exists(filePath)) return string.Empty;

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 8192, useAsync: true))
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = await md5.ComputeHashAsync(stream, cancellationToken);
                return Convert.ToHexString(hashBytes).ToLowerInvariant();
            }
        }

        /// <summary>
        /// Baixa um único arquivo em blocos de dados (streaming), gravando diretamente em disco e atualizando barras de progresso.
        /// </summary>
        private async Task DownloadFileWithProgressAsync(
            string url,
            string destinationPath,
            string relativePath,
            long fileSize,
            long bytesDownloadedAccumulated,
            long totalDownloadBytes,
            IProgress<UpdateProgressReport> progress,
            CancellationToken cancellationToken)
        {
            string tempFilePath = destinationPath + ".tmp";
            string currentUrl = url;
            HttpResponseMessage? response = null;

            try
            {
                using var request = CreateDownloadRequest(currentUrl);
                response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

                // Fallback automático para Contents API se a URL raw do GitHub retornar 404 em repositório privado
                if (!response.IsSuccessStatusCode &&
                    response.StatusCode == System.Net.HttpStatusCode.NotFound &&
                    IsGitHubProvider &&
                    !currentUrl.Contains("api.github.com"))
                {
                    response.Dispose();
                    string normalizedPath = relativePath.Replace('\\', '/');
                    string encodedPath = string.Join("/", normalizedPath.Split('/').Select(Uri.EscapeDataString));
                    string fallbackApiUrl = $"https://api.github.com/repos/{_gitHubOwner}/{_gitHubRepo}/contents/{encodedPath}?ref={_gitHubBranch}";

                    using var fbReq = CreateDownloadRequest(fallbackApiUrl);
                    response = await _httpClient.SendAsync(fbReq, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
                }

                response.EnsureSuccessStatusCode();

                long totalBytesCurrentFile = response.Content.Headers.ContentLength ?? fileSize;

                using (Stream downloadStream = await response.Content.ReadAsStreamAsync(cancellationToken))
                using (FileStream destinationStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                {
                    byte[] buffer = new byte[8192];
                    long bytesReadCurrentFile = 0;
                    int read;

                    while ((read = await downloadStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
                    {
                        await destinationStream.WriteAsync(buffer, 0, read, cancellationToken);
                        bytesReadCurrentFile += read;

                        double filePercent = totalBytesCurrentFile > 0 ? ((double)bytesReadCurrentFile / totalBytesCurrentFile) * 100.0 : 0;
                        double totalPercent = totalDownloadBytes > 0 ? ((double)(bytesDownloadedAccumulated + bytesReadCurrentFile) / totalDownloadBytes) * 100.0 : 0;

                        ReportProgress(progress, $"Baixando: {relativePath} ({bytesReadCurrentFile / 1024} KB)", filePercent, totalPercent, relativePath);
                    }
                }
            }
            finally
            {
                response?.Dispose();
            }

            // Substituição atômica do arquivo temporário
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
            }
            File.Move(tempFilePath, destinationPath);
        }

        private void ReportProgress(
            IProgress<UpdateProgressReport> progress,
            string message,
            double currentFilePercent,
            double totalPercent,
            string fileName = "")
        {
            progress?.Report(new UpdateProgressReport
            {
                StatusMessage = message,
                CurrentFilePercent = Math.Min(100.0, Math.Max(0, currentFilePercent)),
                TotalPercent = Math.Min(100.0, Math.Max(0, totalPercent)),
                CurrentFileName = fileName
            });
        }
    }
}
