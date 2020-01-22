using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.Models
{
    public enum Sexos
    {
        [Display(Name = "Masculino")]
        solteiro,
        [Display(Name = "Feminino")]
        casado,
    }
}
