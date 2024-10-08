using FlightSystem.Core.Data;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        [Route("CreateCity")]
        public void CreateCity(City city)
        {
            _cityService.CreateCity(city);
        }

        [HttpPut]
        [Route("UpdateCity")]
        public void UpdateCity(City city)
        {
            _cityService.UpdateCity(city);
        }

        [HttpDelete]
        [Route("DeleteCity/{id}")]
        public void DeleteCity(int id)
        {
            _cityService.DeleteCity(id);
        }

        [HttpGet]
        [Route("GetCityById/{id}")]
        public List<City> GetCityById(int id)
        {
            return _cityService.GetCityById(id);

        }

        [HttpGet]
        [Route("GetAllCities")]
        public List<City> GetAllCities()
        {
            return _cityService.GetAllCities();

        }
        [HttpGet]
        [Route("GetCitiesByCountry")]
        List<City> GetCitiesByCountry(int countryId)
        {
            return _cityService.GetCitiesByCountry(countryId);

        }
    }
}
