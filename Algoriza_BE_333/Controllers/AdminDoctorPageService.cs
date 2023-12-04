using System.Numerics;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;

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
        [ProducesResponseType(200, Type = typeof(Doctor))]
        public IActionResult GetDoctors()
        {
            var DoctorList = _adminDoctorPageService.GetAllDoctors();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            var dashboardData = new
            {
                DoctorList = DoctorList

            };
            return Ok(dashboardData);
        }



        [HttpGet("{DoctorID}")]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        [ProducesResponseType(400)]
        public IActionResult GetDoctorByID(int DoctorID)
        {
            var doctor = _adminDoctorPageService.GetDoctorByID(DoctorID);

            if (!_adminDoctorPageService.DoctorExist(DoctorID))
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }
            
           if(!ModelState.IsValid) 
               return BadRequest(ModelState);

           return Ok(DoctorID);

            }

        }
}

