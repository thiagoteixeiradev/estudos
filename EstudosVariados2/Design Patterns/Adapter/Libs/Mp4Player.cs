using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lib
{
    internal class Mp4Player
    {
        public static void Executar(string file)
        {
            Console.WriteLine($"Executando arquivo Mp4: {file}");
        }
    }
}
