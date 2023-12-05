﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Core.Domain
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public Gender Gender { get; set; }

        [Required]
        //Foreignkey for UserRoleID
        [ForeignKey("UserRoleID")]
        public ApplicationUser ApplicationUsers { get; set; }

        // Image property that is nullable and must be a valid URL
        [Url]
        public string? Image { get; set; }

        // Navigation property for Specialization ID
        //ForeignKey
        [ForeignKey("SpecializationID")]
        public Specialization Specializations { get; set; }

        public ICollection<Appointment> appointments { get; set; }
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Female,
        Male
    }
}

