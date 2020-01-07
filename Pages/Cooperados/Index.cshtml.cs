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
    public class IndexModel : PageModel
    {
        private readonly CoopManagementDbContext _context;

        public IndexModel(CoopManagementDbContext context)
        {
            _context = context;
        }

        public IList<Cooperado> Cooperado { get;set; }

        public async Task OnGetAsync()
        {
            Cooperado = await _context.Cooperado
                .Include(c => c.Curso).ToListAsync();
        }
    }
}
