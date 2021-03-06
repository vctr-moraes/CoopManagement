using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopManagement.Interfaces;
using CoopManagement.ViewsModels;

namespace CoopManagement.Pages.Cooperados
{
    public class NovosCooperadosModel : PageModel
    {
        private readonly ICooperadoRepository _cooperadoRepository;

        public NovosCooperadosModel(ICooperadoRepository cooperadoRepository)
        {
            _cooperadoRepository = cooperadoRepository;
        }
        
        [BindProperty]
        public IList<CooperadoViewModel> Cooperados { get; set; }

        public ActionResult OnGet()
        {
            Cooperados = _cooperadoRepository.ObterNovosCooperados().Select(cooperado => new CooperadoViewModel(cooperado)).ToList();
            return Page();
        }
    }
}
