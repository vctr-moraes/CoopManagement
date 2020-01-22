using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models;

namespace CoopManagement.ViewsModels.Cursos
{
    public class CursoDetailsViewModel
    {
        public CursoDetailsViewModel(Curso curso)
        {
            Id = curso.Id;
            Nome = curso.Nome;
            Grau = curso.Grau;
        }

        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Grau")]
        public string Grau { get; set; }
    }
}
