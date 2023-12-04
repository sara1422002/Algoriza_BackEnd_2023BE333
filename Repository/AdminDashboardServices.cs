using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class AdminDashboardServices : IAdminDashboardService
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminDashboardServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int GetDoctorCount()
        {
            return _dbContext.doctors.Count();
        }

        public int GetPatientCount()
        {
            return _dbContext.patients.Count();
        }

        public int GetRequestCount()
        {
            return _dbContext.appointments.Count();
        }
        public ICollection<Doctor> GetTopDoctorsWithMostAppointments()
        {
            return _dbContext.doctors.OrderByDescending(doctor => doctor.appointments.Count).Take(10).ToList();
        }
        public ICollection<Specialization> GetTopSpecializationsWithMostDoctors()
        {
            return _dbContext.Specializations
                .OrderByDescending(specialization => _dbContext.doctors.Count(doctor => doctor.ID == specialization.ID))
                .Take(5)
                .ToList();
        }
     

    }
}
