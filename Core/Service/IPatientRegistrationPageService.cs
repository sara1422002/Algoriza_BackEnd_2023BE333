using Core.Domain;
using Microsoft.AspNetCore.Identity;

namespace Core.Service
{
    public interface IPatientRegistrationPageService
    {
        Task<IdentityResult> SignUpAsync(SignUp signup);
    }
}
