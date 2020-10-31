using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Interfaces;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Data.Repository
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursoRepository(ApplicationDbContext context) : base(context) { }

        public async Task AtualizarCurso(Curso curso)
        {
            await AtualizarCurso(curso);
        }

        public async Task ExcluirCurso(Guid id)
        {
            Curso curso = await ObterCurso(id);
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
