using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class PatientSearchDoctorPageService : IPatientSearchDoctorPageService
    {
        private readonly ApplicationDbContext _dbContext;
        public ICollection<Doctor> GetAllDoctors()
        {
            return _dbContext.doctors.ToList();
        }
        
        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            var NewAppointment = new Appointment()
            {
               Day = appointment.Day,
            };

            _dbContext.appointments.Add(NewAppointment);
            _dbContext.SaveChanges();
            return NewAppointment;
        }
    }
}
