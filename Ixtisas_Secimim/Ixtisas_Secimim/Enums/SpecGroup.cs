using System.ComponentModel.DataAnnotations;

namespace Ixtisas_Secimim.Enums
{
    public enum SpecGroup
    {
        [Display(Name = "I Qrup 'Rİ və RK'")]
        I_RIRK,
        [Display(Name = "I Qrup 'RK'")]
        I_RK,
        [Display(Name = "I Qrup 'RI'")]
        I_RI,

        [Display(Name = "II Qrup")]
        II,

        [Display(Name = "III Qrup 'DT və TC'")]
        III_DTTC,
        [Display(Name = "III Qrup 'DT'")]
        III_DT,
        [Display(Name = "III Qrup 'TC'")]
        III_TC,

        [Display(Name = "IV Qrup")]
        IV,

        [Display(Name = "V Qrup")]
        V
    }
}
