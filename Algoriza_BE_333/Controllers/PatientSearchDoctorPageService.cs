using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/PatientSearch")]
    [ApiController]
    public class PatientSearchDoctorPageService : ControllerBase
    {
        private IPatientSearchDoctorPageService _PatientSearchDoctorPageService;
        private IMapper _mapper;

        public PatientSearchDoctorPageService(IPatientSearchDoctorPageService PatientSearchDoctorPageService, IMapper mapper)
        {
            _PatientSearchDoctorPageService = PatientSearchDoctorPageService ?? throw new ArgumentNullException(nameof(PatientSearchDoctorPageService));
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Doctor))]
        public IActionResult GetDoctors()
        {
            var DoctorList = _mapper.Map<List<Dto.DoctorDto>>(_PatientSearchDoctorPageService.GetAllDoctors());
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

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Appointment))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateAppointment([FromForm] Appointment appointment)
        {
            var newAppointment = _mapper.Map<List<AppointmentDto>>(await _PatientSearchDoctorPageService.CreateAppointment(appointment));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(newAppointment);
        }
    }
}
