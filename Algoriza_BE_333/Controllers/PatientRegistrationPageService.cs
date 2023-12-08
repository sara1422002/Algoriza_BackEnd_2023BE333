using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Patient")]
    [ApiController]
    public class PatientRegistrationPageService : ControllerBase
    {
        private readonly IPatientRegistrationPageService _patientRegistrationPageService;

        public PatientRegistrationPageService (IPatientRegistrationPageService patientRegistrationPageService)
        {
            _patientRegistrationPageService = patientRegistrationPageService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Signup([FromForm]SignUp signup)
        {
            var result = await _patientRegistrationPageService.SignUpAsync(signup);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();

        }
    }
}
