using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum NecessidadeEspecialViewModel
    {
        [Display(Name = "Nenhuma")]
        Nenhuma = 1,

        [Display(Name = "Física")]
        Fisica = 2,

        [Display(Name = "Mental")]
        Mental = 3,

        [Display(Name = "Visual")]
        Visual = 4,

        [Display(Name = "Auditiva")]
        Auditiva = 5
    }
}
