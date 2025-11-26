using Entity.BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Contexto
{
    public class AgendaContexto : DbContext
    {
        //Aqui é o canal onde receberá nossa string, ou nossos dados de conexão com o DB
        public AgendaContexto(DbContextOptions<AgendaContexto> options) : base(options)
        {

        }
        
        //Dados que irão para o DB
        public DbSet<Contato> Contatos { get; set; }
    }
}
