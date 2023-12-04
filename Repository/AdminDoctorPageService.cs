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


        
    }
}
