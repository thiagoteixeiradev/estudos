using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    internal class PessoaEstatica
    {
        public static int maiorIdadees = 18;
        public string nomees;
        public int idadees;
        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou" + nomees);

        }
        public static int CalcularIdade(int anoNascimentoEs)
        {
            return DateTime.Now.Year - anoNascimentoEs;
        }

    }
}
