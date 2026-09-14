using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
// External
using Shared.LauncherConfig;
using Shared.LauncherPayload;
using Shared.Update;
using Shared.Utils;

namespace Launcher
{
	internal static class Program
	{
		private static Mutex launcherMutex;

		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			RuntimeFlags.Initialize(args);

			try
			{
				if (!SystemManager.IsRunningAsAdmin())
				{
					throw new Exception("This application must be run as administrator.");
				}

				ConfigModel config;

				if (RuntimeFlags.BypassUpdater)
				{
					config = ConfigHelper.LoadFile(ConfigManager.ConfigPath);

					ConfigManager.Set(config);
				}
				else
				{
					LauncherPayload payload = PayloadHelper.ReadFromStdIn();

					if (payload == null || string.IsNullOrEmpty(payload.Token))
					{
						var result = MessageBox.Show(
							"Launcher must be started by the updater.\n\nWant to try launching it?",
							"Launcher",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Error
						);

						if (result == DialogResult.Yes)
						{
							try
							{
								string updaterPath = PathHelper.GetLocalPath("Updater.exe");

								if (!File.Exists(updaterPath))
								{
									throw new FileNotFoundException("Updater.exe not found.");
								}

								var psi = new ProcessStartInfo
								{
									FileName = updaterPath,
									UseShellExecute = false
								};

								Process.Start(psi);
							}
							catch (Exception ex)
							{
								MessageBox.Show(
								    $"Failed to start updater:\n\n{ex.Message}\n\nHRESULT: {ex.HResult}",
								    "Launcher",
								    MessageBoxButtons.OK,
								    MessageBoxIcon.Error
								);
							}
						}

						return;
					}

					ManifestManager.Set(payload.Manifest);

					config = payload.Config;

					ConfigManager.Set(config);
				}

				bool created;

				launcherMutex = new Mutex(true, config.MutexName, out created);

				if (!created)
				{
					throw new Exception("Launcher is already running.");
				}

				Application.Run(new Main());
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Failed to start launcher.\n\n" + ex.Message,
					"Launcher error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
	}
}
