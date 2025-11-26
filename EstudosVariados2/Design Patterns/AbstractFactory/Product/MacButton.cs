using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class MacButton : IButton
    {
        public void  Paint()
        {
            Console.WriteLine("Desenhando um butão no Mac OS.");
        }
    }
}
