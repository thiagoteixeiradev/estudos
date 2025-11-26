using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public abstract class TelaCreator
    {
        public abstract Tela CriaTela();
    }
}
