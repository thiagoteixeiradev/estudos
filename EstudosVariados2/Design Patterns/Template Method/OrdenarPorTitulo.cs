using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class OrdenarPorTitulo : OrdenadorTemplate
    {
        public override bool IsPrimeiro(Filme filme1, Filme filme2)
        {
            if(filme1.Titulo.CompareTo(filme2.Titulo) < 0)
            {
                return true;
            }
            return false;
        }
    }
}
