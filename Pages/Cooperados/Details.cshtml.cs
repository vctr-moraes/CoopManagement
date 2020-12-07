using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopManagement.Models.Cooperados;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cooperados
{
    public class DetailsModel : PageModel
    {
        private readonly ICooperadoRepository _cooperadoRepository;

        public DetailsModel(ICooperadoRepository cooperadoRepository)
        {
            _cooperadoRepository = cooperadoRepository;
        }

        [BindProperty]
        public CooperadoViewModel CooperadoVM { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cooperado cooperado = await _cooperadoRepository.ObterCooperado(id);

            if (cooperado == null)
            {
                return NotFound();
            }

            CooperadoVM = new CooperadoViewModel(cooperado);
            return Page();
        }
    }
}
