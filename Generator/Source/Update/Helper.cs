using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Threading;
// External
using Generator.FileEntry;
using Shared.Update;
using Shared.Utils;

namespace Generator.Update
{
	public static class UpdateHelper
	{
		public static void BuildUpdatePackage(
			string zipPath,
			string manifestName,
			List<FileModel> files,
			FileModel launcher,
			IProgress<(int, string)> progress)
		{
			UpdateFileInfo launcherEntry = null;
			var fileEntries = new List<UpdateFileInfo>();

			int total = files.Count + (launcher != null ? 1 : 0);
			int processed = 0;

			using (var zip = ZipFile.Open(zipPath, ZipArchiveMode.Create))
			{
				Action<FileModel, string, string, bool> processFile = (
					file,
					zipEntryPath,
					manifestEntryPath,
					isLauncher
				) =>
				{
					using (var stream = File.OpenRead(file.FullPath))
					{
						long size = stream.Length;

						byte[] hashBytes;

						using (var sha = SHA256.Create())
						{
							hashBytes = sha.ComputeHash(stream);
						}

						string hash = BitConverter
							.ToString(hashBytes)
							.Replace("-", "");

						var entryModel = new UpdateFileInfo
						{
							Path = manifestEntryPath,
							Size = size,
							Hash = hash
						};

						if (isLauncher)
						{
							launcherEntry = entryModel;
						}
						else
						{
							fileEntries.Add(entryModel);
						}

						stream.Position = 0;

						var entry = zip.CreateEntry(zipEntryPath, CompressionLevel.Optimal);

						using (var zipStream = entry.Open())
						{
							stream.CopyTo(zipStream);
						}

						int current = Interlocked.Increment(ref processed);
						int percent = current * 100 / total;

						if (progress != null)
						{
							progress.Report((percent, $"Processing files: {percent}%"));
						}
					}
				};

				if (launcher != null)
				{
					string normalized = PathHelper.NormalizePath(launcher.RelativePath);

					string zipFilePath = "Launcher/" + normalized;

					string manifestFilePath = normalized;

					processFile(launcher, zipFilePath, manifestFilePath, true);
				}

				foreach (var file in files)
				{
					string normalized = PathHelper.NormalizePath(file.RelativePath);

					string zipFilePath = "FileList/" + normalized;

					string manifestFilePath = normalized;

					processFile(file, zipFilePath, manifestFilePath, false);
				}

				if (progress != null)
				{
					progress.Report((99, "Writing manifest..."));
				}

				var manifest = new UpdateManifest
				{
					Launcher = launcherEntry,
					FileList = fileEntries
				};

				string json = JsonHelper.Serialize(manifest);

				var manifestEntry = zip.CreateEntry(manifestName, CompressionLevel.Optimal);

				using (var writer = new StreamWriter(manifestEntry.Open()))
				{
					writer.Write(json);
				}

				if (progress != null)
				{
					progress.Report((100, "Update generation completed"));
				}
			}
		}
	}
}
