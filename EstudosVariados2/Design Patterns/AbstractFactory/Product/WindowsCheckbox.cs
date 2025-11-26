using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint() 
        {
            
        Console.WriteLine("Criando um checkbox no Windows");

        }
    }
}
