using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Service;
using Core.Domain;
using Algoriza_BE_333.Repository;

namespace Service
{
    public class AdminDashboardServices:IAdminDashboardService
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
    }
}
