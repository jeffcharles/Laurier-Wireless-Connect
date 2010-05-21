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
        /// Silently nstalls the SecureW2 EAP client
        /// </summary>
        /// <returns>Whether the installation was successful</returns>
        public bool Execute()
        {
            System.Diagnostics.Process.Start(@"SecureW2_Install /S");
            // TODO: check std output and err for output
            return true;
        }

        /// <summary>
        /// Silently uninstalls the SecureW2 EAP client
        /// </summary>
        /// <returns>Whether the uninstallation was successful</returns>
        public bool Undo()
        {
            System.Diagnostics.Process.Start(@"C:/Program Files/SecureW2/uninstall /S"); // TODO: Check that this actually works
            // TODO: check std output and err for output
            return true;
        }
    }
}
