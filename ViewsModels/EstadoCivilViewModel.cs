using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum EstadoCivilViewModel
    {
        [Display(Name = "Solteiro")]
        Solteiro = 1,

        [Display(Name = "Casado")]
        Casado = 2,

        [Display(Name = "Viúvo")]
        Viuvo = 3,

        [Display(Name = "Divorciado")]
        Divorciado = 4,

        [Display(Name = "Separado")]
        Separado = 5
    }
}
