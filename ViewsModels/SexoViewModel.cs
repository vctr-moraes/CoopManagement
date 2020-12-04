using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum SexoViewModel
    {
        [Display(Name = "Masculino")]
        Masculino = 1,

        [Display(Name = "Feminino")]
        Feminino = 2
    }
}
