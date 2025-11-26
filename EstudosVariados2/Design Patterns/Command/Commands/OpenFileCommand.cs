using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class OpenFileCommand : Icommand
    {
        private Receiver _receiver;

        public OpenFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.OpenFile();
        }
    }
}
