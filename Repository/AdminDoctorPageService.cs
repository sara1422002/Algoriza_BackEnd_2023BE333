﻿using Algoriza_BE_333.Repository;
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
            return _dbContext.doctors.Where(d => d.ID == id).FirstOrDefault();
        }

        public bool DoctorExist(int id)
        {
            return _dbContext.doctors.Any(d => d.ID == id);
        }
        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }
        public async Task<Doctor> CreateDoctor(Doctor doctor)
        {
            var doctorOwner = new Doctor()
            {
                ID = doctor.ID,
                Name = doctor.Name,
                Phone = doctor.Phone,
                Image = doctor.Image,
                Gender = doctor.Gender,
                ApplicationUsers = doctor.ApplicationUsers
            };

            _dbContext.doctors.Add(doctorOwner);
            _dbContext.SaveChanges();
            return doctorOwner;
        }

        public Doctor UpdateDoctor(Doctor updateDoctor)
        {
            var existingDoctor = _dbContext.doctors.Find(updateDoctor.ID);
            if (existingDoctor == null)
            {
                return null;
            }
            existingDoctor.Name = updateDoctor.Name ?? existingDoctor.Name;
            existingDoctor.ApplicationUsers = updateDoctor.ApplicationUsers ?? existingDoctor.ApplicationUsers;
            existingDoctor.Image = updateDoctor.Image ?? existingDoctor.Image;
            existingDoctor.appointments = updateDoctor.appointments ?? existingDoctor.appointments;
            existingDoctor.Phone = updateDoctor.Phone ?? existingDoctor.Phone;
            existingDoctor.Specializations = updateDoctor.Specializations ?? existingDoctor.Specializations;

            _dbContext.SaveChanges();
            return existingDoctor;

        }

        public Doctor DeleteDoctor(int id)
        {
            var DoctorToDelete = _dbContext.doctors.Find(id);
            if (DoctorToDelete == null)
            {
                return null; // Return null if the doctor with the specified ID is not found
            }
            _dbContext.doctors.Remove(DoctorToDelete);
            _dbContext.SaveChanges();
            return DoctorToDelete;

        }
    }

}

