using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/PatientBooking")]
    [ApiController]
    public class PatientBookingPageService : ControllerBase
    {

        private IPatientBookingPageService _PatientBookingPageService;
        private IMapper _mapper;


        public PatientBookingPageService(IPatientBookingPageService patientBookingPageService, IMapper mapper)
        {
            _PatientBookingPageService = patientBookingPageService ?? throw new ArgumentNullException(nameof(PatientBookingPageService));
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetAppointments()
        {
            var AppointmentsData = _mapper.Map<List<AppointmentDto>>(_PatientBookingPageService.GetAllAppointments());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(AppointmentsData);
        }

    }
}
