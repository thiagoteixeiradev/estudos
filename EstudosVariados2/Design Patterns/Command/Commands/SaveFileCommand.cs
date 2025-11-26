using Command.Interface;

namespace Command.Commands
{
    internal class SaveFileCommand : Icommand
    {
        private Receiver _receiver;

        public SaveFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.SaveFile();
        }
    }
}
