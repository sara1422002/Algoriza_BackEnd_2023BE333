using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public Gender Gender { get; set; }

        [Required]
        //Foreignkey for UserRoleID
        public int UserRoleID { get; set; }
        [ForeignKey("UserRoleID")]
        public ApplicationUser ApplicationUsers { get; set; }

        // Image property that is nullable and must be a valid URL
        [Url]
        public string? Image { get; set; }

        // Navigation property for Specialization ID
        //ForeignKey
        public int SpecializationID { get; set; }
        [ForeignKey("SpecializationID")]
        public Specialization Specializations { get; set; }
    }
    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}

