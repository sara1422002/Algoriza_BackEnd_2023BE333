using Algoriza_BE_333.Dto;
using AutoMapper;
using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algoriza_BE_333.Controllers
{
    [Route("api/admin-dashboard/AdminSettings")]
    [ApiController]
    public class AdminSettingPageService : ControllerBase
    {
        private IAdminSettingPageService _adminSettingPageService;
        private IMapper _mapper;


        public AdminSettingPageService(IAdminSettingPageService adminSettingPageService, IMapper mapper)
        {
            _adminSettingPageService = adminSettingPageService ?? throw new ArgumentNullException(nameof(adminSettingPageService));
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(DiscountCodeCoupoun))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateDiscountCode([FromForm] DiscountCodeCoupoun discountCodeCoupoun)
        {
            var newDiscountCode= await _adminSettingPageService.CreateDiscountCode(discountCodeCoupoun);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction(nameof(newDiscountCode), new { id = newDiscountCode.Id }, newDiscountCode);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(200, Type = typeof(DiscountCodeCoupoun))]
        [ProducesResponseType(400)]
        public IActionResult DeleteDiscountCode(int id)
        {
            var deletedDiscountCode = _mapper.Map<DiscountCodeCoupoun>(_adminSettingPageService.DeleteDiscountCode(id));
            if (deletedDiscountCode == null)
            {
                return NotFound(); // Return 404 Not Found if the doctor with the specified ID is not found
            }

            return Ok(deletedDiscountCode);
        }
        [HttpPut]
        [ProducesResponseType(200, Type = typeof(DiscountCodeCoupoun))]
        [ProducesResponseType(400)]
        public IActionResult UpdateDiscountcode([FromBody] DiscountCodeCoupoun updateDiscountCode)
        {
            var updatedDiscountcode = _mapper.Map<DiscountCodeCoupoun>(_adminSettingPageService.UpdateDiscountcode(updateDiscountCode));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (updatedDiscountcode == null)
            {
                return NotFound();
            }
            return Ok(updatedDiscountcode);
        }
    }
}
