using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MuLauncher
{
    /// <summary>
    /// Armazena os parâmetros de servidor do Launcher (IPs das Rotas, Portas do ConnectServer e URL do servidor Web).
    /// Permite que o administrador do servidor configure o Launcher via arquivo JSON de configuração (launcher_config.json).
    /// Suporta criptografia simétrica AES-256 para impedir visualização e adulteração de parâmetros de segurança por jogadores.
    /// </summary>
    public class LauncherConfig
    {
        private static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Local\Launcher\launcher_config.json");
        private const string EncryptedPrefix = "CMZENC:";
        private const string SecretPassphrase = "CMZ_ZenMU_Launcher_SecretKey_2026!#$";

        [JsonPropertyName("main_route_ip")]
        public string MainRouteIp { get; set; } = "";

        [JsonPropertyName("connect_server_port")]
        public int ConnectServerPort { get; set; } = 44405;

        [JsonPropertyName("main_route_port")]
        public int MainRoutePort { get; set; } = 55901;

        [JsonPropertyName("alt_route_ip")]
        public string AltRouteIp { get; set; } = "";

        [JsonPropertyName("alt_connect_server_port")]
        public int AltConnectServerPort { get; set; } = 44405;

        [JsonPropertyName("alt_route_port")]
        public int AltRoutePort { get; set; } = 55901;

        [JsonPropertyName("update_server_url")]
        public string UpdateServerUrl { get; set; } = "";

        [JsonPropertyName("update_provider")]
        public string UpdateProvider { get; set; } = "Http"; // "Http" ou "GitHub"

        [JsonPropertyName("github_owner")]
        public string GitHubOwner { get; set; } = "";

        [JsonPropertyName("github_repo")]
        public string GitHubRepo { get; set; } = "";

        [JsonPropertyName("github_branch")]
        public string GitHubBranch { get; set; } = "main";

        [JsonPropertyName("github_token")]
        public string GitHubToken { get; set; } = "";

        [JsonPropertyName("use_github_releases")]
        public bool UseGitHubReleases { get; set; } = true;

        [JsonPropertyName("enable_downloader")]
        public bool EnableDownloader { get; set; } = false;

        [JsonPropertyName("downloader_owner")]
        public string DownloaderOwner { get; set; } = "";

        [JsonPropertyName("downloader_repo")]
        public string DownloaderRepo { get; set; } = "";

        [JsonPropertyName("downloader_token")]
        public string DownloaderToken { get; set; } = "";

        [JsonPropertyName("downloader_file1")]
        public string DownloaderFile1 { get; set; } = "client_com_som.zip";

        [JsonPropertyName("downloader_file2")]
        public string DownloaderFile2 { get; set; } = "client_sem_som.zip";

        [JsonPropertyName("downloader_completed")]
        public bool DownloaderCompleted { get; set; } = false;

        [JsonPropertyName("executable_name")]
        public string ExecutableName { get; set; } = "main.exe";

        [JsonPropertyName("verify_main_integrity")]
        public bool VerifyMainIntegrity { get; set; } = true;

        [JsonPropertyName("main_md5_hash")]
        public string MainMd5Hash { get; set; } = "";

        [JsonPropertyName("enable_anticheat_scan")]
        public bool EnableAntiCheatScan { get; set; } = true;

        [JsonPropertyName("enable_dll_whitelist")]
        public bool EnableDllWhitelist { get; set; } = true;

        [JsonPropertyName("unauthorized_dll_action")]
        public int UnauthorizedDllAction { get; set; } = 0;

        [JsonPropertyName("enable_launcher_guard")]
        public bool EnableLauncherGuard { get; set; } = true;

        [JsonPropertyName("restore_launcher_on_game_close")]
        public bool RestoreLauncherOnGameClose { get; set; } = true;

        [JsonPropertyName("enable_mutex_lock")]
        public bool EnableMutexLock { get; set; } = true;

        [JsonPropertyName("launcher_mutex_name")]
        public string LauncherMutexName { get; set; } = @"Global\MuOnline_Launcher_Active_Lock";

        [JsonPropertyName("encrypt_config_file")]
        public bool EncryptConfigFile { get; set; } = true;

        [JsonPropertyName("launch_arguments_mode")]
        public int LaunchArgumentsMode { get; set; } = 0;

        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; } = "";

        [JsonPropertyName("register_url")]
        public string RegisterUrl { get; set; } = "";

        [JsonPropertyName("register_api_url")]
        public string RegisterApiUrl { get; set; } = "";

        [JsonPropertyName("ranking_url")]
        public string RankingUrl { get; set; } = "";

        [JsonPropertyName("news_url")]
        public string NewsUrl { get; set; } = "";

        /// <summary>
        /// Criptografa uma string em texto plano usando AES-256 (CBC com PKCS7) e derivação SHA-256.
        /// </summary>
        public static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return "";

            byte[] keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(SecretPassphrase));
            using var aes = Aes.Create();
            aes.KeySize = 256;
            aes.Key = keyBytes;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.GenerateIV();

            using var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream();

            // Grava o IV nos primeiros 16 bytes
            ms.Write(aes.IV, 0, aes.IV.Length);

            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs, Encoding.UTF8))
            {
                sw.Write(plainText);
            }

            return EncryptedPrefix + Convert.ToBase64String(ms.ToArray());
        }

        /// <summary>
        /// Descriptografa uma string cifrada (com prefixo CMZENC:) usando AES-256.
        /// </summary>
        public static string DecryptString(string cipherText)
        {
            if (string.IsNullOrWhiteSpace(cipherText)) return "";

            string rawBase64 = cipherText.Trim();
            if (rawBase64.StartsWith(EncryptedPrefix, StringComparison.OrdinalIgnoreCase))
            {
                rawBase64 = rawBase64.Substring(EncryptedPrefix.Length);
            }

            byte[] allBytes = Convert.FromBase64String(rawBase64);
            if (allBytes.Length < 16)
            {
                throw new InvalidOperationException("Conteúdo criptografado corrompido ou truncado.");
            }

            byte[] keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(SecretPassphrase));
            byte[] iv = new byte[16];
            Buffer.BlockCopy(allBytes, 0, iv, 0, 16);

            int cipherLength = allBytes.Length - 16;
            byte[] cipherBytes = new byte[cipherLength];
            Buffer.BlockCopy(allBytes, 16, cipherBytes, 0, cipherLength);

            using var aes = Aes.Create();
            aes.KeySize = 256;
            aes.Key = keyBytes;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream(cipherBytes);
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            using var sr = new StreamReader(cs, Encoding.UTF8);

            return sr.ReadToEnd();
        }

        /// <summary>
        /// Carrega as configurações do servidor a partir do launcher_config.json.
        /// Suporta tanto JSON puro quanto arquivos criptografados com AES-256 (prefixo CMZENC:).
        /// </summary>
        public static LauncherConfig Load()
        {
            try
            {
                if (File.Exists(ConfigPath))
                {
                    string content = File.ReadAllText(ConfigPath).Trim();
                    string json;

                    if (content.StartsWith(EncryptedPrefix, StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            json = DecryptString(content);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"[LauncherConfig] Falha na descriptografia AES-256: {ex.Message}");
                            return new LauncherConfig();
                        }
                    }
                    else
                    {
                        // JSON puro em texto claro
                        json = content;
                    }

                    var config = JsonSerializer.Deserialize<LauncherConfig>(json);
                    if (config != null) return config;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[LauncherConfig] Erro ao carregar arquivo de configuracao: {ex.Message}");
            }

            return new LauncherConfig();
        }

        /// <summary>
        /// Grava as configurações atualizadas no arquivo launcher_config.json.
        /// Se EncryptConfigFile estiver ativo, grava o conteúdo protegido com AES-256.
        /// </summary>
        public bool Save()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(this, options);

                string? dir = Path.GetDirectoryName(ConfigPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                string contentToWrite = EncryptConfigFile ? EncryptString(json) : json;
                File.WriteAllText(ConfigPath, contentToWrite);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[LauncherConfig] Erro ao salvar arquivo de configuracao: {ex.Message}");
                return false;
            }
        }
    }
}
