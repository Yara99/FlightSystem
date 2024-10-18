using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Core.DTO
{
    public class FlightForSearchDTO
    {
        public DateTime? Departuredate { get; set; }
        public decimal? DeparturePlaceId { get; set; }
        public decimal? DestenationPlaceId { get; set; }
        public decimal? DegreenameId { get; set; }


    }
}
