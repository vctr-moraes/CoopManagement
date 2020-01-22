using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.Models
{
    public enum EstadosCivis
    {
        [Display(Name = "Solteiro")]
        solteiro,
        [Display(Name = "Casado")]
        casado,
        [Display(Name = "Viúvo")]
        viuvo,
        [Display(Name = "Divorciado")]
        divorciado,
        [Display(Name = "Separado")]
        separado
    }
}
