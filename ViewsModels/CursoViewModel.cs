using System;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models.Cursos;

namespace CoopManagement.ViewsModels
{
    public class CursoViewModel
    {
        public CursoViewModel() { }

        public CursoViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            Grau = (GrauViewModel)curso.Grau;
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Grau")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public GrauViewModel Grau { get; set; }
    }
}
