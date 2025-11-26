using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SerasaAPI
    {
        public int Score(string CPF)
        {
            Random random = new Random();
            return random.Next(0,1000);
        }
    }
}
