using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Service
{
    public interface IAdminPatientPageService
    {
        ICollection<Patient> GetAllPatients();
        Patient GetPatientByID(int id);
        public bool PatientExist(int id);
    }
}
