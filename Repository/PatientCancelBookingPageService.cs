using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class PatientCancelBookingPageService : IPatientCancelBookingPageService
    {
        private ApplicationDbContext _dbContext;

        public Appointment DeleteAppointment(int id)
        {
            var AppointmentToDelete = _dbContext.appointments.Find(id);
            if (AppointmentToDelete == null)
            {
                return null; // Return null if the doctor with the specified ID is not found
            }
            _dbContext.appointments.Remove(AppointmentToDelete);
            _dbContext.SaveChanges();
            return AppointmentToDelete;

        }
    }
}
