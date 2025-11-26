using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class JanelaLinux : IJanelaBridge
    {
        public void desenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " Botão Linux");
        }

        public void desenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " Janela Linux");
        }
    }
}
