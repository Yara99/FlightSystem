using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.DTO
{
    public class ReturnFlightSearch
    {
        public string? Airlinename { get; set; }
        public string? Airlineimage { get; set; }
        public string? DepartureIatacode { get; set; }
        public string? DestinationIatacode { get; set; }
        public string? Degreename { get; set; }
        public string? Price { get; set; }
        public DateTime? Departuredate { get; set; }
        public DateTime? Destinationdate { get; set; }
        public decimal DegreeId { get; set; }
        public string? DepartureCityName { get; set; }
        public string? DepartureCountryName { get; set; }
        public string? DestinationCityName { get; set; }
        public string? DestinationCountryName { get; set; }





    }
}
