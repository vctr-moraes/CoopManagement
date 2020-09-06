using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models.Cooperados
{
    public enum NecessidadeEspecial
    {
        Nenhuma = 1,
        [Display(Name = "Física")]
        Fisica = 2,
        Mental = 3,
        Visual = 4,
        Auditiva = 5
    }
}
