using System;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models.Cursos;

namespace CoopManagement.ViewsModels
{
    public class CursoDetailsViewModel
    {
        public CursoDetailsViewModel() { }

        public CursoDetailsViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            Grau = (GrauViewModel)curso.Grau;
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Grau")]
        public GrauViewModel Grau { get; set; }
    }
}
