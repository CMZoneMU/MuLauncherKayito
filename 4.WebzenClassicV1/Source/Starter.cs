using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// External
using Shared.LauncherConfig;
using Shared.Network;
using Shared.Update;
using Shared.Utils;

namespace Launcher
{
	public class UpdateStarter
	{
		private readonly NetworkService network = new NetworkService();
		private readonly ManifestDownloader manifest = new ManifestDownloader();
		private readonly FileScanner scanner = new FileScanner();
		private readonly FileDownloader downloader = new FileDownloader();

		public async Task Start(IProgress<UpdateProgress> progress)
		{
			var config = ConfigManager.Current;

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_CONNECTING"
			});

			await this.network.CheckNetwork(config.UpdatesURL);

			UpdateManifest patchManifest = null;

			if (RuntimeFlags.BypassUpdater)
			{
				progress.Report(new UpdateProgress
				{
					StatusKey = "UPDATE_DOWNLOADING_MANIFEST"
				});

				string manifestUrl = new Uri(new Uri(config.UpdatesURL), config.UpdateFilename).ToString();

				patchManifest =
					await this.manifest.DownloadManifest(manifestUrl);
			}
			else
			{
				patchManifest = ManifestManager.Current;
			}

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_SCANNING"
			});

			var filesToUpdate =
				await this.scanner.ScanFiles(patchManifest.FileList, progress);

			long patchSize =
				filesToUpdate.Sum(x => x.Size);

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_CHECKING_RESULT",

				Args = new object[] { filesToUpdate.Count }
			});

			string updatesURL =
				new Uri(new Uri(config.UpdatesURL), "FileList/").ToString();

			await this.downloader.DownloadFiles(
				filesToUpdate,
				updatesURL,
				patchSize,
				progress);

			progress.Report(new UpdateProgress
			{
				StatusKey = "UPDATE_COMPLETE"
			});

			this.network.CloseNetwork();

			await Task.Delay(300);

			await this.LaunchGame(config);
		}

		private async Task LaunchGame(ConfigModel config)
		{
			string gamePath = PathHelper.GetLocalPath(config.GameExecutable);

			if (!File.Exists(gamePath))
			{
				throw new FileNotFoundException($"{config.GameExecutable} not found.");
			}

			var process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = gamePath,
					WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
					UseShellExecute = true
				}
			};

			if (!process.Start())
			{
				throw new Exception("Failed to start game.");
			}

			try
			{
				process.WaitForInputIdle(10000);
			}
			catch
			{

			}

			await Task.Delay(3000);

			Application.Exit();
		}
	}
}
