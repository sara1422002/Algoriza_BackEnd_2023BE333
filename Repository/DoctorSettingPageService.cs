using Algoriza_BE_333.Dto;
using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class DoctorSettingPageService : IDoctorSettingPageService
    {
        private  ApplicationDbContext _dbContext;
        public DoctorSettingPageService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            var newAppointment = new Appointment()
            {
                AppointmentId = appointment.AppointmentId,
                DateAndTime = appointment.DateAndTime,
                Day = appointment.Day,

            };

            _dbContext.appointments.Add(newAppointment);
            _dbContext.SaveChanges();
            return appointment;
        }


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


        public Appointment UpdateAppointment(Appointment updateAppointment)
        {
            var existingAppointment = _dbContext.appointments.Find(updateAppointment.AppointmentId);
            if (existingAppointment == null)
            {
                return null;
            }
            existingAppointment.Day = updateAppointment.Day;
            existingAppointment.DateAndTime = updateAppointment.DateAndTime;


            _dbContext.SaveChanges();
            return existingAppointment;

        }

    }
}
