using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;


namespace Core.Service
{
    public interface IAdminDoctorPageService
    {
   
            ICollection<Doctor> GetAllDoctors();
            Doctor GetDoctorByID(int id);
            public bool DoctorExist(int id);

        //interface el creating doctor fel admin doctor page 
        public Doctor CreateDoctor(Doctor doctor);
            bool Save();

        
         Doctor UpdateDoctor(Doctor updateDoctor);
         Doctor DeleteDoctor(int id);



    }
}
