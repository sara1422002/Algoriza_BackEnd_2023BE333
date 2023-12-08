using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Doctor")]
    [ApiController]
    public class DoctorLoginPageService : ControllerBase
    {
        private readonly IDoctorLoginPageService _doctorLoginPageService;
        public DoctorLoginPageService(IDoctorLoginPageService doctorLoginPageService)
        {
            _doctorLoginPageService = doctorLoginPageService;
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromForm] SignIn signin)
        {
            var result = await _doctorLoginPageService.LoginAsync(signin);
            if (String.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);

        }
    }
}
