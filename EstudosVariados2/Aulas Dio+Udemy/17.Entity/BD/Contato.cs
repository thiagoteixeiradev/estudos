using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BD
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }
        public string Nome_Contato { get; set; }
        public string Telefone_Contato { get; set; }
        public bool Ativo { get; set; }
    }
}
