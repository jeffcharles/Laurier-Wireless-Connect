using System;
using System.Windows.Forms;

namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSetupProgress());

            ICommand installSecureW2 = new InstallSecureW2Command();
            ICommand mergeRegistryKeys = new MergeRegistryKeysCommand();
            ICommand setupProfile = new SetupProfileCommand();

            installSecureW2.Execute();
            mergeRegistryKeys.Execute();
            setupProfile.Execute();

            Application.Exit();
        }

        static bool isClientSupported()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;

            if ((osInfo.Version.Major == 5 && osInfo.Version.Minor == 1 && Convert.ToInt16(osInfo.ServicePack) >= 3) ||
                (osInfo.Version.Major == 6 && osInfo.Version.Minor == 0 && Convert.ToInt16(osInfo.ServicePack) >= 2) ||
                (osInfo.Version.Major == 6 && osInfo.Version.Minor >= 1) && (osInfo.Version.Major >= 7))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
