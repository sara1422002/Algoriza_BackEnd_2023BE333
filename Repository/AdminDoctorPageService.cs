using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class AdminDoctorPageService: IAdminDoctorPageService
    {
            private readonly ApplicationDbContext _dbContext;
            public AdminDoctorPageService(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public ICollection<Doctor> GetAllDoctors()
            {
                return _dbContext.doctors.ToList();
            }

            public Doctor GetDoctorByID(int id)
            {
                return _dbContext.doctors.Where(d=>d.ID == id).FirstOrDefault();
            }

            public bool DoctorExist(int id)
            {
                return _dbContext.doctors.Any(d=>d.ID == id);
            }


    }
}
