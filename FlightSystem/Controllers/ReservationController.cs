using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
       private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpPost]
        [Route("CreateReservation")]
        public void CreateReservation(Reservation reservation)
        {
            _reservationService.CreateReservation(reservation);
        }
        [HttpGet]
        [Route("FetchReservationById/{id}")]
        public ReservationDTO FetchReservationById(int id)
        {
            return _reservationService.FetchReservationById(id);
        }
        [HttpGet]
        public List<ReservationDTO> FetchAllReservation()
        {
            return _reservationService.FetchAllReservation();
        }
        [HttpGet]
        [Route("FetchReservationByUserID/{userId}")]
        public List<ReservationDTO> FetchReservationByUserID(int userId)
        {
            return _reservationService.FetchReservationByUserID(userId);
        }

        [HttpPost]
        [Route("SearchReservation")]
        public List<SearchReservationDTO> SearchReservation(SearchReservationDTO obj)
        {
            return _reservationService.SearchReservation(obj);
        }

     


        [HttpGet]
        [Route("entity-counts")]
        public CountDTO GetEntityCounts() 
        { 
            return _reservationService.GetEntityCounts(); 
        }


        [HttpGet("totalBenefits")]
        public IActionResult CalculateTotalBenefits(DateTime startDate, DateTime endDate)
        {
            var totalBenefits = _reservationService.CalculateTotalBenefits(startDate, endDate);
            return Ok(totalBenefits);
        }



    }
}
