using System;
using System.Threading;
using System.Windows.Forms;
// External
using Shared.LauncherConfig;
using Shared.Utils;

namespace Updater
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				if (!SystemManager.IsRunningAsAdmin())
				{
					throw new Exception("This application must be run as administrator.");
				}

				ConfigModel config = ConfigHelper.LoadFile(ConfigManager.ConfigPath);

				ConfigManager.Set(config);

				bool launcherRunning;

				try
				{
					Mutex.OpenExisting(config.MutexName);

					launcherRunning = true;
				}
				catch (WaitHandleCannotBeOpenedException)
				{
					launcherRunning = false;
				}

				if (launcherRunning)
				{
					throw new Exception("Please close the launcher before updating.");
				}

				Application.Run(new Main());
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Failed to start updater.\n\n" + ex.Message,
					"Updater error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
	}
}
