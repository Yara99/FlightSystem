﻿using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _airportService;
        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }
        [HttpPost]
        [Route("CreateAirport")]
        public void CreateAirport(Airport airport)
        {
            _airportService.CreateAirport(airport);
        }
        [HttpPut]
        [Route("UpdateAirport")]
        public void UpdateAirport(Airport airport)
        {
            _airportService.UpdateAirport(airport);
        }
        [HttpDelete]
        [Route("DeleteAirport/{id}")]
        public void DeleteAirport(int id)
        {
            _airportService.DeleteAirport(id);
        }
        [HttpGet]
        [Route("FetchAirportById/{id}")]
        public AirportDTO FetchAirportById(int id)
        {
            return _airportService.FetchAirportById(id);
        }
        [HttpGet]
        public List<AirportDTO> FetchAllAirports()
        {
            return _airportService.FetchAllAirports();
        }


    }
}
