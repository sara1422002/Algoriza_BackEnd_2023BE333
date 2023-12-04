using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
