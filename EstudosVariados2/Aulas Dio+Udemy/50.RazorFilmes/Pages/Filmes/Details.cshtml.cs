using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorFilmes.Data;
using RazorFilmes.Models;

namespace RazorFilmes.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorFilmes.Data.RazorFilmesContext _context;

        public DetailsModel(RazorFilmes.Data.RazorFilmesContext context)
        {
            _context = context;
        }

        public Filme Filme { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filme = await _context.Filmes.FirstOrDefaultAsync(m => m.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else
            {
                Filme = filme;
            }
            return Page();
        }
    }
}
