using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cursos;
using Microsoft.AspNetCore.Authorization;

namespace CoopManagement.Pages.Cursos
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            //_context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Curso Curso { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Cursos.Add(Curso);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
