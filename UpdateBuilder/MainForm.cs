using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateBuilder
{
    public partial class MainForm : Form
    {
        private readonly BindingList<UpdateItem> _allItems = new();
        private BindingList<UpdateItem> _displayedItems = new();
        private CancellationTokenSource? _cts;
        private LauncherConfig _config = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Define pasta raiz padrão (diretório pai ou atual)
            string defaultDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo? parent = Directory.GetParent(defaultDir);
            txtRootDir.Text = parent != null ? parent.FullName : defaultDir;

            _displayedItems = _allItems;
            dgvFiles.DataSource = _displayedItems;

            LoadLauncherConfig(txtRootDir.Text);
            UpdateStatusSummary();
        }

        private void TxtRootDir_TextChanged(object sender, EventArgs e)
        {
            UpdateConfigPathInfo();
        }

        private void UpdateConfigPathInfo()
        {
            string resolved = LauncherConfig.ResolveConfigPath(txtRootDir.Text.Trim());
            txtConfigPathDisplay.Text = resolved;

            if (_config.EncryptConfigFile)
            {
                lblConfigEncryptStatus.Text = "Status: Protegido com Criptografia AES-256";
                lblConfigEncryptStatus.ForeColor = System.Drawing.Color.FromArgb(30, 100, 50);
            }
            else
            {
                lblConfigEncryptStatus.Text = "Status: Arquivo em Texto Plano (Sem Criptografia)";
                lblConfigEncryptStatus.ForeColor = System.Drawing.Color.FromArgb(160, 50, 40);
            }
        }

        private void LoadLauncherConfig(string? rootDir)
        {
            try
            {
                _config = LauncherConfig.Load(rootDir);

                bool isGitHub = string.Equals(_config.UpdateProvider, "GitHub", StringComparison.OrdinalIgnoreCase);
                rbProviderGitHub.Checked = isGitHub;
                rbProviderHttp.Checked = !isGitHub;

                txtUpdateUrl.Text = _config.UpdateServerUrl ?? "";
                txtGitHubOwner.Text = _config.GitHubOwner ?? "";
                txtGitHubRepo.Text = _config.GitHubRepo ?? "";
                txtGitHubBranch.Text = string.IsNullOrWhiteSpace(_config.GitHubBranch) ? "main" : _config.GitHubBranch;
                txtGitHubToken.Text = _config.GitHubToken ?? "";
                chkUseGitHubReleases.Checked = _config.UseGitHubReleases;

                chkEnableDownloader.Checked = _config.EnableDownloader;
                chkDownloaderCompleted.Checked = _config.DownloaderCompleted;
                txtDownloaderFile1.Text = string.IsNullOrWhiteSpace(_config.DownloaderFile1) ? "client_com_som.zip" : _config.DownloaderFile1;
                txtDownloaderFile2.Text = string.IsNullOrWhiteSpace(_config.DownloaderFile2) ? "client_sem_som.zip" : _config.DownloaderFile2;

                UpdateConfigPathInfo();
                UpdateProviderVisualState();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Aviso ao carregar launcher_config.json: {ex.Message}";
            }
        }

        private void RbProvider_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProviderVisualState();
        }

        private void UpdateProviderVisualState()
        {
            bool isHttp = rbProviderHttp.Checked;
            gbHttpSettings.Enabled = isHttp;
            gbGitHubSettings.Enabled = !isHttp;
        }

        private async void BtnTestHttpUrl_Click(object sender, EventArgs e)
        {
            string url = txtUpdateUrl.Text.Trim();
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por favor informe a URL base do servidor HTTP de atualizações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestHttpUrl.Enabled = false;
            btnTestHttpUrl.Text = "Testando...";
            lblStatus.Text = $"Conectando a {url}...";

            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(8) };
                // Tenta acessar um arquivo que deverá existir lá (update.json) para evitar o Erro 403 Forbidden de listagem de diretório
                string testUrl = url.EndsWith("/") ? url + "update.json" : url + "/update.json";
                var response = await client.GetAsync(testUrl, HttpCompletionOption.ResponseHeadersRead);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Conexão HTTP realizada com sucesso!\nO servidor respondeu corretamente (update.json foi encontrado).", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "Teste de URL HTTP concluído com êxito.";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound) // 404
                {
                    MessageBox.Show($"A conexão com o servidor foi bem-sucedida!\n\nNo entanto, o arquivo 'update.json' ainda não existe lá. Isso é normal se você ainda não gerou e enviou os arquivos do patch para a hospedagem.", "Conexão Bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "Servidor HTTP online (update.json pendente).";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) // 403
                {
                    MessageBox.Show($"A conexão com o servidor foi bem-sucedida, mas o servidor bloqueou o acesso (Erro 403 Forbidden).\nVerifique as permissões de arquivo na sua hospedagem.", "Aviso de Permissão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = "Servidor respondeu 403 Forbidden.";
                }
                else
                {
                    MessageBox.Show($"O servidor respondeu com o código {(int)response.StatusCode} ({response.ReasonPhrase}).\nVerifique se o caminho do patch está correto.", "Resposta HTTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = $"Servidor HTTP respondeu: {(int)response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao conectar com a URL informada:\n{ex.Message}", "Erro de Rede", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Falha no teste HTTP.";
            }
            finally
            {
                btnTestHttpUrl.Enabled = true;
                btnTestHttpUrl.Text = "Testar URL HTTP";
            }
        }

        private async void BtnTestGitHub_Click(object sender, EventArgs e)
        {
            string owner = txtGitHubOwner.Text.Trim();
            string repo = txtGitHubRepo.Text.Trim();
            string token = txtGitHubToken.Text.Trim();

            if (string.IsNullOrWhiteSpace(owner) || string.IsNullOrWhiteSpace(repo))
            {
                MessageBox.Show("Informe o Usuário/Organização (Owner) e o Repositório do GitHub.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestGitHub.Enabled = false;
            btnTestGitHub.Text = "Conectando...";
            lblStatus.Text = $"Consultando repositório {owner}/{repo} na API do GitHub...";

            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MuOnlineUpdateBuilder", "1.0"));
                if (!string.IsNullOrWhiteSpace(token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                string url = $"https://api.github.com/repos/{owner}/{repo}";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;
                    string fullName = root.TryGetProperty("full_name", out var fn) ? fn.GetString() ?? "" : $"{owner}/{repo}";
                    bool isPrivate = root.TryGetProperty("private", out var priv) && priv.GetBoolean();
                    string defaultBranch = root.TryGetProperty("default_branch", out var db) ? db.GetString() ?? "main" : "main";

                    MessageBox.Show(
                        $"Conexão com repositório do GitHub realizada com sucesso!\n\n" +
                        $"Repositório: {fullName}\n" +
                        $"Visibilidade: {(isPrivate ? "Privado (Token Válido)" : "Público")}\n" +
                        $"Branch Padrão: {defaultBranch}",
                        "GitHub API - Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblStatus.Text = $"Repositório {fullName} acessível e validado.";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Falha de autenticação (401 Unauthorized).\nVerifique se o Token PAT do GitHub foi gerado corretamente com permissões de 'repo'.", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = "Token GitHub não autorizado.";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Repositório '{owner}/{repo}' não foi encontrado (404 Not Found).\nSe for privado, certifique-se de preencher o Token PAT.", "Repositório Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = "Repositório não encontrado.";
                }
                else
                {
                    MessageBox.Show($"O GitHub retornou HTTP {(int)response.StatusCode} ({response.ReasonPhrase}).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = $"GitHub retornou: {(int)response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha de comunicação com a API do GitHub:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na API do GitHub.";
            }
            finally
            {
                btnTestGitHub.Enabled = true;
                btnTestGitHub.Text = "Testar Conexão GitHub";
            }
        }

        private async void BtnTestRelease_Click(object sender, EventArgs e)
        {
            string owner = txtGitHubOwner.Text.Trim();
            string repo = txtGitHubRepo.Text.Trim();
            string token = txtGitHubToken.Text.Trim();

            if (string.IsNullOrWhiteSpace(owner) || string.IsNullOrWhiteSpace(repo))
            {
                MessageBox.Show("Informe o Usuário/Organização (Owner) e o Repositório do GitHub na aba 'Provedor de Updates'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestRelease.Enabled = false;
            btnTestRelease.Text = "Consultando...";
            lblStatus.Text = $"Verificando última Release em {owner}/{repo}...";

            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MuOnlineUpdateBuilder", "1.0"));
                if (!string.IsNullOrWhiteSpace(token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                string url = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;
                    string tagName = root.TryGetProperty("tag_name", out var tn) ? tn.GetString() ?? "" : "N/A";
                    string releaseName = root.TryGetProperty("name", out var rn) ? rn.GetString() ?? "" : tagName;

                    var assetList = new List<string>();
                    string pkg1 = txtDownloaderFile1.Text.Trim();
                    string pkg2 = txtDownloaderFile2.Text.Trim();
                    bool foundPkg1 = false, foundPkg2 = false, foundHash1 = false, foundHash2 = false;

                    if (root.TryGetProperty("assets", out var assets) && assets.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var asset in assets.EnumerateArray())
                        {
                            string aName = asset.TryGetProperty("name", out var an) ? an.GetString() ?? "" : "";
                            long aSize = asset.TryGetProperty("size", out var asz) ? asz.GetInt64() : 0;
                            double sizeMb = aSize / (1024.0 * 1024.0);

                            if (string.Equals(aName, pkg1, StringComparison.OrdinalIgnoreCase)) foundPkg1 = true;
                            if (string.Equals(aName, pkg2, StringComparison.OrdinalIgnoreCase)) foundPkg2 = true;
                            if (string.Equals(aName, pkg1 + ".sha256", StringComparison.OrdinalIgnoreCase)) foundHash1 = true;
                            if (string.Equals(aName, pkg2 + ".sha256", StringComparison.OrdinalIgnoreCase)) foundHash2 = true;

                            assetList.Add($"• {aName} ({sizeMb:F2} MB)");
                        }
                    }

                    string summary = $"Release: {releaseName} (Tag: {tagName})\n" +
                                     $"Total de Assets anexados: {assetList.Count}\n\n" +
                                     $"Status dos Pacotes Configurados:\n" +
                                     $"- {pkg1}: {(foundPkg1 ? "[Presente]" : "[Não Encontrado]")}" +
                                     $" (Hash SHA-256: {(foundHash1 ? "[Presente]" : "[Ausente]")})\n" +
                                     $"- {pkg2}: {(foundPkg2 ? "[Presente]" : "[Não Encontrado]")}" +
                                     $" (Hash SHA-256: {(foundHash2 ? "[Presente]" : "[Ausente]")})\n\n" +
                                     (assetList.Count > 0 ? "Arquivos na Release:\n" + string.Join("\n", assetList.Take(8)) : "Nenhum arquivo anexado.");

                    MessageBox.Show(summary, "GitHub Releases - Validação de Assets", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = $"Release '{tagName}' verificada com {assetList.Count} asset(s).";
                }
                else
                {
                    MessageBox.Show($"O GitHub retornou HTTP {(int)response.StatusCode} ({response.ReasonPhrase}).\nVerifique se já foi publicada ao menos 1 Release no repositório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStatus.Text = $"Release retornou: {(int)response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao consultar Releases:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro ao consultar Releases.";
            }
            finally
            {
                btnTestRelease.Enabled = true;
                btnTestRelease.Text = "Testar Release no GitHub";
            }
        }

        private void BtnLoadLauncherConfig_Click(object sender, EventArgs e)
        {
            LoadLauncherConfig(txtRootDir.Text.Trim());
            MessageBox.Show("Configurações recarregadas com sucesso do launcher_config.json.", "Configuração Carregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSaveLauncherConfig_Click(object sender, EventArgs e)
        {
            try
            {
                // Carrega existente para preservar configurações de IP/Segurança intactas
                string root = txtRootDir.Text.Trim();
                var current = LauncherConfig.Load(root);

                current.UpdateProvider = rbProviderGitHub.Checked ? "GitHub" : "Http";
                current.UpdateServerUrl = txtUpdateUrl.Text.Trim();
                current.GitHubOwner = txtGitHubOwner.Text.Trim();
                current.GitHubRepo = txtGitHubRepo.Text.Trim();
                current.GitHubBranch = string.IsNullOrWhiteSpace(txtGitHubBranch.Text) ? "main" : txtGitHubBranch.Text.Trim();
                current.GitHubToken = txtGitHubToken.Text.Trim();
                current.UseGitHubReleases = chkUseGitHubReleases.Checked;

                current.DownloaderOwner = txtGitHubOwner.Text.Trim();
                current.DownloaderRepo = txtGitHubRepo.Text.Trim();
                current.DownloaderToken = txtGitHubToken.Text.Trim();
                current.EnableDownloader = chkEnableDownloader.Checked;
                current.DownloaderCompleted = chkDownloaderCompleted.Checked;
                current.DownloaderFile1 = string.IsNullOrWhiteSpace(txtDownloaderFile1.Text) ? "client_com_som.zip" : txtDownloaderFile1.Text.Trim();
                current.DownloaderFile2 = string.IsNullOrWhiteSpace(txtDownloaderFile2.Text) ? "client_sem_som.zip" : txtDownloaderFile2.Text.Trim();

                if (current.Save(root))
                {
                    _config = current;
                    UpdateConfigPathInfo();
                    string target = LauncherConfig.ResolveConfigPath(root);
                    string encInfo = current.EncryptConfigFile ? " (Criptografado com AES-256)" : " (Texto Plano)";
                    MessageBox.Show($"Configurações de Updates e Downloader salvas com sucesso em:\n{target}{encInfo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "launcher_config.json salvo com sucesso.";
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar o arquivo de configuração.", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configurações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuildZipWithSound_Click(object sender, EventArgs e)
        {
            await BuildZipPackageAsync(excludeAudio: false, txtDownloaderFile1.Text.Trim());
        }

        private async void BtnBuildZipNoSound_Click(object sender, EventArgs e)
        {
            await BuildZipPackageAsync(excludeAudio: true, txtDownloaderFile2.Text.Trim());
        }

        private async Task BuildZipPackageAsync(bool excludeAudio, string defaultFilename)
        {
            string rootDir = txtRootDir.Text.Trim();
            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Selecione um diretório raiz válido antes de gerar o pacote ZIP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dlg = new SaveFileDialog();
            dlg.Title = excludeAudio ? "Salvar Pacote ZIP Leve (Sem Som)" : "Salvar Pacote ZIP Completo (Com Som)";
            dlg.Filter = "Arquivo ZIP (*.zip)|*.zip";
            dlg.FileName = string.IsNullOrWhiteSpace(defaultFilename) ? (excludeAudio ? "client_sem_som.zip" : "client_com_som.zip") : defaultFilename;
            dlg.InitialDirectory = rootDir;

            if (dlg.ShowDialog() != DialogResult.OK) return;

            string targetZip = dlg.FileName;
            SetBusyState(true);
            progressBar.Visible = true;
            progressBar.Value = 0;
            _cts = new CancellationTokenSource();

            try
            {
                lblStatus.Text = "Compactando arquivos para pacote ZIP...";
                var progress = new Progress<(int percentage, string message)>(p =>
                {
                    progressBar.Value = Math.Clamp(p.percentage, 0, 100);
                    lblStatus.Text = p.message;
                });

                int totalPacked = await ZipPackageService.CreateZipPackageAsync(rootDir, targetZip, excludeAudio, progress, _cts.Token);

                lblStatus.Text = "Calculando hash SHA-256 do pacote ZIP gerado...";
                string sha256 = await ZipPackageService.GenerateSha256FileAsync(targetZip);

                var fi = new FileInfo(targetZip);
                double mb = fi.Length / (1024.0 * 1024.0);

                MessageBox.Show(
                    $"Pacote ZIP e Hash SHA-256 gerados com sucesso!\n\n" +
                    $"Arquivo: {Path.GetFileName(targetZip)} ({mb:F2} MB)\n" +
                    $"Arquivos compactados: {totalPacked}\n" +
                    $"Hash SHA-256: {sha256}\n" +
                    $"Arquivo de integridade salvo em:\n{targetZip}.sha256\n\n" +
                    $"Pronto para publicação na Release do GitHub!",
                    "Empacotamento Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblStatus.Text = $"Pacote {Path.GetFileName(targetZip)} gerado com sucesso ({mb:F2} MB).";
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Empacotamento cancelado pelo usuário.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante a criação do pacote ZIP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na geração do pacote ZIP.";
            }
            finally
            {
                progressBar.Visible = false;
                SetBusyState(false);
            }
        }

        private void BtnSelectRootDir_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "Selecione a pasta raiz do cliente/patch para calcular os caminhos relativos:";
            dlg.SelectedPath = txtRootDir.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRootDir.Text = dlg.SelectedPath;
            }
        }

        private async void BtnScanFolder_Click(object sender, EventArgs e)
        {
            string rootDir = txtRootDir.Text.Trim();
            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Por favor informe uma pasta raiz válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetBusyState(true);
            _cts = new CancellationTokenSource();

            try
            {
                lblStatus.Text = "Escaneando arquivos e calculando MD5...";
                progressBar.Visible = true;
                progressBar.Value = 0;

                var progress = new Progress<(int current, int total, string currentFile)>(report =>
                {
                    if (report.total > 0)
                    {
                        progressBar.Value = Math.Min(100, (int)(((double)report.current / report.total) * 100));
                    }
                    lblStatus.Text = $"[{report.current}/{report.total}] Calculando MD5: {report.currentFile}";
                });

                var scannedItems = await ManifestService.ScanDirectoryAsync(rootDir, progress, _cts.Token);

                _allItems.Clear();
                foreach (var item in scannedItems)
                {
                    _allItems.Add(item);
                }

                ApplyFilter();
                MessageBox.Show($"Escaneamento concluído!\nTotal de {scannedItems.Count} arquivo(s) processado(s).", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Escaneamento cancelado pelo usuário.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante o escaneamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetBusyState(false);
                progressBar.Visible = false;
                UpdateStatusSummary();
            }
        }

        private async void BtnAddSingleFile_Click(object sender, EventArgs e)
        {
            string rootDir = txtRootDir.Text.Trim();
            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Selecione a pasta raiz antes de adicionar um arquivo único.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dlg = new OpenFileDialog();
            dlg.Title = "Selecione 1 arquivo específico para adicionar ou atualizar";
            dlg.InitialDirectory = rootDir;
            dlg.Filter = "Todos os Arquivos (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = dlg.FileName;

                try
                {
                    lblStatus.Text = $"Processando arquivo: {Path.GetFileName(selectedFilePath)}...";

                    var newItem = await ManifestService.ProcessSingleFileAsync(selectedFilePath, rootDir);

                    var existing = _allItems.FirstOrDefault(x => string.Equals(x.Path, newItem.Path, StringComparison.OrdinalIgnoreCase));
                    if (existing != null)
                    {
                        existing.Hash = newItem.Hash;
                        existing.Size = newItem.Size;
                        lblStatus.Text = $"Arquivo '{newItem.Path}' atualizado com sucesso!";
                    }
                    else
                    {
                        _allItems.Add(newItem);
                        lblStatus.Text = $"Arquivo '{newItem.Path}' adicionado à lista com sucesso!";
                    }

                    ApplyFilter();
                    UpdateStatusSummary();

                    MessageBox.Show($"Arquivo processado com sucesso!\nCaminho: {newItem.Path}\nHash MD5: {newItem.Hash}\nTamanho: {newItem.FormattedSize}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Falha ao processar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um item na tabela para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rowsToRemove = dgvFiles.SelectedRows.Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as UpdateItem)
                .Where(item => item != null)
                .ToList();

            foreach (var item in rowsToRemove)
            {
                if (item != null)
                {
                    _allItems.Remove(item);
                }
            }

            ApplyFilter();
            UpdateStatusSummary();
        }

        private async void BtnLoadManifest_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Title = "Carregar Manifesto Existente";
            dlg.Filter = "Manifestos de Update (*.json; *.txt)|*.json;*.txt|Todos os Arquivos (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblStatus.Text = "Carregando manifesto...";
                    var items = await ManifestService.LoadManifestAsync(dlg.FileName);

                    _allItems.Clear();
                    foreach (var item in items)
                    {
                        _allItems.Add(item);
                    }

                    ApplyFilter();
                    UpdateStatusSummary();
                    MessageBox.Show($"{items.Count} arquivo(s) carregado(s) do manifesto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o manifesto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnSaveManifest_Click(object sender, EventArgs e)
        {
            if (_allItems.Count == 0)
            {
                MessageBox.Show("Não há itens na lista para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dlg = new FolderBrowserDialog();
            dlg.Description = "Selecione a pasta onde deseja salvar update.json e lista.txt:";
            dlg.SelectedPath = txtRootDir.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string targetDir = dlg.SelectedPath;
                string jsonPath = Path.Combine(targetDir, "update.json");
                string hashJsonPath = Path.Combine(targetDir, "hash.json");
                string txtPath = Path.Combine(targetDir, "lista.txt");

                try
                {
                    lblStatus.Text = "Salvando manifestos de atualização...";

                    await ManifestService.SaveManifestJsonAsync(jsonPath, _allItems);
                    await ManifestService.SaveManifestJsonAsync(hashJsonPath, _allItems);
                    await ManifestService.SaveManifestTxtAsync(txtPath, _allItems);

                    lblStatus.Text = "Manifestos salvos com sucesso!";
                    MessageBox.Show($"Arquivos gerados com sucesso na pasta:\n{targetDir}\n\n- update.json\n- hash.json (GitHub / Releases)\n- lista.txt", "Sucesso ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar manifestos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            if (_allItems.Count > 0 && MessageBox.Show("Deseja realmente limpar toda a lista de atualizações?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _allItems.Clear();
                ApplyFilter();
                UpdateStatusSummary();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filter = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(filter))
            {
                _displayedItems = _allItems;
            }
            else
            {
                var filtered = _allItems.Where(x => x.Path.Contains(filter, StringComparison.OrdinalIgnoreCase) || x.Hash.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
                _displayedItems = new BindingList<UpdateItem>(filtered);
            }

            dgvFiles.DataSource = _displayedItems;
            UpdateStatusSummary();
        }

        private void UpdateStatusSummary()
        {
            long totalBytes = _allItems.Sum(x => x.Size);
            string formattedTotal = totalBytes < 1024 * 1024 
                ? $"{(totalBytes / 1024.0):F2} KB" 
                : $"{(totalBytes / (1024.0 * 1024.0)):F2} MB";

            if (_displayedItems.Count == _allItems.Count)
            {
                lblStatus.Text = $"Total: {_allItems.Count} arquivo(s) na lista ({formattedTotal})";
            }
            else
            {
                lblStatus.Text = $"Exibindo {_displayedItems.Count} de {_allItems.Count} arquivo(s) ({formattedTotal})";
            }
        }

        private void SetBusyState(bool isBusy)
        {
            btnScanFolder.Enabled = !isBusy;
            btnAddSingleFile.Enabled = !isBusy;
            btnRemoveItem.Enabled = !isBusy;
            btnLoadManifest.Enabled = !isBusy;
            btnSaveManifest.Enabled = !isBusy;
            btnClearList.Enabled = !isBusy;
            btnSelectRootDir.Enabled = !isBusy;
            btnBuildZipWithSound.Enabled = !isBusy;
            btnBuildZipNoSound.Enabled = !isBusy;
        }
    }
}
