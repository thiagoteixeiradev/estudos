using Adapter.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class Mp4PlayerAdapter : IPlayer
    {
        public void Play(string File)
        {
            Mp4Player.Executar(File);
        }
    }
}
