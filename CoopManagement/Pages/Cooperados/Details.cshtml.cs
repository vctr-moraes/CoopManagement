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
    public class DetailsModel : PageModel
    {
        private readonly CoopManagement.Data.ApplicationDbContext _context;

        public DetailsModel(CoopManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
