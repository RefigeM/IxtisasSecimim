using AutoMapper;
using Ixtisas_Secimim.DAL;
using Ixtisas_Secimim.DTOs.Students;
using Ixtisas_Secimim.Entities;
using Ixtisas_Secimim.Enums;
using Ixtisas_Secimim.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text;
using Microsoft.OpenApi.Extensions;

namespace Ixtisas_Secimim.Services.Implements
{
    public class StudentService(SpecializationDbContext _context,IMapper _mapper) : IStudentService
    {
        public async Task<Student> CreateAsync(StudentCreateDto dto)
        {
            var studentData = _mapper.Map<Student>(dto);
            await _context.Students.AddAsync(studentData);
            await _context.SaveChangesAsync();
            return studentData; // Student qaytar
        }

        public async Task<IEnumerable<StudentGetAllDto>> GetAllAsync()
        {
            try
            {
                var datas = await _context.Students.ToListAsync();
                return _mapper.Map<IEnumerable<StudentGetAllDto>>(datas);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Student məlumatları gətirilərkən xəta baş verdi", ex);
            }
        }
        //public async Task<string> SuggestMajorAsync(StudentCreateDto dto)
        //{
        //var aiRequest = new AiStudentRequest
        //{
        //    Fullname = dto.Fullname,
        //    Score = dto.Score,
        //    SpecGroup = ((SpecGroup)dto.SpecGroup).GetDisplayName(),
        //    PaidType = ((PaidType)dto.PaidType).GetDisplayName(),
        //    Motivation = dto.Motivation
        //};

        //    string json = JsonSerializer.Serialize(aiRequest);

        //    using var client = new HttpClient();
        //    var content = new StringContent(json, Encoding.UTF8, "application/json");

        //    var response = await client.PostAsync("https://AI-API-ENDPOINT", content);
        //    response.EnsureSuccessStatusCode();

        //    return await response.Content.ReadAsStringAsync();
        //}
        public async Task<string> SuggestMajorAsync(StudentCreateDto dto)
        {
            // Sanki serverə göndəririk
            await Task.Delay(300);

            // Fake cavab
            var fakeResponse = new
            {
                SuggestedUniversity = "ADA University",
                SuggestedMajor = "Computer Science"
            };

            return JsonSerializer.Serialize(fakeResponse);
        }
    }
}
