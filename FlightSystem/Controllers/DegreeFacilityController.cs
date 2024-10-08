﻿using FlightSystem.Core.Data;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegreeFacilityController : ControllerBase
    {
        private readonly IDegreeFacilityService _degreefacilityService;
        public DegreeFacilityController(IDegreeFacilityService degreefacilityService)
        {
            _degreefacilityService = degreefacilityService;
        }

        [HttpPost]
        [Route("CreateDegreeFacility")]
        public void CreateDegreeFacility(DegreeFacility degreeFacility)
        {
            _degreefacilityService.CreateDegreeFacility(degreeFacility);
        }

        [HttpPut]
        [Route("UpdateDegreeFacility")]
        public void UpdateDegreeFacility(DegreeFacility degreeFacility)
        {
            _degreefacilityService.UpdateDegreeFacility(degreeFacility);
        }

        [HttpDelete]
        [Route("DeleteDegreeFacility/{id}")]
        public void DeleteDegreeFacility(int id)
        {
            _degreefacilityService.DeleteDegreeFacility(id);
        }

    }
}