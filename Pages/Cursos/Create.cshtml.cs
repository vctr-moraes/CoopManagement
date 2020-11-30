using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopManagement.Models.Cursos;
using CoopManagement.ViewsModels;
using CoopManagement.Interfaces;

namespace CoopManagement.Pages.Cursos
{
    public class CreateModel : PageModel
    {
        private readonly ICursoRepository _cursoRepository;

        public CreateModel(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
            CursoVM = new CursoViewModel();
        }

        [BindProperty]
        public CursoViewModel CursoVM { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                Curso curso = new Curso
                {
                    Nome = CursoVM.Nome,
                    Grau = (Grau)Enum.Parse(typeof(Grau), CursoVM.Grau.ToString())
                };

                await _cursoRepository.SalvarCurso(curso);
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
