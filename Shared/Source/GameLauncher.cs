using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher
{
    public static class GameLauncher
    {
        public static async Task Launch(LauncherConfig config)
        {
            string execName = string.IsNullOrWhiteSpace(config.ExecutableName) ? "main.exe" : config.ExecutableName.Trim();
            string gamePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, execName);

            if (!File.Exists(gamePath))
            {
                MessageBox.Show($"{execName} not found in the current directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
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

            try
            {
                if (!process.Start())
                {
                    throw new Exception("Failed to start the game process.");
                }

                try
                {
                    process.WaitForInputIdle(10000);
                }
                catch
                {
                    // Ignore if it doesn't have a graphical interface or times out
                }

                await Task.Delay(2000);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to launch game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
