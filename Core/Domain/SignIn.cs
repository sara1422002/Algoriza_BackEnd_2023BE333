using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class SignIn
    {
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [Required]
        public string Password { get; set; }
    }
}
