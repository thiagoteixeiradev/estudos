using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class TelaSmartTv : Tela
    {
        public TelaSmartTv() : base("Olá SmartTV", "Red")
        {
        }
    }
}
