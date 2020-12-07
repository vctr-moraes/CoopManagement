using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum EscolaridadeViewModel
    {
        [Display(Name = "Primeiro grau")]
        PrimeiroGrau = 1,
        [Display(Name = "Segundo grau")]
        SegundoGrau = 2,
        [Display(Name = "Terceiro grau")]
        TerceiroGrau = 3
    }
}
