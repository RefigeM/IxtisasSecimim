using System.ComponentModel.DataAnnotations;

namespace Ixtisas_Secimim.Enums
{
    public enum PaidType
    {
        [Display(Name = "Ödənişli")]
        Paid,
        [Display(Name = "Ödənişsiz")]
        Free,
        [Display(Name = "Fərq etmir")]
        Both
    }
}
