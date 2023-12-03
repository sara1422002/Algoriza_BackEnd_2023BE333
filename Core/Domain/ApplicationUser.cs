using System.ComponentModel.DataAnnotations;
namespace Core.Domain
{
    public class ApplicationUser
    {
        
            [Key]
            public int UserRoleID { get; set; }

            [Required]
            [StringLength(100)]
            public string UserRoleName { get; set; }

        
    }
}
