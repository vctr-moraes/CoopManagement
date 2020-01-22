using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopManagement.Models
{
    public enum RacasCores
    {
        [Display(Name = "Branca")]
        branca,
        [Display(Name = "Negra")]
        negra,
        [Display(Name = "Parda")]
        parda,
        [Display(Name = "Amarela")]
        amarela,
        [Display(Name = "Indígena")]
        indigena
    }
}
