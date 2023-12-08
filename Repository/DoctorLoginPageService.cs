using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Text;

namespace Repository
{
    public class DoctorLoginPageService : IDoctorLoginPageService
    {
        private readonly SignInManager<Doctor> _signinmanager;
        private readonly IConfiguration _configuration;
        public DoctorLoginPageService(SignInManager<Doctor> signInManager, IConfiguration configuration)
        {
            _signinmanager = signInManager;
            _configuration = configuration;
        }
        public async Task<string> LoginAsync(SignIn signin)
        {
            var result = await _signinmanager.PasswordSignInAsync(signin.Email, signin.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, signin.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
