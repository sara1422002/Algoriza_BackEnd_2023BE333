using Core.Domain;

namespace Core.Service
{
    public interface IPatientBookingPageService
    {
        ICollection<Appointment> GetAllAppointments();
    }
}
