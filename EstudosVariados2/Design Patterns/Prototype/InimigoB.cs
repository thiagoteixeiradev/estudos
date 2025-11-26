using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class InimigoA :  Inimigo,IInimigoPrototype
    {
        public Inimigo Clone()
        {
            return (Inimigo)this.MemberwiseClone();
        }
    }
}
