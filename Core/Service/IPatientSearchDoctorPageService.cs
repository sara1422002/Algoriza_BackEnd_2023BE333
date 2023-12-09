using Core.Domain;

namespace Core.Service
{
    public interface IPatientSearchDoctorPageService
    {
        ICollection<Doctor> GetAllDoctors();
        Task<Appointment> CreateAppointment(Appointment appointment);
    }
}
