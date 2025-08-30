using Ixtisas_Secimim.Enums;
using Ixtisas_Secimim.Extentions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ixtisas_Secimim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEnums()
        {
            var paidTypes = Enum.GetValues(typeof(PaidType))
                                .Cast<PaidType>()
                                .Select(e => new { Value = (int)e, Text = e.GetDisplayName() })
                                .ToList();

            var specGroups = Enum.GetValues(typeof(SpecGroup))
                                 .Cast<SpecGroup>()
                                 .Select(e => new { Value = (int)e, Text = e.GetDisplayName() })
                                 .ToList();

            return Ok(new
            {
                PaidTypes = paidTypes,
                SpecGroups = specGroups
            });
        }
    }
}
