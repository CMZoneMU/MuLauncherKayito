using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace UpdateBuilder
{
    public static class ZipPackageService
    {
        private static readonly HashSet<string> IgnoredExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".tmp", ".zip", ".sha256"
        };

        /// <summary>
        /// Compacta os arquivos de uma pasta raiz em um arquivo ZIP com compactação otimizada.
        /// Suporta filtrar pastas de áudio (Data\Sound e Data\Music) para gerar pacotes "Sem Som".
        /// </summary>
        public static async Task<int> CreateZipPackageAsync(
            string sourceFolder,
            string targetZipPath,
            bool excludeAudio,
            IProgress<(int percentage, string message)>? progress = null,
            CancellationToken ct = default)
        {
            if (!Directory.Exists(sourceFolder))
                throw new DirectoryNotFoundException($"A pasta raiz '{sourceFolder}' não foi encontrada.");

            string? targetDir = Path.GetDirectoryName(targetZipPath);
            if (!string.IsNullOrEmpty(targetDir) && !Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            if (File.Exists(targetZipPath))
            {
                File.Delete(targetZipPath);
            }

            // Listar arquivos a compactar
            var allFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories);
            var filesToPack = new List<(string fullPath, string relPath)>();

            foreach (var filePath in allFiles)
            {
                string ext = Path.GetExtension(filePath);
                if (IgnoredExtensions.Contains(ext)) continue;

                string relPath = Path.GetRelativePath(sourceFolder, filePath);

                // Ignorar arquivos temporários, git, etc.
                if (relPath.StartsWith(".git", StringComparison.OrdinalIgnoreCase) ||
                    relPath.StartsWith(".vs", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                // Filtro de áudio se for "Sem Som"
                if (excludeAudio)
                {
                    string norm = relPath.Replace('/', '\\');
                    if (norm.StartsWith(@"Data\Sound\", StringComparison.OrdinalIgnoreCase) ||
                        norm.StartsWith(@"Data\Music\", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                }

                filesToPack.Add((filePath, relPath));
            }

            int total = filesToPack.Count;
            if (total == 0)
                throw new InvalidOperationException("Nenhum arquivo encontrado para compactação.");

            await Task.Run(() =>
            {
                using var zipToOpen = new FileStream(targetZipPath, FileMode.Create);
                using var archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create, leaveOpen: false);

                for (int i = 0; i < total; i++)
                {
                    ct.ThrowIfCancellationRequested();

                    var item = filesToPack[i];
                    string entryName = item.relPath.Replace('\\', '/');

                    var entry = archive.CreateEntry(entryName, CompressionLevel.Optimal);
                    using (var entryStream = entry.Open())
                    using (var fileStream = new FileStream(item.fullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        fileStream.CopyTo(entryStream);
                    }

                    int pct = (int)(((double)(i + 1) / total) * 100);
                    progress?.Report((pct, $"Compactando ({i + 1}/{total}): {item.relPath}"));
                }
            }, ct);

            return total;
        }

        /// <summary>
        /// Calcula o hash SHA-256 do arquivo ZIP e salva um arquivo correspondente com extensão .sha256.
        /// </summary>
        public static async Task<string> GenerateSha256FileAsync(string targetZipPath)
        {
            if (!File.Exists(targetZipPath))
                throw new FileNotFoundException("Arquivo ZIP não encontrado para geração de SHA-256.", targetZipPath);

            using var sha = SHA256.Create();
            using var stream = new FileStream(targetZipPath, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, useAsync: true);

            byte[] hashBytes = await sha.ComputeHashAsync(stream);
            string hexHash = Convert.ToHexString(hashBytes).ToLowerInvariant();

            string sha256FilePath = targetZipPath + ".sha256";
            await File.WriteAllTextAsync(sha256FilePath, hexHash);

            return hexHash;
        }
    }
}
