using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlexiLedger.Api.Controllers
{
    [Route("api/flexi-number")]
    [ApiController]
    public class FlexiNumberController : ControllerBase
    {
        private readonly IFlexiNumberService _service;

        public FlexiNumberController(IFlexiNumberService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var flexiNumbers = await _service.GetAllAsync();

            return Ok(flexiNumbers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var flexiNumber = await _service.GetByIdAsync(id);

            if (flexiNumber == null)
            {
                return NotFound();
            }

            return Ok(flexiNumber);
        }

        [HttpPost]
        public async Task<IActionResult> Post(FlexiNumber flexiNumber)
        {
            var createdFlexiNumber = await _service.AddAsync(flexiNumber);

            return CreatedAtAction(nameof(GetById), new { id = createdFlexiNumber.Id }, createdFlexiNumber);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, FlexiNumber flexiNumber)
        {
            if (id != flexiNumber.Id)
            {
                return BadRequest();
            }

            var updatedFlexiNumber = await _service.UpdateAsync(flexiNumber);

            if (updatedFlexiNumber is null)
            {
                return NotFound();
            }

            return Ok(updatedFlexiNumber);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }


    }
}
