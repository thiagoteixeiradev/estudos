using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconstruindo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Romario", "Braz");

            (string nome, string sobrenome) = p1;

            Console.WriteLine($"{nome} {sobrenome}");

        }
    }
}
