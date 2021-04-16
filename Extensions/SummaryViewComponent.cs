using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoopManagement.Interfaces;

namespace CoopManagement.Extensions
{
    [ViewComponent(Name = "Summary")]
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());
            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }
    }
}
