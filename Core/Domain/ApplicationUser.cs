using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Domain
{
    public class ApplicationUser : IdentityUser
    {

        //[Key]
        //public int UserRoleID { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string UserRoleName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
