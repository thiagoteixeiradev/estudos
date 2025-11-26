using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lib
{
    internal class Mp3Player
    {
        private string File = "";

        public Mp3Player() { }

        public Mp3Player(string file) => File = File;

        public void Run() { Console.WriteLine($"Executando arquivo Mp3: {File}"); }
    }
}
