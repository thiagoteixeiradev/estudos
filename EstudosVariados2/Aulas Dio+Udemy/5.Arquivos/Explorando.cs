using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoArquivos
{
    public class Explorando
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            try { Metodo3(); }
            catch(Exception) {
                Console.WriteLine("Exceção tratada no metodo 2");
            }
            

        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção, você chegou aqui pelo throw");
            //O throw irá jogar para o caminho reverso até encontrar o tratamento da excesão.
        }
    }
}
