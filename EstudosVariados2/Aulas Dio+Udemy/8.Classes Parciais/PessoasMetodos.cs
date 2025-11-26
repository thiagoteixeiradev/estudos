using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulos
{

    partial class Pessoas //O partial indica ser parte de uma outra classe
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou: " + nome); //chamei minha variavel do outro arquivo, sem dificuldades
        }

    }
}
