using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly ICursoRepository _cursoRepository;

        public IndexModel(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        [BindProperty]
        public List<CursoViewModel> Cursos { get; set; }

        public ActionResult OnGet()
        {
            Cursos = _cursoRepository.ObterTodosCursos().Select(curso => new CursoViewModel(curso)).ToList();
            return Page();
        }
    }
}
