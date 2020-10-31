using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Interfaces
{
    public interface ICursoRepository
    {
        Task SalvarCurso(Curso curso);
        Task AtualizarCurso(Curso curso);
        Task<Curso> ObterCurso(Guid id);
        Task ExcluirCurso(Guid id);
        List<Curso> ObterTodosCursos();
    }
}
