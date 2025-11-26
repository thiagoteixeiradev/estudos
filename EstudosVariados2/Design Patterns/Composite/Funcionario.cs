using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public Funcionario(string nome) { Nome = nome; }

        public abstract string Operation();

        public virtual void Add(Funcionario component)
        {

        }

        public virtual void Remove(Funcionario component)
        {

        }

        public virtual Funcionario Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
