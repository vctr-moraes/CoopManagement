using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Models;

namespace CoopManagement.Pages.Cooperados
{
    public class EditModel : PageModel
    {
        private readonly CoopManagementDbContext _context;

        public EditModel(CoopManagementDbContext context)
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
           ViewData["CursoId"] = new SelectList(_context.Curso, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cooperado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CooperadoExists(Cooperado.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CooperadoExists(int id)
        {
            return _context.Cooperado.Any(e => e.Id == id);
        }
    }
}
