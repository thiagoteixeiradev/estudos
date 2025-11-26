using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorFilmes.Models;

namespace RazorFilmes.Data
{
    public class RazorFilmesContext : DbContext
    {
        public RazorFilmesContext (DbContextOptions<RazorFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filmes { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>()
                .Property(f => f.Lancamento)
                .HasColumnType("timestamp without time zone");
        }
    }
}
