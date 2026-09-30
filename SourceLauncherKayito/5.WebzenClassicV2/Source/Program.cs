using System;
using System.Threading;
using System.Windows.Forms;
using Shared.Utils;
using MuLauncher;

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

            try
            {
                if (!SystemManager.IsRunningAsAdmin())
                {
                    throw new Exception("This application must be run as administrator.");
                }

                bool created;
                launcherMutex = new Mutex(true, "Global\\MuLauncherKayito_CMZ", out created);

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

