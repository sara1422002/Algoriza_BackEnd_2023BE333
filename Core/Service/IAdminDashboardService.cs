using Core.Domain;

namespace Core.Service
{
    public interface IAdminDashboardService
    {
        int GetDoctorCount();
        int GetPatientCount();
        int GetRequestCount();
        ICollection<Doctor> GetTopDoctorsWithMostAppointments();
        ICollection<Specialization> GetTopSpecializationsWithMostDoctors();
    }

}
