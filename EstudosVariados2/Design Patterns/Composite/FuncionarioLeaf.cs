using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class FuncionarioLeaf : Funcionario
    {
         public FuncionarioLeaf(string nome): base(nome) { }

        public override string Operation()
        {
            return "Leaf";
        }
    }
}
