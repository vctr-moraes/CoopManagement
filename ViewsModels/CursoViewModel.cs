using CoopManagement.Models.Cursos;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public class CursoViewModel
    {
        public CursoViewModel() { }

        public CursoViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            //Grau = EnumHelper<Grau>.GetDisplayValue(curso.Grau);
            Grau = Convert.ToString(curso.Grau);
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Grau")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Grau { get; set; }
    }
}
