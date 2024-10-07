using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }
        [HttpPost]
        [Route("CreateFlight")]
        public void CreateFlight(Flight flight)
        {
            _flightService.CreateFlight(flight);
        }
        [HttpPut]
        [Route("UpdateFlight")]
        public void UpdateFlight(Flight flight)
        {
            _flightService.UpdateFlight(flight);
        }
        [HttpDelete]
        [Route("DeleteFlight/{id}")]
        public void DeleteFlight(int id)
        {
            _flightService.DeleteFlight(id);
        }
        [HttpGet]
        [Route("FetchFlightByID/{id}")]
        public FlightDTO FetchFlightByID(int id)
        {
            return _flightService.FetchFlightByID(id);
        }
        [HttpGet]
        [Route("FetchFlightByFlightNumber/{flightNumber}")]
        public List<FlightDTO> FetchFlightByFlightNumber(string flightNumber)
        {
            return _flightService.FetchFlightByFlightNumber(flightNumber);

        }
        [HttpGet]
        public List<FlightDTO> FetchAllFlights()
        {
           return _flightService.FetchAllFlights();
        }
    }
}
