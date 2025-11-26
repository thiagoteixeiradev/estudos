using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Lib;

namespace Adapter.Adapter
{
    internal class Mp3PlayerAdapter :  IPlayer
    {
        public void Play(string file)
        {
            Mp3Player mp3 = new(file);
            mp3.Run();
        }
    }
}
