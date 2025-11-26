using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ReceitaFederal
    {
        public bool CPFAtivo(string CPF)
        {
            Random random = new Random();
            int n = random.Next(0, 1);
            return n != 0;
        }
    }
}
