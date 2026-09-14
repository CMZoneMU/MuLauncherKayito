using System;
using System.Windows.Forms;

namespace LauncherConfigurator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ConfigForm());
        }
    }
}
