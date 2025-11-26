using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Object
{
    internal class Calculadora : ICalculadora
    //Implementei minha interface
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
        /*public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }*/

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        //Usei todos os seus métodos.
    }
}
