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

using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
{
    class InstallSecureW2Command : ICommand
    {
        private const string humanReadableDescription = "Install SecureW2 EAP client";
        private const string humanReadableExecutionDescription = "Now installing SecureW2 EAP client";
        private const string humanReadableUndoDescription = "Now uninstalling SecureW2 EAP client";

        public string HumanReadableDescription
        {
            get
            {
                return humanReadableDescription;
            }
        }

        public string HumanReadableExecutionDescription
        {
            get
            {
                return humanReadableExecutionDescription;
            }
        }

        public string HumanReadableUndoDescription
        {
            get
            {
                return humanReadableUndoDescription;
            }
        }

        /// <summary>
        /// Silently installs the SecureW2 EAP client
        /// </summary>
        /// <returns>Whether the installation was successful</returns>
        public bool Execute()
        {
            WriteInstallerToDisk();
            Process installSecureW2 = Process.Start(SetupProcess("SecureW2_EAP_Suite_106", "/S"));
            return MonitorProcessOutput(installSecureW2);
        }

        /// <summary>
        /// Checks the std output and err of the provided process and returns true if neither contains anything
        /// </summary>
        /// <param name="process">The process to monitor standard output and error for</param>
        /// <returns>True if there is no standard output or error, false if there is</returns>
        protected bool MonitorProcessOutput(Process process)
        {
            StreamReader stdOutput = process.StandardOutput;
            StreamReader stdErr = process.StandardError;
            process.WaitForExit();

            // TODO: Return what is in standard error or standard output or null if nothing
            return (stdOutput.ReadToEnd() == "" && stdErr.ReadToEnd() == "") ? true : false;
        }
        
        /// <summary>
        /// Creates and prepares the process start info for the installer or uninstaller process
        /// </summary>
        /// <param name="filePath">The path to the application to execute</param>
        /// <param name="arguments">Any arguments for the application to execute</param>
        /// <returns>A configured process start info object</returns>
        protected ProcessStartInfo SetupProcess(string filePath, string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo(filePath, arguments);
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            return psi;
        }

        /// <summary>
        /// Silently uninstalls the SecureW2 EAP client
        /// </summary>
        /// <returns>Whether the uninstallation was successful</returns>
        public bool Undo()
        {
            Process uninstallSecureW2 = Process.Start(SetupProcess("C:/Program Files/SecureW2/Uninstall", "/S"));
            return MonitorProcessOutput(uninstallSecureW2);
        }

        /// <summary>
        /// Writes the SecureW2 Installer executable file to disk
        /// </summary>
        protected void WriteInstallerToDisk()
        {
            using (Stream input = Assembly.GetExecutingAssembly().GetManifestResourceStream("LaurierWirelessClientAutoconf.SecureW2_EAP_Suite_106.exe"))
            using (Stream output = File.Create("SecureW2_EAP_Suite_106.exe"))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
