namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
{
    interface ICommand
    {
        string HumanReadableDescription { get; }
        string HumanReadableExecutionDescription { get; }
        string HumanReadableUndoDescription { get; }

        bool Execute();
        bool Undo();
    }
}
