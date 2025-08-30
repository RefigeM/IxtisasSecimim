using Ixtisas_Secimim.DAL;
using Ixtisas_Secimim.DTOs.Students;
using Ixtisas_Secimim.Services.Abstracts;
using Ixtisas_Secimim.Services.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ixtisas_Secimim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController(IStudentService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok(await _service.GetAllAsync());
        }

        //[HttpPost]
        //public async Task<IActionResult> Post(StudentCreateDto dto)
        //{
        //    await _service.CreateAsync(dto);   
        //    return Created();

        //}
        [HttpPost]
        public async Task<IActionResult> CreateAndSuggest(StudentCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Bazaya yaz
            var student = await _service.CreateAsync(dto);

            // AI-ə göndər
            var aiResult = await _service.SuggestMajorAsync(dto);

            return Ok(new
            {
                Student = student,
                AiResult = aiResult
            });
        }
    }
}
