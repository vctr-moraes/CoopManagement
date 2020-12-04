using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum RacaCorViewModel
    {
        [Display(Name = "Branca")]
        Branca = 1,

        [Display(Name = "Negra")]
        Negra = 2,

        [Display(Name = "Parda")]
        Parda = 3,

        [Display(Name = "Amarela")]
        Amarela = 4,

        [Display(Name = "Indígena")]
        Indigena = 5
    }
}
