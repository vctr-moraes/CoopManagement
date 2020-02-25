using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Models.Cursos
{
    public class Curso : Entidade
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Grau")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Grau Grau { get; set; }

        /* EF Relations */
        public IEnumerable<Cooperado> Cooperados { get; set; }
    }
}
