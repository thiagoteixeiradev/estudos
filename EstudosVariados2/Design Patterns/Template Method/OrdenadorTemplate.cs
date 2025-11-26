using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class OrdenadorTemplate
    {
        public abstract bool IsPrimeiro(Filme filme1, Filme filme2);

        //Boble Sort
        public List<Filme> Ordenar(List<Filme> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (!IsPrimeiro(lista[i], lista[j]))
                    {
                        var temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }
            return lista;
        }
    }
}
