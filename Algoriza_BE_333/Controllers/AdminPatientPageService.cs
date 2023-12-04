using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{

    [Route("api/admin-dashboard/PatientPage")]
    [ApiController]
    public class AdminPatientPageController  : Controller
    {
        private readonly IAdminPatientPageService _adminPatientPageService;
        private readonly IMapper _mapper;
        public AdminPatientPageController(IAdminPatientPageService adminPatientPageService, IMapper mapper)
        {
            _adminPatientPageService = adminPatientPageService ?? throw new ArgumentNullException(nameof(adminPatientPageService));
            _mapper = mapper;        
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Patient))]
        public IActionResult GetPatients()
        {
            var PatientList = _mapper.Map < List < PatientDto >>( _adminPatientPageService.GetAllPatients());
            var dashboardData = new
            {
                PatientList = PatientList
            };
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            return Ok(dashboardData);
        }

        [HttpGet("{PatientID}")]
        [ProducesResponseType(200, Type = typeof(Patient))]
        [ProducesResponseType(400)]
        public IActionResult GetPatientByID(int PatientID)
        {
            var patient = _mapper.Map<PatientDto>(_adminPatientPageService.GetPatientByID(PatientID));

            if (!_adminPatientPageService.PatientExist(PatientID))
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(PatientID);
        }

    }
}
