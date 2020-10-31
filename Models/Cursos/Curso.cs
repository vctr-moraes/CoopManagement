using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Models.Cursos
{
    public class Curso : Entidade
    {
        public string Nome { get; set; }

        public Grau Grau { get; set; }

        /* EF Relations */
        public IEnumerable<Cooperado> Cooperados { get; set; }
    }
}
