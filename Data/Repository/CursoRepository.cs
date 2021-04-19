using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Interfaces;
using CoopManagement.Models.Cursos;
using CoopManagement.Models.Cooperados;
using AcquaJrApplication.Models;

namespace CoopManagement.Data.Repository
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        private readonly ICooperadoRepository _cooperadoRepository;

        public CursoRepository(ApplicationDbContext context, ICooperadoRepository cooperadoRepository) : base(context)
        {
            _cooperadoRepository = cooperadoRepository;
        }

        public async Task AtualizarCurso(Curso curso)
        {
            await Atualizar(curso);
        }

        public async Task ExcluirCurso(Guid id)
        {
            Curso curso = await ObterCurso(id);
            List<Cooperado> cooperados = _cooperadoRepository.ObterCooperados().Where(cooperados => cooperados.CursoId == curso.Id).ToList();

            DomainException.When(cooperados.Count() > 0, "Este curso não pode ser excluído, pois está vinculado a algum cadastro de cooperado.");
            
            await Remover(curso.Id);
        }

        public async Task<Curso> ObterCurso(Guid id)
        {
            return await Db.Cursos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public List<Curso> ObterTodosCursos()
        {
            return Db.Cursos.ToList();
        }

        public async Task SalvarCurso(Curso curso)
        {
            await Adicionar(curso);
        }
    }
}
