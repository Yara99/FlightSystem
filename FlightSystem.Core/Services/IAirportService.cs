using FlightSystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.Services
{
    public interface IAirportService
    {
        public void CreateAirport(Airport airport);
        public void UpdateAirport(Airport airport);
        public void DeleteAirport(int id);
        public Airport FetchAirportById(int id);
        public List<Airport> FetchAllAirports();
    }
}
