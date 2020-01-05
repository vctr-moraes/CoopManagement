using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels.Cursos
{
    public class CursoCreateEditViewModel
    {
        public CursoCreateEditViewModel()
        {
        }

        public CursoCreateEditViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            Grau = curso.Grau;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Grau é obrigatório")]
        [Display(Name = "Grau")]
        public string Grau { get; set; }
    }
}
