using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
