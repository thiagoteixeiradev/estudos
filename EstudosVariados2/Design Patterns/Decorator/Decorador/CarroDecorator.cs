using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorador
{
    public class CarroDecorator : ICarro
    {
        private readonly ICarro Carro;
        public CarroDecorator(ICarro carro) { Carro = carro; }

        public virtual string RetornarCarro()
        {
            return Carro.RetornarCarro();
        }
    }
}
