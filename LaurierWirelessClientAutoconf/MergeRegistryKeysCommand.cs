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
            System.Diagnostics.Process.Start(@"REG DELETE ..."); // TODO: add key names
            System.Diagnostics.Process.Start(@"REG DELETE ...");
            return true;
        }
    }
}
