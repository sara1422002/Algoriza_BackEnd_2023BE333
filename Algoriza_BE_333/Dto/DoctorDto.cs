﻿using Core.Domain;

namespace Algoriza_BE_333.Dto
{
    public class DoctorDto 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Specialization Specializations { get; set; }
        public ICollection<Appointment> appointments { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
        public ApplicationUser ApplicationUsers { get; set; }
        public Gender Gender { get; set; }

    }
}
