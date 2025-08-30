using FluentValidation;
using Ixtisas_Secimim.DTOs.Students;

namespace Ixtisas_Secimim.Validators.Student
{
    public class StudentCreateDtoValidator
        : AbstractValidator<StudentCreateDto>
    {
        public StudentCreateDtoValidator()
        {
            RuleFor(s => s.Fullname)
                .NotNull()
                .NotEmpty()
                .WithMessage("Bu hissə boş ola bilmez!")
                .MaximumLength(64)
                .WithMessage("Maksimum uzunluq 64 olmalıdır.");
            RuleFor(s => s.Score)
                .NotEmpty()
                .WithMessage("Qəbul balınızı daxil edin.")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Qəbul balınız 0-700 aralığında olmalıdır.")
                .LessThanOrEqualTo(700)
                .WithMessage("Qəbul balınız 0-700 aralığında olmalıdır.");
            RuleFor(s => s.SpecGroup)
               .NotNull()
               .NotEmpty()
               .WithMessage("İxtisas qrupunu seçilməlidir.")
               .IsInEnum();
;
            RuleFor(s => s.PaidType)
               .NotNull()
               .WithMessage("Təhsil növü seçilməlidir.")
                .IsInEnum()
                .WithMessage("Təhsil növü yalnız 1 (Ödənişli), 2 (Ödənişsiz) və ya 3 (Fərq etmir) ola bilər.");

            RuleFor(s => s.Motivation)
                .MaximumLength(500)
                .WithMessage("Maximum uzunluq 500 olmalidir.");

        }
    }
}
