﻿using Algoriza_BE_333.Dto;
using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class AdminDoctorPageService : IAdminDoctorPageService
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

        //Barmaget El Creating doctor fel admin doctor page
            public Doctor CreateDoctor(Doctor doctor)
            {
                        var doctorOwner = new Doctor()
                        {
                           Email = doctor.Email,
                           Name = doctor.Name,
                           Phone = doctor.Phone,
                           SpecializationID = doctor.SpecializationID,
                           Password = doctor.Password
                        };

                        _dbContext.doctors.Add(doctorOwner);
                        _dbContext.SaveChanges();
                        return doctorOwner;
           
            }
            public bool Save()
            {
                var saved =_dbContext.SaveChanges();
                return saved>0?true :false;
            }
    }
}
