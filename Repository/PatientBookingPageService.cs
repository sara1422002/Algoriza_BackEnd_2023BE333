using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoriza_BE_333.Dto;
using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PatientBookingPageService : IPatientBookingPageService
    {
        private ApplicationDbContext _dbContext;
        public ICollection<Appointment> GetAllAppointments()
        {
            return _dbContext.appointments.ToList();
        }
    }
}
