using Entities.Models;

using Microsoft.AspNetCore.Mvc;

using Service.Contracts;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IServiceManager service;

        public FlightsController(IServiceManager service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var flights = service.FlightService.GetAll(false);
                return Ok(flights);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Flight flight = service.FlightService.GetFlightBy(id, false);
            return Ok(flight);
        }
    }
}
