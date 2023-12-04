using Core.Domain;


namespace Core.Service
{
    public interface IAdminDoctorPageService
    {
            ICollection<Doctor> GetAllDoctors();
            Doctor GetDoctorByID(int id);
            public bool DoctorExist(int id);
            public Doctor CreateDoctor(Doctor doctor);
            bool Save();
            Doctor UpdateDoctor(Doctor updateDoctor);
            Doctor DeleteDoctor(int id);
    }
}
