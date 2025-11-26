using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class TuplaArquivo
    {
        public (bool Sucesso, string[] LinhasArquivo, int QuantidadeLinhas) LerArquivo(string caminho)
            //Ainda nesse meu método, eu declarei uma tupla no seu escopo
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
                //Como o retorno do meu método é uma tupla, dei esse return devido
            }
        }
    }
}
