using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopManagement.Models.Cursos;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cursos
{
    public class DetailsModel : PageModel
    {
        private readonly ICursoRepository _cursoRepository;

        public DetailsModel(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        [BindProperty]
        public CursoViewModel CursoVM { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curso curso = await _cursoRepository.ObterCurso(id);

            if (curso == null)
            {
                return NotFound();
            }

            CursoVM = new CursoViewModel(curso);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Curso curso = await _cursoRepository.ObterCurso(id);

            if (curso == null)
            {
                return NotFound();
            }

            try
            {
                await _cursoRepository.ExcluirCurso(curso.Id);
                TempData["Sucesso"] = "Curso excluído com sucesso!";
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
