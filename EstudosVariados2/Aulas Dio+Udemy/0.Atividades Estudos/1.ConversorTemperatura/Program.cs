using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("Digite um valor para uma temperatura em graus Celsius: ");
            c = double.Parse(Console.ReadLine());

            // Formula da conversão para fahrenheit 
            f = (c * 9 / 5) + 32;
            // Formula da conversão para Kelvin
            k = c + 273.15;

            Console.WriteLine(" A temperatura convertida para fahrenheit é: " + f + " E em Kelvin são: " + k + " graus");
        }
    }
}
