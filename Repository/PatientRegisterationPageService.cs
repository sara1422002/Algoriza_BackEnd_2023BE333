using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Service;
using Core.Domain;
using Microsoft.AspNetCore.Identity;

namespace Repository
{
    public class PatientRegisterationPageService : IPatientRegistrationPageService
    {
        private readonly UserManager<Patient> _usermanager;

        public PatientRegisterationPageService(UserManager<Patient> usermanager) {
            _usermanager = usermanager;
        }
        public async Task<IdentityResult> SignUpAsync(SignUp signup)
        {
            var user = new Patient()
            {
                Name = signup.FirstName,
                 LastName = signup.LastName,
                 EmailAddress = signup.Email,
                 Passwordhash = signup.Password,
                 Gender = signup.Gender,
                 Phone = signup.Phone,

            };

           return await _usermanager.CreateAsync(user, signup.Password);

        }


    }
}
