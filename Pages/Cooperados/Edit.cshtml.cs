using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Pages.Cooperados
{
    public class EditModel : PageModel
    {
        private readonly CoopManagement.Data.ApplicationDbContext _context;

        public EditModel(CoopManagement.Data.ApplicationDbContext context)
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
           ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Nome");
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

        private bool CooperadoExists(Guid id)
        {
            return _context.Cooperados.Any(e => e.Id == id);
        }
    }
}
