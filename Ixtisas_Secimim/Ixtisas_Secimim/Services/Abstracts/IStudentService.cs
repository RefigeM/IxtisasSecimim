using Ixtisas_Secimim.DTOs.Students;
using Ixtisas_Secimim.Entities;

namespace Ixtisas_Secimim.Services.Abstracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentGetAllDto>> GetAllAsync();
        Task<Student> CreateAsync(StudentCreateDto dto);
        Task<string> SuggestMajorAsync(StudentCreateDto dto);
    }
}
