using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    internal class ConcreteTelaSmartTVCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartTv();
        }
    }
}
