using System.Security.Cryptography.X509Certificates;
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

        public AdminDashboardController(IAdminDashboardService adminDashboardService)
        {
            _adminDashboardService = adminDashboardService ?? throw new ArgumentNullException(nameof(adminDashboardService));

        }




        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Doctor>))]
        public IActionResult GetDashboardData()
        {
            var doctorCount = _adminDashboardService.GetDoctorCount();
            var patientCount = _adminDashboardService.GetPatientCount();
            var requestCount = _adminDashboardService.GetRequestCount();
            var DoctorList = _adminDashboardService.GetTopDoctorsWithMostAppointments();
            var SpecializationList = _adminDashboardService.GetTopSpecializationsWithMostDoctors();

            var dashboardData = new
            {
                DoctorCount = doctorCount,
                PatientCount = patientCount,
                RequestCount = requestCount,
                DoctorList = DoctorList,
                SpecializationList = SpecializationList
            };

            return Ok(dashboardData);
        }
    }
}
