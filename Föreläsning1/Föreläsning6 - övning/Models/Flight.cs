using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning6___övning.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public string Destination { get; set; }

        public Airport DepartureAirport { get; set; }
        public Airport ArrivalAirPort { get; set; }

    }
}