using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
        //defini minha interface
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);


        //pela interface não preciso colocar public, pois isto já é subentendido.
        //também não preciso implementar nada aqui, por isso não há {}
        //Todos os métodos declarados devem ser implementados

        int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
