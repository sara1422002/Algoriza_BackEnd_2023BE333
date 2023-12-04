using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class AdminPatientPageService : IAdminPatientPageService
    {
        private readonly ApplicationDbContext _dbContext;
        public AdminPatientPageService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICollection<Patient> GetAllPatients()
        {
            return _dbContext.patients.ToList();
        }

        public Patient GetPatientByID(int id)
        {
            return _dbContext.patients.Where(d => d.ID == id).FirstOrDefault();
        }

        public bool PatientExist(int id)
        {
            return _dbContext.patients.Any(d => d.ID == id);
        }


    }

}
