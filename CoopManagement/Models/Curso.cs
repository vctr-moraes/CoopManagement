using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models
{
    public class Curso : Entidade
    {
        public string Nome { get; set; }
        public Grau Grau { get; set; }

        /* EF Relations */
        public IEnumerable<Cooperado> Cooperados { get; set; }
    }
}
