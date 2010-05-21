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
