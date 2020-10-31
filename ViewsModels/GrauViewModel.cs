using System.ComponentModel.DataAnnotations;

namespace CoopManagement.ViewsModels
{
    public enum GrauViewModel
    {
        [Display(Name = "Técnico")]
        Técnico = 1,

        [Display(Name = "Superior")]
        Superior = 2
    }
}
