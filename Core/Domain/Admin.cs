﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }

        //ForeignKey from ApplicationUser Table
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public ApplicationUser applicationUser { get; set; }
    }
}
