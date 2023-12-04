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
