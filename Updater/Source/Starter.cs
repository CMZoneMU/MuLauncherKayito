using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
// External
using Shared.LauncherConfig;
using Shared.LauncherPayload;
using Shared.Update;
using Shared.Utils;

namespace Updater
{
	public class UpdateStarter
	{
		private readonly ManifestDownloader manifest = new ManifestDownloader();
		private readonly FileDownloader downloader = new FileDownloader();

		public async Task Start(IProgress<UpdateProgress> progress)
		{
			var config = ConfigManager.Current;

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_DOWNLOADING_MANIFEST"
			});

			string manifestUrl = new Uri(new Uri(config.UpdatesURL), config.UpdateFilename).ToString();

			var patchManifest =
				await this.manifest.DownloadManifest(manifestUrl);

			if (patchManifest.Launcher != null)
			{
				progress.Report(new UpdateProgress
				{
					StatusKey = "UPDATE_CHECKING_LAUNCHER"
				});

				if (FileVerifier.NeedsUpdate(patchManifest.Launcher))
				{
					progress.Report(new UpdateProgress
					{
						StatusKey = "UPDATE_UPDATING_LAUNCHER"
					});

					string launcherURL =
						new Uri(new Uri(config.UpdatesURL), "Launcher/").ToString();

					await this.downloader.DownloadFiles(
						new System.Collections.Generic.List<UpdateFileInfo>
						{
							patchManifest.Launcher
						},
						launcherURL,
						patchManifest.Launcher.Size,
						progress);
				}
			}

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_STARTING_LAUNCHER"
			});

			await Task.Delay(300);

			this.StartLauncher(config, patchManifest);

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_COMPLETE"
			});

			await Task.Delay(3000);
		}

		private void StartLauncher(ConfigModel config, UpdateManifest manifest)
		{
			string launcherPath = PathHelper.GetLocalPath("Launcher.exe");

			if (!File.Exists(launcherPath))
			{
				throw new FileNotFoundException("Launcher.exe not found.");
			}

			string token = Guid.NewGuid().ToString();

			var payload = new LauncherPayload
			{
				Token = token,
				Config = config,
				Manifest = manifest
			};

			string json = JsonHelper.Serialize(payload);

			using (var process = new Process())
			{
				process.StartInfo.FileName = launcherPath;
				process.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;

				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardInput = true;

				if (!process.Start())
				{
					throw new Exception("Failed to start launcher.");
				}

				if (process.HasExited)
				{
					throw new Exception("Launcher exited unexpectedly.");
				}

				process.StandardInput.Write(json);
				process.StandardInput.Flush();
				process.StandardInput.Close();
			}
		}
	}
}
