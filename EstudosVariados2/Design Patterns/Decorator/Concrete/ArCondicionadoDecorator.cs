using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator;
using Decorator.Decorador;

namespace Decorator.Concrete
{
    public class ArCondicionadoDecorator : CarroDecorator
    {
        public ArCondicionadoDecorator(ICarro carro): base(carro) { }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + "Com Ar Condicionado";
        }
    }
}
