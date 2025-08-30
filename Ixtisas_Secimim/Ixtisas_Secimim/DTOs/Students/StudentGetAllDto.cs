using Ixtisas_Secimim.Enums;

namespace Ixtisas_Secimim.DTOs.Students
{
    public class StudentGetAllDto
    {
        public string Fullname { get; set; } = null!;
        public int Score { get; set; }
        //public SpecGroup SpecGroup { get; set; }
        //public PaidType PaidType { get; set; }
        public string SpecGroup { get; set; }
        public string PaidType { get; set; }
        public string Motivation { get; set; }
    }
}
