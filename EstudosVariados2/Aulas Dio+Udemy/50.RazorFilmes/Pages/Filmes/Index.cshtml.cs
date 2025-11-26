using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorFilmes.Data;
using RazorFilmes.Models;

namespace RazorFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorFilmesContext _context;

        public IndexModel(RazorFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; } = default!;

        // Vincula o título vindo via GET
        [BindProperty(SupportsGet = true)]
        public string? BuscaTitulo { get; set; }

        // Lista de gêneros para preencher o dropdown (não precisa de BindProperty)
        public SelectList? BuscaListaGenero { get; set; }

        // Vincula o gênero selecionado vindo via GET
        [BindProperty(SupportsGet = true)]
        public string? BuscaGenero2 { get; set; }

        public async Task OnGetAsync()
        {
            // Consulta para popular a lista de gêneros
            IQueryable<string> generoQuery = _context.Filmes
                                                     .OrderBy(m => m.Genero)
                                                     .Select(m => m.Genero);

            // Base da query de filmes
            var filmes = _context.Filmes.AsQueryable();

            // Filtro por título
            if (!string.IsNullOrEmpty(BuscaTitulo))
            {
                filmes = filmes.Where(s => s.Titulo!.Contains(BuscaTitulo));
            }

            // Filtro por gênero
            if (!string.IsNullOrEmpty(BuscaGenero2))
            {
                filmes = filmes.Where(g => g.Genero == BuscaGenero2);
            }

            // Popular o dropdown e a lista final de filmes
            BuscaListaGenero = new SelectList(await generoQuery.Distinct().ToListAsync());
            Filme = await filmes.ToListAsync();
        }
    }
}
