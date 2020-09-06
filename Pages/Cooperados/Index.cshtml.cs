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
    public class IndexModel : PageModel
    {
        private readonly CoopManagement.Data.ApplicationDbContext _context;

        public IndexModel(CoopManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cooperado> Cooperado { get;set; }

        public async Task OnGetAsync()
        {
            Cooperado = await _context.Cooperados
                .Include(c => c.Curso).ToListAsync();
        }
    }
}
