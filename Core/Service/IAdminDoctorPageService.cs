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


    }
}
