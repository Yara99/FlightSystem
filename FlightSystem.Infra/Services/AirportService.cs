using FlightSystem.Core.Data;
using FlightSystem.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Infra.Services
{
    public class AirportService
    {
        private readonly IAirportRepository _airportRepository;

        public AirportService(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }
        public void CreateAirport(Airport airport)
        {
            _airportRepository.CreateAirport(airport);
        }
        public void UpdateAirport(Airport airport)
        {
            _airportRepository.UpdateAirport(airport);
        }
        public void DeleteAirport(int id)
        {
            _airportRepository.DeleteAirport(id);
        }
        public Airport FetchAirportById(int id)
        {
            return _airportRepository.FetchAirportById(id);
        }
        public List<Airport> FetchAllAirports()
        {
           return _airportRepository.FetchAllAirports();
        }


    }
}
