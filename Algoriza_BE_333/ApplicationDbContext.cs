using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Repository
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
           options.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Vezeeta;Integrated Security=True");


        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Admin> admins { get; set; }

        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }

        public DbSet<Patient> patients { get; set; }    

    }


}
