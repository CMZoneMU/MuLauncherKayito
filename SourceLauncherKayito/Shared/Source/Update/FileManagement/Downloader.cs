using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
// External
using Shared.Network;
using Shared.Utils;

namespace Shared.Update
{
	public class FileDownloader
	{
		private const int MAX_PARALLEL_DOWNLOADS = 4;
		
		private long _totalDownloaded;

		public async Task DownloadFiles(
			List<UpdateFileInfo> files,
			string baseUrl,
			long totalBytes,
			IProgress<UpdateProgress> progress)
		{
			var semaphore = new SemaphoreSlim(MAX_PARALLEL_DOWNLOADS);
			var tasks = new List<Task>();

			_totalDownloaded = 0;

			foreach (var file in files)
			{
				await semaphore.WaitAsync();

				tasks.Add(Task.Run(async () =>
				{
					try
					{
						await DownloadSingleFile(
							file,
							baseUrl,
							totalBytes,
							progress
						);
					}
					finally
					{
						semaphore.Release();
					}
				}));
			}

			await Task.WhenAll(tasks);
		}

		private async Task DownloadSingleFile(
			UpdateFileInfo file,
			string baseUrl,
			long totalBytes,
			IProgress<UpdateProgress> progress)
		{
			string url = new Uri(new Uri(baseUrl), file.Path).ToString();

			for (int retry = 0; retry < 3; retry++)
			{
				try
				{
					using (var response = await HttpClientManager.Client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
					{
						response.EnsureSuccessStatusCode();

						using (var stream = await response.Content.ReadAsStreamAsync())
						{
							string localPath = PathHelper.GetLocalPath(file.Path);

							Directory.CreateDirectory(Path.GetDirectoryName(localPath));

							using (var fs = new FileStream(localPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
							{
								byte[] buffer = new byte[65536];

								int read;
								long current = 0;

								while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
								{
									await fs.WriteAsync(buffer, 0, read);

									current += read;

									long total = Interlocked.Add(ref _totalDownloaded, read);

									progress.Report(new UpdateProgress
									{
										StatusKey = "UPDATE_DOWNLOADING",
										Args = new object[] { file.Path },

										CurrentFileDownloaded = current,
										CurrentFileSize = file.Size,

										TotalBytesDownloaded = total,

										TotalBytes = totalBytes
									});
								}
							}
						}
					}

					if (!FileVerifier.Verify(file))
					{
						throw new IOException($"Hash mismatch: {file.Path}");
					}

					return;
				}
				catch
				{
					if (retry == 2)
					{
						throw;
					}

					await Task.Delay(2000);
				}
			}
		}
	}
}
