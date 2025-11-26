using Microsoft.EntityFrameworkCore;
using RazorFilmes.Data;

namespace RazorFilmes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var contexto = new RazorFilmesContext(serviceProvider.GetRequiredService
                <DbContextOptions<RazorFilmesContext>>()))
            {
                if (contexto == null || contexto.Filmes == null)
                {
                    throw new ArgumentNullException("Null RazorPagesFilmesContext");
                }
                if (contexto.Filmes.Any())
                {
                    return;
                }

                contexto.Filmes.AddRange(
                    new Filme
                    {
                        Titulo = "A volta dos que não foram",
                        Lancamento = DateTime.Parse("06/05/1994"),
                        Genero = "Aventura",
                        Preco = 10.00m,
                        Classificacao = "M15"
                    },
                     new Filme
                     {
                      Titulo = "Poeira em alto Mar",
                      Lancamento = DateTime.Parse("03/12/2000"),
                      Genero = "Aventura",
                      Preco = 10.00m,
                      Classificacao = "L"
                     },
                     new Filme
                     {
                      Titulo = "Demon Slayer: Arco do castelo infinito",
                      Lancamento = DateTime.Parse("08/11/2025"),
                      Genero = "Anime",
                      Preco = 10.00m,
                      Classificacao = "M18"
                     }
                    );
                contexto.SaveChanges();
            
            }
        }
    }
}
