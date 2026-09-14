using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace UpdateBuilder
{
    public class ManifestService
    {
        private static readonly HashSet<string> IgnoredFileNames = new(StringComparer.OrdinalIgnoreCase)
        {
            "lista.txt",
            "update.json",
            "hash.json",
            "launcher_config.json",
            "thumbs.db",
            ".ds_store",
            "desktop.ini"
        };

        private static readonly HashSet<string> IgnoredExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".tmp",
            ".bak",
            ".pdb",
            ".log"
        };

        /// <summary>
        /// Calcula a HASH MD5 de um arquivo usando streaming em blocos.
        /// </summary>
        public static async Task<string> CalculateFileMD5Async(string filePath, CancellationToken cancellationToken = default)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Arquivo não encontrado.", filePath);

            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 8192, useAsync: true);
            using var md5 = MD5.Create();
            byte[] hashBytes = await md5.ComputeHashAsync(stream, cancellationToken);
            return Convert.ToHexString(hashBytes).ToLowerInvariant();
        }

        /// <summary>
        /// Processa um único arquivo específico, gerando seu UpdateItem com Hash e Tamanho.
        /// </summary>
        public static async Task<UpdateItem> ProcessSingleFileAsync(string filePath, string rootDir, CancellationToken cancellationToken = default)
        {
            FileInfo info = new FileInfo(filePath);
            if (!info.Exists)
                throw new FileNotFoundException("Arquivo especificado não existe.", filePath);

            string hash = await CalculateFileMD5Async(filePath, cancellationToken);
            string relativePath = Path.GetRelativePath(rootDir, filePath).Replace('\\', '/');

            return new UpdateItem
            {
                Path = relativePath,
                Hash = hash,
                Size = info.Length
            };
        }

        /// <summary>
        /// Escaneia um diretório recursivamente e calcula a hash MD5 de todos os arquivos elegíveis.
        /// </summary>
        public static async Task<List<UpdateItem>> ScanDirectoryAsync(
            string rootDir,
            IProgress<(int current, int total, string currentFile)>? progress = null,
            CancellationToken cancellationToken = default)
        {
            if (!Directory.Exists(rootDir))
                throw new DirectoryNotFoundException($"O diretório '{rootDir}' não existe.");

            List<string> allFiles = Directory.GetFiles(rootDir, "*", SearchOption.AllDirectories)
                .Where(f => !IsIgnored(f, rootDir))
                .ToList();

            List<UpdateItem> items = new List<UpdateItem>();
            int total = allFiles.Count;

            for (int i = 0; i < total; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                string fullPath = allFiles[i];
                string relPath = Path.GetRelativePath(rootDir, fullPath).Replace('\\', '/');

                progress?.Report((i + 1, total, relPath));

                FileInfo fi = new FileInfo(fullPath);
                string hash = await CalculateFileMD5Async(fullPath, cancellationToken);

                items.Add(new UpdateItem
                {
                    Path = relPath,
                    Hash = hash,
                    Size = fi.Length
                });
            }

            return items;
        }

        /// <summary>
        /// Carrega manifesto nos formatos update.json ou lista.txt.
        /// </summary>
        public static async Task<List<UpdateItem>> LoadManifestAsync(string filePath, CancellationToken cancellationToken = default)
        {
            List<UpdateItem> list = new List<UpdateItem>();
            string ext = Path.GetExtension(filePath).ToLowerInvariant();

            if (ext == ".json")
            {
                string json = await File.ReadAllTextAsync(filePath, cancellationToken);
                var items = JsonSerializer.Deserialize<List<UpdateItem>>(json);
                if (items != null)
                {
                    list.AddRange(items);
                }
            }
            else
            {
                string[] lines = await File.ReadAllLinesAsync(filePath, cancellationToken);
                foreach (string line in lines)
                {
                    string trimmed = line.Trim();
                    if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("#"))
                        continue;

                    string[] parts = trimmed.Split('|');
                    if (parts.Length >= 2)
                    {
                        string path = parts[0].Trim();
                        string hash = parts[1].Trim();
                        long size = (parts.Length >= 3 && long.TryParse(parts[2].Trim(), out long parsedSize)) ? parsedSize : 0;

                        list.Add(new UpdateItem
                        {
                            Path = path,
                            Hash = hash,
                            Size = size
                        });
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Salva a lista no formato update.json.
        /// </summary>
        public static async Task SaveManifestJsonAsync(string filePath, IEnumerable<UpdateItem> items, CancellationToken cancellationToken = default)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(items, options);
            await File.WriteAllTextAsync(filePath, json, cancellationToken);
        }

        /// <summary>
        /// Salva a lista no formato lista.txt (caminho|hash|tamanho).
        /// </summary>
        public static async Task SaveManifestTxtAsync(string filePath, IEnumerable<UpdateItem> items, CancellationToken cancellationToken = default)
        {
            using var writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8);
            await writer.WriteLineAsync("# Formato: caminho_relativo|hash_md5|tamanho_bytes");
            foreach (var item in items)
            {
                await writer.WriteLineAsync($"{item.Path}|{item.Hash}|{item.Size}");
            }
        }

        private static bool IsIgnored(string filePath, string rootDir)
        {
            string fileName = Path.GetFileName(filePath);
            if (IgnoredFileNames.Contains(fileName)) return true;

            string ext = Path.GetExtension(filePath);
            if (IgnoredExtensions.Contains(ext)) return true;

            string relPath = Path.GetRelativePath(rootDir, filePath);
            if (relPath.StartsWith(".git", StringComparison.OrdinalIgnoreCase) ||
                relPath.StartsWith(".vs", StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
    }
}
