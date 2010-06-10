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
using System.Globalization;
using System.IO;
using System.Reflection;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    static class HelperMethods
    {
        /// <summary>
        /// Checks the exit code of the process after the process exits and raises an exception if it is non-zero
        /// </summary>
        /// <param name="process">The process to monitor standard output and error for</param>
        /// <param name="errorMsgIfFailure">A general error message to display if the process fails</param>
        public static void MonitorProcessOutput(Process process, string errorMsgIfFailure)
        {
            if (process == null)
            {
                throw new ArgumentNullException("process", "process cannot be a null reference");
            }
            if (errorMsgIfFailure == null)
            {
                throw new ArgumentNullException("errorMsgIfFailure", "errorMsgIfFailure cannot be a null reference");
            }

            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                throw new ProcessException(errorMsgIfFailure, process.ExitCode);
            }
        }

        /// <summary>
        /// Creates and prepares the process start info for a process executing within this executable
        /// </summary>
        /// <param name="filePath">The path to the application to execute</param>
        /// <param name="arguments">Any arguments for the application to execute</param>
        /// <returns>A configured process start info object</returns>
        public static ProcessStartInfo SetupProcess(string filePath, string arguments)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath", "filePath cannot be a null reference");
            }
            if (arguments == null)
            {
                throw new ArgumentNullException("arguments", "arguments cannot be a null reference");
            }
            
            ProcessStartInfo psi = new ProcessStartInfo(filePath, arguments);
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            return psi;
        }

        /// <summary>
        /// Writes an embedded file to disk in the present working directory
        /// </summary>
        /// <param name="filename">The name of the embedded file to write to disk</param>
        public static void WriteEmbeddedFileToDisk(string filename)
        {
            if (filename == null)
            {
                throw new ArgumentNullException("filename", "filename cannot be a null reference");
            }

            using (Stream input = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format(CultureInfo.InvariantCulture, "OpenSourceAtLaurier.LaurierWirelessConnect.EmbeddedResources.{0}", filename)))
            using (Stream output = File.Create(filename))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }

            if (!File.Exists(filename))
            {
                throw new IOException(String.Format(CultureInfo.CurrentCulture, "Error writing {0} to disk.", filename));
            }
        }
    }
}
