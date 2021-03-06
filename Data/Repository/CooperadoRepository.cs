using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Interfaces;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Data.Repository
{
    public class CooperadoRepository : Repository<Cooperado>, ICooperadoRepository
    {
        public CooperadoRepository(ApplicationDbContext context) : base(context) { }

        public async Task AtualizarCooperado(Cooperado cooperado)
        {
            await Atualizar(cooperado);
        }

        public async Task ExcluirCooperado(Guid id)
        {
            Cooperado cooperado = await ObterCooperado(id);
            await Remover(cooperado.Id);
        }

        public async Task<Cooperado> ObterCooperado(Guid id)
        {
            return await Db.Cooperados.Include(c => c.Curso).FirstOrDefaultAsync(c => c.Id == id);
        }

        public List<Cooperado> ObterCooperadosAtivos()
        {
            return Db.Cooperados.Include(c => c.Curso).Where(c => c.StatusMatricula == StatusMatricula.Ativo).ToList();
        }

        public List<Cooperado> ObterNovosCooperados()
        {
            return Db.Cooperados.Include(c => c.Curso).Where(c => c.StatusMatricula == StatusMatricula.Aguardando).ToList();
        }

        public List<Cooperado> ObterCooperadosInativos()
        {
            return Db.Cooperados.Include(c => c.Curso).Where(c => c.StatusMatricula == StatusMatricula.Inativo).ToList();
        }

        public async Task SalvarCooperado(Cooperado cooperado)
        {
            await Adicionar(cooperado);
        }
    }
}
