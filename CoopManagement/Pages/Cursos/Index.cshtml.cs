using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Data;
using CoopManagement.Models;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Curso> Curso { get;set; }

        public async Task OnGetAsync()
        {
            Curso = await _context.Cursos.ToListAsync();
        }
    }
}
