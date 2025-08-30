using AutoMapper;
using Ixtisas_Secimim.DTOs.Students;
using Ixtisas_Secimim.Entities;
using Ixtisas_Secimim.Enums;
using Ixtisas_Secimim.Extentions;

namespace Ixtisas_Secimim.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
             CreateMap<StudentCreateDto, Student>()
            .ForMember(dest => dest.SpecGroup, opt => opt.MapFrom(src => (SpecGroup)src.SpecGroup))
            .ForMember(dest => dest.PaidType, opt => opt.MapFrom(src => (PaidType)src.PaidType));

            CreateMap<Student, StudentGetAllDto>()
           .ForMember(dest => dest.SpecGroup, opt => opt.MapFrom(src => src.SpecGroup.GetDisplayName()))
           .ForMember(dest => dest.PaidType, opt => opt.MapFrom(src => src.PaidType.GetDisplayName()));
        }
    }
}
