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
        [HttpGet("{id:int}", Name = "GetBy")]
        public IActionResult GetBy(int id)
        {
            Flight flight = service.FlightService.GetFlightBy(id, false);
            if (flight == null)
            {
                return NotFound();
            }
            return Ok(flight);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Flight flight)
        {
            if (flight == null)
            {
                return BadRequest("Object is null");
            }
            var entity = service.FlightService.CreateFlight(flight);
            return CreatedAtRoute("GetBy", new { id = entity.Id }, entity);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.FlightService.DeleteFlight(id, false);
            return NoContent();
        }
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Flight flight)
        {
            if (flight == null)
            {
                return BadRequest("Flight is null");
            }
            service.FlightService.UpdateFlight(id, flight);
            return NoContent();
        }
    }
}
