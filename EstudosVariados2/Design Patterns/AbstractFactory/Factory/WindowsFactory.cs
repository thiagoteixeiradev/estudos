using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    internal class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
