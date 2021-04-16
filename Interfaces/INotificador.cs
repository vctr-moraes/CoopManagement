using System.Collections.Generic;
using CoopManagement.Notificacoes;

namespace CoopManagement.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
