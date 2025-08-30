using Ixtisas_Secimim.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Ixtisas_Secimim.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = null!;
        public int Score { get; set; }
        public SpecGroup SpecGroup { get; set; }
        public PaidType PaidType { get; set; }
        public string Motivation { get; set; }
    }
}
