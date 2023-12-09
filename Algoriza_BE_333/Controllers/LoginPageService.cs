using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginPageService : ControllerBase
    {
        private  ILoginPageService _LoginPageService;


        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromForm] SignIn signin)
        {
            var result = await _LoginPageService.LoginAsync(signin);
            if (String.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);

        }
    }
}
