#region Copyright
// <copyright file="LICENSE.txt" company="Open Source at Laurier">
//
// Copyright (C) 2010 Open Source at Laurier
//
// This file is part of the Laurier Wireless Autoconfiguration Tool.
//
// The Laurier Wireless Autoconfiguration Tool is free software: you can
// redistribute it and/or modify it under the terms of the GNU General 
// Public License as published by the Free Software Foundation, either 
// version 3 of the License, or (at your option) any later version.
//
// The Laurier Wireless Autoconfiguration Tool is distributed in the 
// hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
// PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
//
// You should have received a copy of the GNU General Public License
// along with the Laurier Wireless Autoconfiguration Tool.  If not,
// see <http://www.gnu.org/licenses/>.
// </copyright>
#endregion

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
