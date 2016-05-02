using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning6___övning.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Achronym { get; set; }

        public List<Flight> Flights { get; set; } 
    
    }
}