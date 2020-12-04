using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum StatusMatriculaViewModel
    {
        [Display(Name = "Ativo")]
        Ativo = 1,

        [Display(Name = "Inativo")]
        Inativo = 2,

        [Display(Name = "Aguardando")]
        Aguardando = 3
    }
}
