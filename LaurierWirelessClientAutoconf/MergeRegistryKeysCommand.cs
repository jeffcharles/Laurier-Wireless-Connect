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

using Microsoft.Win32;
using System;

namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
{
    class MergeRegistryKeysCommand : ICommand
    {
        private const string humanReadableDescription = "Register SecureW2 EAP client settings";
        private const string humanReadableExecutionDescription = "Now registering SecureW2 EAP client settings";
        private const string humanReadableUndoDescription = "Now deleting SecureW2 EAP client registry keys";

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
        /// Deletes the SecureW2 sub key tree of the specified registry branch
        /// </summary>
        /// <param name="branch">The registry branch from which to delete the SecureW2 entries</param>
        /// <returns>Whether the delete was successful or not</returns>
        protected bool DeleteSecureW2SubKeyTree(RegistryKey branch)
        {
            using (RegistryKey key = branch.OpenSubKey("Software", true))
            {
                if (key != null)
                {
                    try
                    {
                        key.DeleteSubKeyTree("SecureW2");
                    }
                    catch (ArgumentException)
                    {
                        // means subkey not in tree, good thing?
                        return true;
                    }
                    catch (System.IO.IOException)
                    {
                        // registry locked for some reason?
                        // TODO: Maybe have code retry a set number of times
                        return false;
                    }
                    catch (System.Security.SecurityException)
                    {
                        // user does not have permissions required to delete key
                        // TODO: Alert user that they need admin permissions
                        return false;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // user does not have necessary registry rights
                        // TODO: Alert user that they need admin permissions
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Merge SecureW2 default profile settings and blank user credentials for profile into the registry
        /// </summary>
        /// <returns>Whether merge was successful</returns>
        public bool Execute()
        {
            System.Diagnostics.Process.Start(@"REG IMPORT SecureW2_ProfileSetup.reg");
            return true;
        }

        /// <summary>
        /// Delete the registry keys for the SecureW2 default profile and user credentials for profile
        /// </summary>
        /// <returns>Whether delete was successful or not</returns>
        public bool Undo()
        {
            return DeleteSecureW2SubKeyTree(Registry.CurrentUser) && 
                DeleteSecureW2SubKeyTree(Registry.LocalMachine);
        }
    }
}
