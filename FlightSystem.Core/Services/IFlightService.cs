using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Services
{
    public interface IFlightService
    {
        public void CreateFlight(Flight flight);
        public void UpdateFlight(Flight flight);
        public void DeleteFlight(int id);
        public FlightDTO FetchFlightByID(int id);
        public List<FlightDTO> FetchFlightByFlightNumber(string flightNumber);
    }
}
