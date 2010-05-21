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
            NativeWifi.WlanClient client = new NativeWifi.WlanClient();
            foreach (NativeWifi.WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                wlanIface.SetProfile(0, getLaurierWirelessXml(), true);
            }
            return true;
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
                filename = "laurierwirelessprofile_nt5.xml";
            }
            else
            {
                filename = "laurierwirelessprofile_nt6.xml";
            }
            System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            return sr.ReadToEnd();
        }

        /// <summary>
        /// Removes the Laurier Wireless profile from the Windows wireless profiles
        /// </summary>
        /// <returns>Whether the profile was removed successfully</returns>
        public bool Undo()
        {
            NativeWifi.WlanClient client = new NativeWifi.WlanClient();
            foreach (NativeWifi.WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                wlanIface.DeleteProfile("laurierwireless");
            }
            return true;
        }
    }
}
