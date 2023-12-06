using System;
using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/admin-dashboard")]
    [ApiController]
    public class AdminDashboardController : Controller
    {
        private readonly IAdminDashboardService _adminDashboardService;
      
        private readonly IMapper _mapper;

        public AdminDashboardController(IAdminDashboardService adminDashboardService, IMapper mapper)
        {
            _adminDashboardService = adminDashboardService ?? throw new ArgumentNullException(nameof(adminDashboardService));
            mapper = _mapper;

        }

        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Doctor>))]
        public IActionResult GetDashboardData()
        {
            var doctorCount = _mapper.Map< DoctorDto > (_adminDashboardService.GetDoctorCount());
            var patientCount = _mapper.Map<PatientDto>(_adminDashboardService.GetPatientCount());
            var requestCount = _mapper.Map<AppointmentDto>(_adminDashboardService.GetRequestCount());
            var DoctorList = _mapper.Map<List<DoctorDto>>(_adminDashboardService.GetTopDoctorsWithMostAppointments());
            var SpecializationList = _mapper.Map<List<SpecializationDto>>(_adminDashboardService.GetTopSpecializationsWithMostDoctors());

            var dashboardData = new
            {
                DoctorCount = doctorCount,
                PatientCount = patientCount,
                RequestCount = requestCount,
                Doctorlist = DoctorList,
                Specializationlist = SpecializationList
            };

            return Ok(dashboardData);
        }
    }
}
