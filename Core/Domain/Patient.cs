﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Core.Domain
{
    public class Patient : ApplicationUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [ForeignKey("UserRoleID")]
        public ApplicationUser ApplicationUsers { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Passwordhash { get; set; }

        [ForeignKey("AppointmentId")]
        public ICollection<Appointment> appointments { get; set; }


    }
}
