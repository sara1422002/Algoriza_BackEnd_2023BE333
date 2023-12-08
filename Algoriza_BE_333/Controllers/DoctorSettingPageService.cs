using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/Doctor/DoctorSetting")]
    [ApiController]
    public class DoctorSettingPageService : ControllerBase
    {
        private IDoctorSettingPageService _doctorSettingPageService;
        private IMapper _mapper;

        public DoctorSettingPageService(IDoctorSettingPageService doctorSettingPageService, IMapper mapper)
        {
            _doctorSettingPageService = _doctorSettingPageService ?? throw new ArgumentNullException(nameof(doctorSettingPageService));
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Appointment))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateAppointment([FromForm] Appointment appointment)
        {
            var newAppointment = await _doctorSettingPageService.CreateAppointment(appointment);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction(nameof(appointment), new { id = newAppointment.AppointmentId }, newAppointment);
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult DeleteAppointment(int id)
        {
            var deletedAppointment = _mapper.Map<Appointment>(_doctorSettingPageService.DeleteAppointment(id));
            if (deletedAppointment == null)
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }

            return Ok(deletedAppointment);
        }

        [HttpPut]
        [ProducesResponseType(200, Type = typeof(Appointment))]
        [ProducesResponseType(400)]
        public IActionResult UpdateAppointment([FromBody] Appointment updateAppointment)
        {
            var updatedAppointment = _mapper.Map<AppointmentDto>(_doctorSettingPageService.UpdateAppointment(updateAppointment));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (updatedAppointment == null)
            {
                return NotFound();
            }
            return Ok(updatedAppointment);
        }



    }
}
