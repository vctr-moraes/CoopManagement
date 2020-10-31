using System.Collections.Generic;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.Models.Cursos
{
    public class Curso : Entity
    {
        public string Nome { get; set; }

        public Grau Grau { get; set; }

        /* EF Relations */
        public IEnumerable<Cooperado> Cooperados { get; set; }
    }
}
