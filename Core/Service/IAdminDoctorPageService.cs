using Core.Domain;


namespace Core.Service
{
    public interface IAdminDoctorPageService
    {
            ICollection<Doctor> GetAllDoctors();
            Doctor GetDoctorByID(int id);
            public bool DoctorExist(int id);
            Doctor CreateDoctor(int id,string name , string phone  , Gender gender, string email , string password , string image, ApplicationUser userrole );
            bool Save();
            Doctor UpdateDoctor(Doctor updateDoctor);
            Doctor DeleteDoctor(int id);
    }
}
