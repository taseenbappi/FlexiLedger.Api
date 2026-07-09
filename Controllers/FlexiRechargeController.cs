using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Models.DTOs;
using FlexiLedger.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlexiLedger.Api.Controllers
{
    [Route("api/flexi-recharge")]
    [ApiController]
    public class FlexiRechargeController(IFlexiRechargeService flexiRechargeService) : ControllerBase
    {
        private readonly IFlexiRechargeService _flexiRechargeService = flexiRechargeService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _flexiRechargeService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _flexiRechargeService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] FlexiRechargeRequestDto flexiRecharge)
        {
            var result = await _flexiRechargeService.AddAsync(flexiRecharge);
            return CreatedAtAction(nameof(GetById), new { id = result.FlexiNumberId }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] FlexiRecharge flexiRecharge)
        {
            if (id != flexiRecharge.Id)
            {
                return BadRequest();
            }
            var result = await _flexiRechargeService.UpdateAsync(flexiRecharge);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _flexiRechargeService.DeleteAsync(id);
            return NoContent();
        }
    }
}
