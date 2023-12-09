using Core.Domain;

namespace Core.Service
{
    public interface IDoctorSettingPageService
    {
        Task<Appointment> CreateAppointment(Appointment appointment);
        public Appointment DeleteAppointment(int id);
        public Appointment UpdateAppointment(Appointment updateAppointment);
    }
}
