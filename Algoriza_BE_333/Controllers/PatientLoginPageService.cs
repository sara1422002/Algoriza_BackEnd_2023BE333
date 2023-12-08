using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Patient")]
    [ApiController]
    public class PatientLoginPageService : ControllerBase
    {
        private readonly IPatientLoginPageService _patientLoginPageService;

        public PatientLoginPageService(IPatientLoginPageService patientLoginPageService)
        {
            _patientLoginPageService = patientLoginPageService;
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromForm] SignIn signin)
        {
            var result = await _patientLoginPageService.LoginAsync(signin);
            if (String.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);

        }
    }
}
