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
using System.Reflection;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    class SetupProfileCommand : ICommand
    {
        private const string humanReadableExecutionDescription = "Now setting up Laurier Wireless Windows wireless profile";

        public string HumanReadableExecutionDescription
        {
            get
            {
                return humanReadableExecutionDescription;
            }
        }

        /// <summary>
        /// Adds the appropriate Laurier Wireless profile to the Windows wireless profiles
        /// </summary>
        public void Execute()
        {
            string laurierWirelessXml = GetLaurierWirelessXml();
            if (laurierWirelessXml != null)
            {
                NativeWifi.WlanClient client = new NativeWifi.WlanClient();
                if (client.Interfaces.Length == 0)
                {
                    throw new ApplicationException("No wireless interfaces detected");
                }
                foreach (NativeWifi.WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                    wlanIface.SetProfile(0, laurierWirelessXml, true);
                }
            }
        }

        /// <summary>
        /// Return the appropriate Windows Native Wifi XML configuration for Laurier Wireless
        /// </summary>
        /// <returns>The XML configuration for Laurier Wireless for use with the Windows Native Wifi API</returns>
        protected string GetLaurierWirelessXml()
        {
            string filename = "";
            if (System.Environment.OSVersion.Version.Major == 5)
            {
                filename = "OpenSourceAtLaurier.LaurierWirelessConnect.laurierwirelessprofile_nt5.xml";
            }
            else
            {
                filename = "OpenSourceAtLaurier.LaurierWirelessConnect.laurierwirelessprofile_nt6.xml";
            }

            
            using (System.IO.StreamReader sr =
                new System.IO.StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filename)))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
