using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.DTO
{
    public class InvoiceDTO
    {
        public string AirlineName { get; set; }
        public string DepartureIataCode { get; set; }
        public string DestinationIataCode { get; set; }
        public string DegreeName { get; set; }
        public string DepartureDate { get; set; }
        public string DestinationDate { get; set; }
        public string DepartureAirportName { get; set; }
        public string DestinationAirportName { get; set; }
        public string FlightNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}
