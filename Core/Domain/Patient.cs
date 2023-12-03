﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int UserRoleID { get; set; }
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


    }
}
