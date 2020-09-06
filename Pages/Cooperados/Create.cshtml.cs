using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Pages.Cooperados
{
    public class CreateModel : PageModel
    {
        private readonly CoopManagement.Data.ApplicationDbContext _context;

        public CreateModel(CoopManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Nome");
            return Page();
        }

        [BindProperty]
        public Cooperado Cooperado { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cooperados.Add(Cooperado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
