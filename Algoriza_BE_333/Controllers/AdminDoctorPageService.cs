using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/admin-dashboard/doctors")]
    [ApiController]
    public class AdminDoctorPageController : Controller
    {
        private readonly IAdminDoctorPageService _adminDoctorPageService;
        
        public AdminDoctorPageController(IAdminDoctorPageService adminDoctorPageService)
        {
            _adminDoctorPageService = adminDoctorPageService ?? throw new ArgumentNullException(nameof(adminDoctorPageService));
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Doctor>))]
        public IActionResult GetDashboardDoctorData()
        {
            var DoctorList = _adminDoctorPageService.GetAllDoctors();

            var dashboardData = new
            {
                DoctorList = DoctorList,
              
            };

            return Ok(dashboardData);
        }
    }
}
