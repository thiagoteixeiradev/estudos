using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype;

namespace Prototype
{
    public abstract class Inimigo
    {
        public string Nome {  get; set; }
        public int hp { get; set; }
        public int dano { get; set; }
        public string cor {  get; set; }
        public Arma? Arma { get; set; }
    }
}
