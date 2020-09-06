using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models.Cursos
{
    public enum Grau
    {
        [Display (Name = "Técnico")]
        Técnico = 1,
        Superior = 2
    }
}
