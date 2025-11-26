using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
