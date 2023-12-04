using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;

namespace Algoriza_BE_333.Helper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Patient, PatientDto>();

        }

    }
}
