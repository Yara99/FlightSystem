using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Services
{
    public interface IReservationService
    {
        public void CreateReservation(Reservation reservation);
        public ReservationDTO FetchReservationById(int id);
        public List<ReservationDTO> FetchAllReservation();
        public ReservationDTO FetchReservationByUserID(int userId);

        public List<SearchReservationDTO> SearchReservation(SearchReservationDTO obj);
    }
}
