using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Pages.Cooperados
{
    public class DeleteModel : PageModel
    {
        private readonly CoopManagement.Data.ApplicationDbContext _context;

        public DeleteModel(CoopManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cooperado Cooperado { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado = await _context.Cooperados
                .Include(c => c.Curso).FirstOrDefaultAsync(m => m.Id == id);

            if (Cooperado == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado = await _context.Cooperados.FindAsync(id);

            if (Cooperado != null)
            {
                _context.Cooperados.Remove(Cooperado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
