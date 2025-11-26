using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCasting
{
    internal class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando o circulo");
        }

        public void PintarCirculo() 
        {
            Console.WriteLine("Pintando o circulo");
        }

    }
}
