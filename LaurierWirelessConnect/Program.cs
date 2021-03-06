﻿#region Copyright
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
using System.Globalization;
using System.Management;
using System.Windows.Forms;

[assembly:CLSCompliant(true)]
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
            try
            {
                Application.EnableVisualStyles();

                CheckOperatingSystem();

                ICommand installSecureW2 = new InstallSecureW2Command();
                ICommand mergeRegistryKeys = new MergeRegistryKeysCommand();
                ICommand setupProfile = new SetupProfileCommand();

                FormSetupProgress fsp = new FormSetupProgress();
                fsp.Show();

                fsp.UpdateCurrentCommandDescriptionLabel(installSecureW2.HumanReadableExecutionDescription);
                installSecureW2.Execute();
                fsp.DisplayStepCheckmark(1);
                fsp.UpdateSetupProgressBarValue(1);
                fsp.UpdateCurrentCommandDescriptionLabel(mergeRegistryKeys.HumanReadableExecutionDescription);
                mergeRegistryKeys.Execute();
                fsp.DisplayStepCheckmark(2);
                fsp.UpdateSetupProgressBarValue(2);
                fsp.UpdateCurrentCommandDescriptionLabel(setupProfile.HumanReadableExecutionDescription);
                setupProfile.Execute();
                fsp.DisplayStepCheckmark(3);
                fsp.UpdateSetupProgressBarValue(3);
                fsp.UpdateCurrentCommandDescriptionLabel("Configuration completed!");

                if (IsWindowsXp())
                {
                    MessageBox.Show(String.Format(CultureInfo.CurrentCulture, 
                        "Configuration successfully completed! {0}{0}You can now uninstall Laurier Wireless Connect.{0}{0}You will also need to restart your computer before you can use the Laurier Wireless network.", 
                        Environment.NewLine));
                }
                else
                {
                    MessageBox.Show(String.Format(CultureInfo.CurrentCulture, "Configuration successfully completed! {0}{0}You can now uninstall Laurier Wireless Connect.", Environment.NewLine));
                }
                fsp.Hide();
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(CultureInfo.CurrentCulture, "An error occurred: {0}", e.Message));
                Environment.Exit(2);
            }
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
                    Environment.Exit(3);
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
                try
                {
                    return int.Parse(mo["ServicePackMajorVersion"].ToString(), CultureInfo.InvariantCulture);
                }
                catch (Exception e)
                {
                    throw new WmiException("Unable to determine Service Pack major version.", e);
                }
            }
            throw new WmiException("Unable to determine Service Pack major version.");
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

        /// <summary>
        /// Returns whether or not the client operating system is Windows XP
        /// </summary>
        /// <returns>True if the client operating system is Windows XP, false if not</returns>
        static bool IsWindowsXp()
        {
            return (System.Environment.OSVersion.Version.Major == 5);
        }
    }
}
