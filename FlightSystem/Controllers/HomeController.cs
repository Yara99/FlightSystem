using FlightSystem.Core.Data;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        [HttpGet]
        public List<Home> GetAll()
        {
            return _homeService.GetAll();
        }

        [HttpPut]
        [Route("UpdateHome")]
        public void UpdateHome(Home home)
        {
            _homeService.UpdateHome(home);
        }

    }
}
