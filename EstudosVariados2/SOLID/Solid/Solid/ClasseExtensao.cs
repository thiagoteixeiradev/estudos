using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensao
{
    public static class ClasseExtensao
    {
        public static string CaixaAltaPrimeiraLetra(this string valor)
        {
            if (valor.Length > 0)
            {
                char[] array = valor.ToCharArray(); //converto minha string para um array
                array[0] = char.ToUpper(array[0]); //a primeira letra do array, aplico o ToUpper
                return new string(array); //retorno uma nova string, contendo meu array
            }

            return valor;
        }
    }
}
