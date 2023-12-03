using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/admin-dashboard")]
    [ApiController]
    public class AdminDashboardController : ControllerBase
    {
        private readonly IAdminDashboardService _adminDashboardService;

        public AdminDashboardController(IAdminDashboardService adminDashboardService)
        {
            _adminDashboardService = adminDashboardService ?? throw new ArgumentNullException(nameof(adminDashboardService));
        }




        [HttpGet]
        public IActionResult GetDashboardData()
        {
            var doctorCount = _adminDashboardService.GetDoctorCount();
            var patientCount = _adminDashboardService.GetPatientCount();
            var requestCount = _adminDashboardService.GetRequestCount();

            var dashboardData = new
            {
                DoctorCount = doctorCount,
                PatientCount = patientCount,
                RequestCount = requestCount
            };

            return Ok(dashboardData);
        }
    }
}
