using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;
using Microsoft.AspNetCore.Identity;

namespace Core.Service
{
    public interface IPatientRegistrationPageService
    {
        Task<IdentityResult> SignUpAsync(SignUp signup);
    }
}
