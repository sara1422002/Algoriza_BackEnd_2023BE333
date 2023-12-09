using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

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
