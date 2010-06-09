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
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    class InstallSecureW2Command : ICommand
    {
        private const string humanReadableExecutionDescription = "Now installing SecureW2 EAP client";

        public string HumanReadableExecutionDescription
        {
            get
            {
                return humanReadableExecutionDescription;
            }
        }

        /// <summary>
        /// Silently installs the SecureW2 EAP client
        /// </summary>
        public void Execute()
        {
            if (!IsInstalled())
            {
                HelperMethods.WriteEmbeddedFileToDisk("SecureW2_EAP_Suite_106.exe");
                Process installSecureW2 = Process.Start(HelperMethods.SetupProcess("SecureW2_EAP_Suite_106", "/S"));
                HelperMethods.MonitorProcessOutput(installSecureW2, "Error installing SecureW2 EAP client");
                File.Delete("SecureW2_EAP_Suite_106.exe");
                if (!IsInstalled())
                {
                    throw new Exception("Error installing SecureW2 EAP client");
                }
            }
        }

        /// <summary>
        /// Returns whether the SecureW2 EAP client is installed
        /// </summary>
        /// <returns>True if the client is installed, false if not</returns>
        protected bool IsInstalled()
        {
            string programFilesX86 = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            string programFilesPath = (String.IsNullOrEmpty(programFilesX86)) ? 
                Environment.GetEnvironmentVariable("ProgramFiles") : programFilesX86;
            
            return File.Exists(programFilesPath + "/SecureW2/Uninstall.exe");
        }
    }
}
