using Command.Interface;

namespace Command.Commands
{
    internal class CloseFileCommand : Icommand
    {
        private Receiver _receiver;

        public CloseFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.CloseFile();
        }
    }
}
