using Ixtisas_Secimim.Enums;
using System.ComponentModel.DataAnnotations;

namespace Ixtisas_Secimim.DTOs.Students
{
    public class StudentCreateDto
    {
        public string Fullname { get; set; } = null!;
        public int Score { get; set; }
        public SpecGroup SpecGroup { get; set; }
        public PaidType PaidType { get; set; }
        public string Motivation { get; set; }
    }
}
