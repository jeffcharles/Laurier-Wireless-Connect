#region Copyright
// <copyright file="LICENSE.txt" company="Open Source at Laurier">
//
// Copyright (C) 2010 Open Source at Laurier
//
// This file is part of the Laurier Wireless Connect application.
//
// The Laurier Wireless Connect application is free software: you can
// redistribute it and/or modify it under the terms of the GNU General 
// Public License as published by the Free Software Foundation, either 
// version 3 of the License, or (at your option) any later version.
//
// The Laurier Wireless Connect application is distributed in the 
// hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
// PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
//
// You should have received a copy of the GNU General Public License
// along with the Laurier Wireless Connect application.  If not,
// see <http://www.gnu.org/licenses/>.
// </copyright>
#endregion

using System;
using System.Management;
using System.Windows.Forms;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
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

            CheckOperatingSystem();

            ICommand installSecureW2 = new InstallSecureW2Command();
            ICommand mergeRegistryKeys = new MergeRegistryKeysCommand();
            ICommand setupProfile = new SetupProfileCommand();

            FormSetupProgress fsp = new FormSetupProgress();
            fsp.Show();

            try
            {
                fsp.UpdateCurrentCommandDescriptionLabel(installSecureW2.HumanReadableExecutionDescription);
                installSecureW2.Execute();
                fsp.UpdateSetupProgressBarValue(1);
                fsp.UpdateCurrentCommandDescriptionLabel(mergeRegistryKeys.HumanReadableExecutionDescription);
                mergeRegistryKeys.Execute();
                fsp.UpdateSetupProgressBarValue(2);
                fsp.UpdateCurrentCommandDescriptionLabel(setupProfile.HumanReadableExecutionDescription);
                setupProfile.Execute();
                fsp.UpdateSetupProgressBarValue(3);
                fsp.UpdateCurrentCommandDescriptionLabel("");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
                Application.Exit();
            }

            MessageBox.Show(String.Format("Configuration successfully completed! {0}{1}You can now uninstall Laurier Wireless Connect.", Environment.NewLine, Environment.NewLine));
            fsp.Hide();
        }

        /// <summary>
        /// Checks if operating system is officially supported or supportable and prompts user accordingly
        /// </summary>
        static void CheckOperatingSystem()
        {
            if (!IsClientSupportable())
            {
                MessageBox.Show("Your operating system does not meet the minimum requirements for this application.",
                    "Unsupportable operating system");
                Environment.Exit(1);
            }

            if (!IsClientOfficiallySupported())
            {
                if (MessageBox.Show(@"This application has not been tested on your operating system. 
                    It may or may not run successfully. Do you wish to continue?", "Unsupported operating system",
                                                                                 MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Environment.Exit(1);
                }
            }
        }

        /// <summary>
        /// Returns the major version of the service pack installed on the client's operating system
        /// </summary>
        /// <returns>The major version of the currently installed operating system service pack</returns>
        static int GetServicePackMajorVersion()
        {
            SelectQuery query = new SelectQuery("SELECT ServicePackMajorVersion FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject mo in searcher.Get())
            {
                return int.Parse(mo["ServicePackMajorVersion"].ToString());
            }
            throw new ApplicationException("Unable to determine Service Pack major version.");
        }

        /// <summary>
        /// Returns whether the application has been tested successfully on this operating system
        /// </summary>
        /// <returns>True if the application has been tested successfully with this operating system, false if not</returns>
        static bool IsClientOfficiallySupported()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            int servicePackMajorVersion = GetServicePackMajorVersion();

            bool isXpSp3 = (osInfo.Version.Major == 5 && osInfo.Version.Minor == 1 && servicePackMajorVersion == 3);
            bool isVistaSp2 = (osInfo.Version.Major == 6 && osInfo.Version.Minor == 0 && servicePackMajorVersion == 2);
            bool is7Sp0 = (osInfo.Version.Major == 6 && osInfo.Version.Minor == 1 && servicePackMajorVersion == 0);

            return (isXpSp3 || isVistaSp2 || is7Sp0);
        }

        /// <summary>
        /// Returns whether this application should work on this operating system
        /// </summary>
        /// <returns>True if the application should run successfully on this operating system, false if not</returns>
        static bool IsClientSupportable()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            int servicePackMajorVersion = GetServicePackMajorVersion();

            bool isXpSp3OrGreater = (osInfo.Version.Major == 5 && osInfo.Version.Minor == 1 && servicePackMajorVersion >= 3);
            bool isVistaSp2OrGreater = (osInfo.Version.Major == 6 && osInfo.Version.Minor == 0 && servicePackMajorVersion >= 2);
            bool is7Sp0OrGreater = (osInfo.Version.Major == 6 && osInfo.Version.Minor == 1);
            bool isGreaterThan7 = (osInfo.Version.Major >= 7);

            return (isXpSp3OrGreater || isVistaSp2OrGreater || is7Sp0OrGreater || isGreaterThan7);
        }
    }
}
