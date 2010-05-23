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

using System.Reflection;

namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
{
    class SetupProfileCommand : ICommand
    {
        private const string humanReadableDescription = "Setup Laurier Wireless Windows wireless profile";
        private const string humanReadableExecutionDescription = "Now setting up Laurier Wireless Windows wireless profile";
        private const string humanReadableUndoDescription = "Now deleting Laurier Wireless Windows wireless profile";

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
        /// Adds the appropriate Laurier Wireless profile to the Windows wireless profiles
        /// </summary>
        /// <returns>Whether the profile was added successfully</returns>
        public bool Execute()
        {
            string laurierWirelessXml = getLaurierWirelessXml();
            if (laurierWirelessXml != null)
            {
                NativeWifi.WlanClient client = new NativeWifi.WlanClient();
                foreach (NativeWifi.WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                    wlanIface.SetProfile(0, laurierWirelessXml, true);
                }
                return true;
            }
            // TODO: flag that there was an issue reading the embedded resource
            return false;
        }

        /// <summary>
        /// Return the appropriate Windows Native Wifi XML configuration for Laurier Wireless
        /// </summary>
        /// <returns>The XML configuration for Laurier Wireless for use with the Windows Native Wifi API</returns>
        protected string getLaurierWirelessXml()
        {
            string filename = "";
            if (System.Environment.OSVersion.Version.Major == 5)
            {
                filename = "LaurierWirelessClientAutoconf.laurierwirelessprofile_nt5.xml";
            }
            else
            {
                filename = "LaurierWirelessClientAutoconf.laurierwirelessprofile_nt6.xml";
            }

            try
            {
                using (System.IO.StreamReader sr =
                    new System.IO.StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filename)))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                // TODO: flat that there was an issue reading the embedded resource
                return null;
            }
        }
    }
}
