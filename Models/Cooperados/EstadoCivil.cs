using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models.Cooperados
{
    public enum EstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        [Display(Name = "Viúvo")]
        Viuvo = 3,
        Divorciado = 4,
        Separado = 5
    }
}
