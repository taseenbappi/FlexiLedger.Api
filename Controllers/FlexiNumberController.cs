using FlexiLedger.Api.Infrastructure;
using FlexiLedger.Api.Services;
using Microsoft.AspNetCore.Http;
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
    }
}
