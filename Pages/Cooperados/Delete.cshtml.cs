using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Models;

namespace CoopManagement.Pages.Cooperados
{
    public class DeleteModel : PageModel
    {
        private readonly CoopManagementDbContext _context;

        public DeleteModel(CoopManagementDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cooperado Cooperado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado = await _context.Cooperado
                .Include(c => c.Curso).FirstOrDefaultAsync(m => m.Id == id);

            if (Cooperado == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado = await _context.Cooperado.FindAsync(id);

            if (Cooperado != null)
            {
                _context.Cooperado.Remove(Cooperado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
