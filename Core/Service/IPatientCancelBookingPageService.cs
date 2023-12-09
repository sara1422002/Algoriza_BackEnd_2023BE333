using Core.Domain;
namespace Core.Service
{
    public interface IPatientCancelBookingPageService
    {
        public Appointment DeleteAppointment(int id);
    }
}
