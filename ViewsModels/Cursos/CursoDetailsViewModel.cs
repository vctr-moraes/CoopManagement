using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels.Cursos
{
    public class CursoDetailsViewModel
    {
        public CursoDetailsViewModel()
        {
        }

        public CursoDetailsViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            Grau = curso.Grau;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo Nome pode ter no máximo 40 caracteres.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Grau é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Grupo pode ter no máximo 50 caracteres.")]
        [Display(Name = "Grau")]
        public string Grau { get; set; }
    }
}
