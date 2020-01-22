using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.Models
{
    public enum NecessidadesEspeciais
    {
        [Display(Name = "Nenhuma")]
        nenhuma,
        [Display(Name = "Física")]
        fisica,
        [Display(Name = "Mental")]
        mental,
        [Display(Name = "Visual")]
        visual,
        [Display(Name = "Auditiva")]
        auditiva
    }
}
