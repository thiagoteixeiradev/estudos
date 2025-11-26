using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class Tela
    {
        protected string BackgroundColor { get;}
        private readonly string MessageText;

        public Tela(string messageText, string backgroundColor)
        {
            MessageText = messageText;
            BackgroundColor = backgroundColor;
        }

        public string GetMessageText()
        {
            return MessageText;
        }
    }
}
