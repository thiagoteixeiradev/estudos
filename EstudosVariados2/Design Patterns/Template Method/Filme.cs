using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public double Avaliacao { get; set; }

        public Filme(int id, string titulo, int ano, double avaliacao)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Avaliacao = avaliacao;
        }
    }
}
