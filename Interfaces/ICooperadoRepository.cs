using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Interfaces
{
    public interface ICooperadoRepository
    {
        Task SalvarCooperado(Cooperado cooperado);
        Task AtualizarCooperado(Cooperado cooperado);
        Task<Cooperado> ObterCooperado(Guid id);
        Task ExcluirCooperado(Guid id);
        List<Cooperado> ObterTodosCooperados();
    }
}
