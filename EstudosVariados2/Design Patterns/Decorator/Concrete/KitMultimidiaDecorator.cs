using Decorator.Decorador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    internal class KitMultimidiaDecorator : CarroDecorator
    {
        public KitMultimidiaDecorator(ICarro carro): base(carro) { }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + "Com Kit Multimidia";

        }
    }
}
