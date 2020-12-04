using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Models.Cursos;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cursos
{
    public class EditModel : PageModel
    {
        private readonly ICursoRepository _cursoRepository;

        public EditModel(ICursoRepository cursoRepository)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Curso curso = await _cursoRepository.ObterCurso(CursoVM.Id);

            if (curso == null)
            {
                return NotFound();
            }

            curso.Nome = CursoVM.Nome;
            curso.Grau = (Grau)CursoVM.Grau;

            try
            {
                await _cursoRepository.AtualizarCurso(curso);
                return await Task.FromResult(RedirectToPage("./Index"));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
