using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models.Cooperados
{
    public enum RacaCor
    {
        Branca = 1,
        Negra = 2,
        Parda = 3,
        Amarela = 4,
        [Display(Name = "Indígena")]
        Indigena = 5
    }
}
