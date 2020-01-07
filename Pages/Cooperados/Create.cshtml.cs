using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Models;

namespace CoopManagement.Pages.Cooperados
{
    public class CreateModel : PageModel
    {
        private readonly CoopManagementDbContext _context;

        public CreateModel(CoopManagementDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CursoId"] = new SelectList(_context.Curso, "Id", "Id");
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

            _context.Cooperado.Add(Cooperado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
