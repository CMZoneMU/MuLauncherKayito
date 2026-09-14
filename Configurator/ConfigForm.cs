using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherConfigurator
{
    public partial class ConfigForm : Form
    {
        private LauncherConfig _config;

        public ConfigForm()
        {
            InitializeComponent();
            _config = new LauncherConfig();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            // 1. Configurar Placeholders de Exemplo
            txtMainIp.PlaceholderText = "ex: 192.141.163.205";
            txtMainConnectPort.PlaceholderText = "44405";
            txtMainPort.PlaceholderText = "55901";

            txtAltIp.PlaceholderText = "ex: 192.141.163.206 (opcional)";
            txtAltConnectPort.PlaceholderText = "44405";
            txtAltPort.PlaceholderText = "55901";

            txtExecutable.PlaceholderText = "ex: main.exe";

            txtWebsiteUrl.PlaceholderText = "ex: http://seusite.com/";
            txtRegisterUrl.PlaceholderText = "ex: http://seusite.com/register";
            txtRegisterApiUrl.PlaceholderText = "ex: http://seusite.com/Launcher/api/launcher_register.php";
            txtRankingUrl.PlaceholderText = "ex: http://seusite.com/ranking";
            txtNewsUrl.PlaceholderText = "ex: http://seusite.com/Launcher/news.json";
            txtMutexName.PlaceholderText = @"Global\MuOnline_Launcher_Active_Lock";
            txtMainHash.PlaceholderText = "ex: 4a2f8c... (ou deixe vazio para checar do servidor)";

            // 2. Carregar configurações salvas
            _config = LauncherConfig.Load();

            txtMainIp.Text = IsSampleOrEmpty(_config.MainRouteIp, "127.0.0.1") ? "" : _config.MainRouteIp;
            txtMainConnectPort.Text = (_config.ConnectServerPort <= 0 || _config.ConnectServerPort == 44405) ? "" : _config.ConnectServerPort.ToString();
            txtMainPort.Text = (_config.MainRoutePort <= 0 || _config.MainRoutePort == 55901) ? "" : _config.MainRoutePort.ToString();

            txtAltIp.Text = IsSampleOrEmpty(_config.AltRouteIp, "192.168.1.100", "127.0.0.1") ? "" : _config.AltRouteIp;
            txtAltConnectPort.Text = (_config.AltConnectServerPort <= 0 || _config.AltConnectServerPort == 44405) ? "" : _config.AltConnectServerPort.ToString();
            txtAltPort.Text = (_config.AltRoutePort <= 0 || _config.AltRoutePort == 55901) ? "" : _config.AltRoutePort.ToString();

            txtExecutable.Text = IsSampleOrEmpty(_config.ExecutableName, "main.exe") ? "" : _config.ExecutableName;
            cboArgsMode.SelectedIndex = (_config.LaunchArgumentsMode >= 0 && _config.LaunchArgumentsMode <= 2) ? _config.LaunchArgumentsMode : 0;

            txtWebsiteUrl.Text = IsSampleOrEmpty(_config.WebsiteUrl, "https://meumu.com", "http://127.0.0.1/", "http://127.0.0.1") ? "" : _config.WebsiteUrl;
            txtRegisterUrl.Text = IsSampleOrEmpty(_config.RegisterUrl, "https://meumu.com/register", "http://127.0.0.1/", "http://127.0.0.1") ? "" : _config.RegisterUrl;
            txtRegisterApiUrl.Text = IsSampleOrEmpty(_config.RegisterApiUrl, "http://127.0.0.1/api/register.php") ? "" : _config.RegisterApiUrl;
            txtRankingUrl.Text = IsSampleOrEmpty(_config.RankingUrl, "https://meumu.com/ranking", "http://127.0.0.1/", "http://127.0.0.1") ? "" : _config.RankingUrl;
            txtNewsUrl.Text = IsSampleOrEmpty(_config.NewsUrl, "http://127.0.0.1/patch/news.json") ? "" : _config.NewsUrl;

            chkVerifyIntegrity.Checked = _config.VerifyMainIntegrity;
            chkAntiCheat.Checked = _config.EnableAntiCheatScan;
            chkDllWhitelist.Checked = _config.EnableDllWhitelist;
            chkLauncherGuard.Checked = _config.EnableLauncherGuard;
            chkRestoreLauncher.Checked = _config.RestoreLauncherOnGameClose;
            chkMutexLock.Checked = _config.EnableMutexLock;
            chkEncryptConfig.Checked = _config.EncryptConfigFile;
            txtMutexName.Text = string.IsNullOrWhiteSpace(_config.LauncherMutexName) ? @"Global\MuOnline_Launcher_Active_Lock" : _config.LauncherMutexName;
            txtMainHash.Text = _config.MainMd5Hash ?? "";

            chkEncryptConfig.CheckedChanged += (s, e) => UpdateFooterStatus();
            UpdateFooterStatus();
        }

        private static bool IsSampleOrEmpty(string? value, params string[] samples)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;
            foreach (var s in samples)
            {
                if (string.Equals(value.Trim(), s.Trim(), StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int mainCsPort = 44405;
            if (!string.IsNullOrWhiteSpace(txtMainConnectPort.Text))
            {
                if (!int.TryParse(txtMainConnectPort.Text.Trim(), out mainCsPort) || mainCsPort <= 0 || mainCsPort > 65535)
                {
                    MessageBox.Show("Por favor informe uma Porta CS válida para a Rota Principal (ex: 44405).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int mainPort = 55901;
            if (!string.IsNullOrWhiteSpace(txtMainPort.Text))
            {
                if (!int.TryParse(txtMainPort.Text.Trim(), out mainPort) || mainPort <= 0 || mainPort > 65535)
                {
                    MessageBox.Show("Por favor informe uma Porta GS válida para a Rota Principal (1-65535).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int altCsPort = 44405;
            if (!string.IsNullOrWhiteSpace(txtAltConnectPort.Text))
            {
                if (!int.TryParse(txtAltConnectPort.Text.Trim(), out altCsPort) || altCsPort <= 0 || altCsPort > 65535)
                {
                    MessageBox.Show("Por favor informe uma Porta CS válida para a Rota Alternativa (ex: 44405).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int altPort = 55901;
            if (!string.IsNullOrWhiteSpace(txtAltPort.Text))
            {
                if (!int.TryParse(txtAltPort.Text.Trim(), out altPort) || altPort <= 0 || altPort > 65535)
                {
                    MessageBox.Show("Por favor informe uma Porta GS válida para a Rota Alternativa (1-65535).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            _config.MainRouteIp = txtMainIp.Text.Trim();
            _config.ConnectServerPort = mainCsPort;
            _config.MainRoutePort = mainPort;

            _config.AltRouteIp = txtAltIp.Text.Trim();
            _config.AltConnectServerPort = altCsPort;
            _config.AltRoutePort = altPort;

            _config.ExecutableName = string.IsNullOrWhiteSpace(txtExecutable.Text) ? "main.exe" : txtExecutable.Text.Trim();
            _config.LaunchArgumentsMode = cboArgsMode.SelectedIndex >= 0 ? cboArgsMode.SelectedIndex : 0;

            _config.WebsiteUrl = txtWebsiteUrl.Text.Trim();
            _config.RegisterUrl = txtRegisterUrl.Text.Trim();
            _config.RegisterApiUrl = txtRegisterApiUrl.Text.Trim();
            _config.RankingUrl = txtRankingUrl.Text.Trim();
            _config.NewsUrl = txtNewsUrl.Text.Trim();

            _config.VerifyMainIntegrity = chkVerifyIntegrity.Checked;
            _config.EnableAntiCheatScan = chkAntiCheat.Checked;
            _config.EnableDllWhitelist = chkDllWhitelist.Checked;
            _config.EnableLauncherGuard = chkLauncherGuard.Checked;
            _config.RestoreLauncherOnGameClose = chkRestoreLauncher.Checked;
            _config.EnableMutexLock = chkMutexLock.Checked;
            _config.EncryptConfigFile = chkEncryptConfig.Checked;
            _config.LauncherMutexName = string.IsNullOrWhiteSpace(txtMutexName.Text) ? @"Global\MuOnline_Launcher_Active_Lock" : txtMutexName.Text.Trim();
            _config.MainMd5Hash = txtMainHash.Text.Trim();

            if (_config.Save())
            {
                string encInfo = _config.EncryptConfigFile ? " (Criptografado com AES-256)" : " (Texto Plano)";
                MessageBox.Show($"Configurações salvas com sucesso em 'launcher_config.json'{encInfo}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao salvar as configurações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnTestMain_Click(object sender, EventArgs e)
        {
            string ip = txtMainIp.Text.Trim();
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Por favor informe o IP da Rota Principal para testar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int port = 44405;
            if (!string.IsNullOrWhiteSpace(txtMainConnectPort.Text) && (!int.TryParse(txtMainConnectPort.Text.Trim(), out port) || port <= 0 || port > 65535))
            {
                MessageBox.Show("Porta CS inválida (1-65535).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestMain.Enabled = false;
            btnTestMain.Text = "Testando...";

            bool isOnline = await TestTcpConnectionAsync(ip, port);

            btnTestMain.Enabled = true;
            btnTestMain.Text = "Testar Rota Principal";

            if (isOnline)
            {
                MessageBox.Show($"ConnectServer da Rota Principal ({ip}:{port}) está ONLINE e acessível!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Não foi possível conectar ao ConnectServer da Rota Principal em {ip}:{port}.\nVerifique se o servidor está ligado e as portas liberadas no Firewall.", "Falha de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnTestAlt_Click(object sender, EventArgs e)
        {
            string ip = txtAltIp.Text.Trim();
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Por favor informe o IP da Rota Alternativa para testar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int port = 44405;
            if (!string.IsNullOrWhiteSpace(txtAltConnectPort.Text) && (!int.TryParse(txtAltConnectPort.Text.Trim(), out port) || port <= 0 || port > 65535))
            {
                MessageBox.Show("Porta CS inválida (1-65535).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTestAlt.Enabled = false;
            btnTestAlt.Text = "Testando...";

            bool isOnline = await TestTcpConnectionAsync(ip, port);

            btnTestAlt.Enabled = true;
            btnTestAlt.Text = "Testar Rota Alternativa";

            if (isOnline)
            {
                MessageBox.Show($"ConnectServer da Rota Alternativa ({ip}:{port}) está ONLINE e acessível!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Não foi possível conectar ao ConnectServer da Rota Alternativa em {ip}:{port}.\nVerifique o IP e portas no Firewall.", "Falha de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task<bool> TestTcpConnectionAsync(string host, int port)
        {
            try
            {
                using var client = new TcpClient();
                var connectTask = client.ConnectAsync(host, port);
                var timeoutTask = Task.Delay(3500);

                var completedTask = await Task.WhenAny(connectTask, timeoutTask);
                return completedTask == connectTask && client.Connected;
            }
            catch
            {
                return false;
            }
        }

        private void BtnGetLocalHash_Click(object sender, EventArgs e)
        {
            string exeName = string.IsNullOrWhiteSpace(txtExecutable.Text) ? "main.exe" : txtExecutable.Text.Trim();
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, exeName);

            if (!File.Exists(exePath))
            {
                using var dlg = new OpenFileDialog();
                dlg.Title = $"Selecione o arquivo '{exeName}' para calcular o Hash MD5";
                dlg.Filter = "Executáveis (*.exe)|*.exe|Todos os Arquivos (*.*)|*.*";
                dlg.FileName = exeName;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    exePath = dlg.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                string hash = CalculateMd5(exePath);
                txtMainHash.Text = hash;
                MessageBox.Show($"Hash MD5 calculado com sucesso:\n{hash}\n\nO valor foi preenchido no campo correspondente.", "Hash MD5 Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao calcular Hash MD5: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CalculateMd5(string filePath)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filePath);
            byte[] hashBytes = md5.ComputeHash(stream);
            return Convert.ToHexString(hashBytes).ToLowerInvariant();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateFooterStatus()
        {
            if (chkEncryptConfig.Checked)
            {
                lblFooterInfo.Text = "Proteção Ativa: 'launcher_config.json' com criptografia AES-256";
                lblFooterInfo.ForeColor = Color.FromArgb(30, 100, 50);
            }
            else
            {
                lblFooterInfo.Text = "Aviso: 'launcher_config.json' em texto plano (não recomendado)";
                lblFooterInfo.ForeColor = Color.FromArgb(160, 50, 40);
            }
        }
    }
}
