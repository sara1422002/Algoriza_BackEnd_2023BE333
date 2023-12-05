using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Mvc;


namespace Algoriza_BE_333.Controllers
{
    [Route("api/admin-dashboard/doctors")]
    [ApiController]
    public class AdminDoctorPageController : Controller
    {
        private  IAdminDoctorPageService _adminDoctorPageService;
        private  IMapper _mapper;


        public AdminDoctorPageController(IAdminDoctorPageService adminDoctorPageService, IMapper mapper)
        {
            _adminDoctorPageService = adminDoctorPageService ?? throw new ArgumentNullException(nameof(adminDoctorPageService));
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        public IActionResult GetDoctors()
        {
            var DoctorList = _mapper.Map<List<DoctorDto>>(_adminDoctorPageService.GetAllDoctors());
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
            var doctor = _mapper.Map<DoctorDto>(_adminDoctorPageService.GetDoctorByID(DoctorID));
            if (!_adminDoctorPageService.DoctorExist(DoctorID))
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(DoctorID);

        }
        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        [ProducesResponseType(400)]
        public IActionResult DoctorCreate(int id, string name, string phone, Gender gender, string email, string password, string image, ApplicationUser userrole)
        {
            var newDoctor = _mapper.Map<DoctorDto>(_adminDoctorPageService.CreateDoctor(id,name, phone,gender,email,password,image,userrole));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction(nameof(Doctor), new { id = newDoctor.ID }, newDoctor);


        }
        [HttpPut]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        [ProducesResponseType(400)]
        public IActionResult UpdateDoctor([FromBody] Doctor updateDoctor)
        {
            var updatedDoctor = _mapper.Map<DoctorDto>(_adminDoctorPageService.UpdateDoctor(updateDoctor));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(updatedDoctor == null)
            {
                return NotFound();
            }
            return Ok(updatedDoctor);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        [ProducesResponseType(400)]
        public IActionResult DeleteDoctor(int id)
        {
            var deletedDoctor = _mapper.Map < DoctorDto > (_adminDoctorPageService.DeleteDoctor(id));
            if (deletedDoctor == null)
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }

            return Ok(deletedDoctor);
        }


    }

}

