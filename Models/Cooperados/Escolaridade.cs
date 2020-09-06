using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models.Cooperados
{
    public enum Escolaridade
    {
        [Display(Name = "Primeiro grau")]
        PrimeiroGrau = 1,
        [Display(Name = "Segundo grau")]
        SegundoGrau = 2,
        [Display(Name = "Terceiro grau")]
        TerceiroGrau = 3
    }
}
