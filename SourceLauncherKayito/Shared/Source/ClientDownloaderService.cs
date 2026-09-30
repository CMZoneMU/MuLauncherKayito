using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MuLauncher
{
    /// <summary>
    /// Metadados de um pacote de instalação do cliente localizado em uma Release do GitHub.
    /// </summary>
    public class ClientPackageInfo
    {
        public string Name { get; set; } = string.Empty;
        public string DisplayTitle { get; set; } = string.Empty;
        public string DownloadUrl { get; set; } = string.Empty;
        public long SizeBytes { get; set; } = 0;
        public string FormattedSize { get; set; } = "Desconhecido";
        public bool HasSha256 { get; set; } = false;
        public string Sha256Url { get; set; } = string.Empty;
        public string ExpectedSha256 { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = false;
    }

    /// <summary>
    /// Resultado da consulta de pacotes na Release mais recente do GitHub.
    /// </summary>
    public class ClientReleaseResult
    {
        public bool Success { get; set; } = false;
        public string TagName { get; set; } = string.Empty;
        public string ReleaseNotes { get; set; } = string.Empty;
        public ClientPackageInfo? PackageWithSound { get; set; }
        public ClientPackageInfo? PackageWithoutSound { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }

    /// <summary>
    /// Serviço de download inicial de pacotes completos do cliente (.ZIP) diretamente de Releases do GitHub,
    /// com suporte a verificação de hash SHA-256 e descompactação automática direta no diretório do jogo.
    /// </summary>
    public class ClientDownloaderService : IDisposable
    {
        private readonly string _owner;
        private readonly string _repo;
        private readonly string _token;
        private readonly string _fileWithSound;
        private readonly string _fileWithoutSound;
        private readonly string _gameDirectory;
        private readonly HttpClient _httpClient;

        public ClientDownloaderService(LauncherConfig config, string gameDirectory)
        {
            _owner = (config.DownloaderOwner ?? "").Trim();
            _repo = (config.DownloaderRepo ?? "").Trim();
            _token = (config.DownloaderToken ?? "").Trim();
            _fileWithSound = string.IsNullOrWhiteSpace(config.DownloaderFile1) ? "client_com_som.zip" : config.DownloaderFile1.Trim();
            _fileWithoutSound = string.IsNullOrWhiteSpace(config.DownloaderFile2) ? "client_sem_som.zip" : config.DownloaderFile2.Trim();
            _gameDirectory = gameDirectory;

            var handler = new HttpClientHandler
            {
                AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromHours(4) // Permite downloads longos de arquivos grandes (ex: 1.5 GB em conexões lentas)
            };

            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MuOnlineLauncher-Downloader/1.0");

            if (!string.IsNullOrWhiteSpace(_token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            }
        }

        public static string FormatBytes(long bytes)
        {
            if (bytes <= 0) return "0 B";
            if (bytes >= 1024L * 1024 * 1024)
                return $"{(double)bytes / (1024L * 1024 * 1024):F2} GB";
            if (bytes >= 1024L * 1024)
                return $"{(double)bytes / (1024L * 1024):F1} MB";
            if (bytes >= 1024L)
                return $"{(double)bytes / 1024L:F0} KB";
            return $"{bytes} B";
        }

        /// <summary>
        /// Remove arquivos temporários (.tmp) órfãos deixados por downloads interrompidos anteriormente.
        /// </summary>
        public void CleanupOrphanedTempFiles()
        {
            try
            {
                if (!Directory.Exists(_gameDirectory)) return;

                var tmpFiles = Directory.GetFiles(_gameDirectory, "*.tmp", SearchOption.TopDirectoryOnly);
                foreach (var file in tmpFiles)
                {
                    string name = Path.GetFileName(file);
                    if (name.StartsWith("client_", StringComparison.OrdinalIgnoreCase) ||
                        name.EndsWith(".zip.tmp", StringComparison.OrdinalIgnoreCase))
                    {
                        try { File.Delete(file); } catch { }
                    }
                }
            }
            catch
            {
                // Ignora erros de exclusão na inicialização
            }
        }

        /// <summary>
        /// Consulta a Release mais recente no GitHub e localiza os pacotes configurados (Com Som e Sem Som).
        /// </summary>
        public async Task<ClientReleaseResult> FetchAvailablePackagesAsync(CancellationToken cancellationToken = default)
        {
            var result = new ClientReleaseResult();

            if (string.IsNullOrWhiteSpace(_owner) || string.IsNullOrWhiteSpace(_repo))
            {
                result.ErrorMessage = "Repositório do GitHub do Downloader não configurado.";
                return result;
            }

            try
            {
                string apiUrl = $"https://api.github.com/repos/{_owner}/{_repo}/releases/latest";
                using var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));

                using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken);
                if (!response.IsSuccessStatusCode)
                {
                    result.ErrorMessage = $"Falha ao consultar Releases do GitHub: HTTP {(int)response.StatusCode} {response.ReasonPhrase}";
                    return result;
                }

                string json = await response.Content.ReadAsStringAsync(cancellationToken);
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                result.TagName = root.TryGetProperty("tag_name", out var tagProp) ? tagProp.GetString() ?? "" : "";
                result.ReleaseNotes = root.TryGetProperty("body", out var bodyProp) ? bodyProp.GetString() ?? "" : "";

                if (!root.TryGetProperty("assets", out var assetsProp) || assetsProp.ValueKind != JsonValueKind.Array)
                {
                    result.ErrorMessage = "A release mais recente do repositório não possui nenhum arquivo anexado (assets).";
                    return result;
                }

                var assetList = assetsProp.EnumerateArray().ToList();

                result.PackageWithSound = ExtractPackageInfo(assetList, _fileWithSound, "Cliente Completo (Com Som)");
                result.PackageWithoutSound = ExtractPackageInfo(assetList, _fileWithoutSound, "Cliente Leve (Sem Som)");

                result.Success = (result.PackageWithSound?.IsAvailable == true) || (result.PackageWithoutSound?.IsAvailable == true);
                if (!result.Success)
                {
                    result.ErrorMessage = $"Nenhum dos pacotes configurados ('{_fileWithSound}' ou '{_fileWithoutSound}') foi encontrado na Release {result.TagName}.";
                }

                return result;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = $"Erro de conexão com o GitHub: {ex.Message}";
                return result;
            }
        }

        private ClientPackageInfo ExtractPackageInfo(List<JsonElement> assets, string expectedFileName, string displayTitle)
        {
            var pkg = new ClientPackageInfo
            {
                Name = expectedFileName,
                DisplayTitle = displayTitle,
                IsAvailable = false
            };

            var matchingAsset = assets.FirstOrDefault(a =>
                string.Equals(a.GetProperty("name").GetString(), expectedFileName, StringComparison.OrdinalIgnoreCase));

            if (matchingAsset.ValueKind != JsonValueKind.Undefined)
            {
                pkg.IsAvailable = true;
                pkg.SizeBytes = matchingAsset.GetProperty("size").GetInt64();
                pkg.FormattedSize = FormatBytes(pkg.SizeBytes);

                // Se houver token, usa endpoint de assets da API com Accept: application/octet-stream
                // Caso contrário, usa browser_download_url
                if (!string.IsNullOrWhiteSpace(_token))
                {
                    pkg.DownloadUrl = matchingAsset.GetProperty("url").GetString() ?? "";
                }
                else
                {
                    pkg.DownloadUrl = matchingAsset.GetProperty("browser_download_url").GetString() ?? "";
                }

                // Procura arquivo SHA-256 correspondente na mesma release (ex: client_com_som.zip.sha256 ou client_com_som.sha256)
                string shaName1 = expectedFileName + ".sha256";
                string shaName2 = Path.GetFileNameWithoutExtension(expectedFileName) + ".sha256";

                var shaAsset = assets.FirstOrDefault(a =>
                    string.Equals(a.GetProperty("name").GetString(), shaName1, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(a.GetProperty("name").GetString(), shaName2, StringComparison.OrdinalIgnoreCase));

                if (shaAsset.ValueKind != JsonValueKind.Undefined)
                {
                    pkg.HasSha256 = true;
                    pkg.Sha256Url = !string.IsNullOrWhiteSpace(_token)
                        ? (shaAsset.GetProperty("url").GetString() ?? "")
                        : (shaAsset.GetProperty("browser_download_url").GetString() ?? "");
                }
            }

            return pkg;
        }

        /// <summary>
        /// Executa o download streaming do pacote selecionado para um arquivo .tmp, valida o hash SHA-256
        /// (se disponível na release) e descompacta todos os arquivos diretamente no diretório do jogo.
        /// </summary>
        public async Task DownloadAndExtractPackageAsync(
            ClientPackageInfo package,
            IProgress<UpdateProgressReport> progress,
            CancellationToken cancellationToken = default)
        {
            if (package == null || string.IsNullOrWhiteSpace(package.DownloadUrl))
                throw new ArgumentException("Pacote inválido ou URL de download não disponível.", nameof(package));

            string tempFilePath = Path.Combine(_gameDirectory, $"{package.Name}.tmp");

            try
            {
                // Limpeza preventiva de arquivo temporário prévio
                if (File.Exists(tempFilePath))
                {
                    try { File.Delete(tempFilePath); } catch { }
                }

                // ==========================================
                // ETAPA 1: DOWNLOAD DO PACOTE .ZIP VIA STREAM
                // ==========================================
                ReportProgress(progress, $"Conectando ao GitHub para baixar {package.DisplayTitle}...", 0, 0, package.Name);

                using var request = CreateDownloadRequest(package.DownloadUrl);
                using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
                response.EnsureSuccessStatusCode();

                long totalBytes = response.Content.Headers.ContentLength ?? package.SizeBytes;

                using (var downloadStream = await response.Content.ReadAsStreamAsync(cancellationToken))
                using (var destinationStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 131072, true))
                {
                    byte[] buffer = new byte[131072]; // 128 KB buffer para alta vazão
                    long bytesRead = 0;
                    int read;
                    DateTime lastReportTime = DateTime.UtcNow;

                    while ((read = await downloadStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
                    {
                        await destinationStream.WriteAsync(buffer, 0, read, cancellationToken);
                        bytesRead += read;

                        double percent = totalBytes > 0 ? ((double)bytesRead / totalBytes) * 100.0 : 0;

                        // Reporta progresso com throttling para não congelar UI
                        if ((DateTime.UtcNow - lastReportTime).TotalMilliseconds >= 100 || bytesRead == totalBytes)
                        {
                            lastReportTime = DateTime.UtcNow;
                            string downloadedFormatted = FormatBytes(bytesRead);
                            string totalFormatted = FormatBytes(totalBytes);
                            string msg = $"Baixando {package.DisplayTitle}: {downloadedFormatted} / {totalFormatted} ({percent:F1}%)";
                            ReportProgress(progress, msg, percent, percent, package.Name);
                        }
                    }
                }

                cancellationToken.ThrowIfCancellationRequested();

                // ==========================================
                // ETAPA 2: VALIDAÇÃO DE INTEGRIDADE SHA-256
                // ==========================================
                if (package.HasSha256 && !string.IsNullOrWhiteSpace(package.Sha256Url))
                {
                    ReportProgress(progress, "Verificando integridade SHA-256 do pacote baixado...", 100, 100, package.Name);
                    string expectedSha = await FetchExpectedSha256Async(package.Sha256Url, cancellationToken);

                    if (!string.IsNullOrWhiteSpace(expectedSha))
                    {
                        string computedSha = await ComputeSha256Async(tempFilePath, cancellationToken);
                        if (!string.Equals(expectedSha, computedSha, StringComparison.OrdinalIgnoreCase))
                        {
                            throw new InvalidOperationException(
                                $"Falha de integridade SHA-256 no pacote baixado!\n" +
                                $"Hash Esperado: {expectedSha}\n" +
                                $"Hash Calculado: {computedSha}\n" +
                                $"O download pode ter sido corrompido durante a transferência.");
                        }
                    }
                }

                // ==========================================
                // ETAPA 3: DESCOMPACTAÇÃO DO ARQUIVO .ZIP
                // ==========================================
                ReportProgress(progress, "Abrindo pacote para descompactação...", 0, 0, package.Name);

                using (var zipArchive = ZipFile.OpenRead(tempFilePath))
                {
                    int totalEntries = zipArchive.Entries.Count;
                    int extractedEntries = 0;
                    string targetRoot = Path.GetFullPath(_gameDirectory);

                    foreach (var entry in zipArchive.Entries)
                    {
                        cancellationToken.ThrowIfCancellationRequested();

                        // Ignora diretórios virtuais do ZIP
                        if (string.IsNullOrEmpty(entry.Name) || entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                        {
                            continue;
                        }

                        // Proteção contra vulnerabilidade Zip-Slip
                        string destinationPath = Path.GetFullPath(Path.Combine(targetRoot, entry.FullName));
                        if (!destinationPath.StartsWith(targetRoot, StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        string? destinationDir = Path.GetDirectoryName(destinationPath);
                        if (!string.IsNullOrEmpty(destinationDir) && !Directory.Exists(destinationDir))
                        {
                            Directory.CreateDirectory(destinationDir);
                        }

                        // Extrai sobrescrevendo qualquer arquivo prévio
                        entry.ExtractToFile(destinationPath, overwrite: true);
                        extractedEntries++;

                        double extractPercent = totalEntries > 0 ? ((double)extractedEntries / totalEntries) * 100.0 : 0;
                        ReportProgress(progress, $"Extraindo cliente: {entry.Name} ({extractedEntries}/{totalEntries})", extractPercent, extractPercent, entry.Name);
                    }
                }

                // ==========================================
                // ETAPA 4: LIMPEZA DO ARQUIVO TEMPORÁRIO
                // ==========================================
                try
                {
                    if (File.Exists(tempFilePath))
                    {
                        File.Delete(tempFilePath);
                    }
                }
                catch { }

                ReportProgress(progress, "Instalação do cliente concluída com sucesso!", 100, 100, string.Empty);
            }
            catch
            {
                // Em caso de erro ou cancelamento, garante remoção do arquivo temporário
                try
                {
                    if (File.Exists(tempFilePath))
                    {
                        File.Delete(tempFilePath);
                    }
                }
                catch { }

                throw;
            }
        }

        private HttpRequestMessage CreateDownloadRequest(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            if (url.Contains("api.github.com") && url.Contains("/assets/"))
            {
                request.Headers.Accept.Clear();
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            }

            return request;
        }

        private async Task<string> FetchExpectedSha256Async(string sha256Url, CancellationToken cancellationToken)
        {
            try
            {
                using var request = CreateDownloadRequest(sha256Url);
                using var response = await _httpClient.SendAsync(request, cancellationToken);
                if (!response.IsSuccessStatusCode) return string.Empty;

                string content = await response.Content.ReadAsStringAsync(cancellationToken);
                if (string.IsNullOrWhiteSpace(content)) return string.Empty;

                // Formato de arquivo .sha256 padrão: "<hash>  <filename>" ou apenas "<hash>"
                var parts = content.Trim().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return parts.Length > 0 ? parts[0].Trim() : string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        private static async Task<string> ComputeSha256Async(string filePath, CancellationToken cancellationToken)
        {
            using var sha256 = SHA256.Create();
            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 131072, true);
            byte[] hashBytes = await sha256.ComputeHashAsync(stream, cancellationToken);
            return Convert.ToHexString(hashBytes).ToLowerInvariant();
        }

        private void ReportProgress(
            IProgress<UpdateProgressReport> progress,
            string message,
            double currentFilePercent,
            double totalPercent,
            string fileName)
        {
            progress?.Report(new UpdateProgressReport
            {
                StatusMessage = message,
                CurrentFilePercent = Math.Min(100.0, Math.Max(0, currentFilePercent)),
                TotalPercent = Math.Min(100.0, Math.Max(0, totalPercent)),
                CurrentFileName = fileName
            });
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
