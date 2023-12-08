using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Patient/PatientCancellation")]
    [ApiController]
    public class PatientCancelBookingPageService : ControllerBase
    {
        private IPatientCancelBookingPageService _PatientCancelBookingPageService;
        private IMapper _mapper;

        public PatientCancelBookingPageService(IPatientCancelBookingPageService PatientCancelBookingPageService, IMapper mapper)
        {
            _PatientCancelBookingPageService = PatientCancelBookingPageService ?? throw new ArgumentNullException(nameof(PatientCancelBookingPageService));
            _mapper = mapper;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult DeleteAppointment(int id)
        {
            var deletedAppointment = _mapper.Map<AppointmentDto>(_PatientCancelBookingPageService.DeleteAppointment(id));
            if (deletedAppointment == null)
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }

            return Ok(deletedAppointment);
        }
    }
}
