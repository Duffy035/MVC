using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Föreläsning6___övning.Models
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base("AirportsDB")
        {
            Database.SetInitializer<AirportContext>(new AirPortInitializer());
        }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Flight> Flights { get; set; }

    }

    public class AirPortInitializer : DropCreateDatabaseAlways<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            var airports = new List<Airport>()
            {
                new Airport()
                {
                    Achronym = "MIA",
                    Name = "Miami",
                    City = "Hawaii",
                    AirportId = 1,
                    Flights = new List<Flight>()
                    {
                        new Flight()
                        {
                            Arrival = DateTime.Now,
                            Departure = DateTime.Today,
                            Destination = "New York",
                            FlightId = 1,
                            FlightName = "JKL345",
                            ArrivalAirPort = new Airport() {Achronym = "NY", Name = "New York", City = "New York"}
                        }
                    }
                }
            };
            foreach (var airport in airports)
            {
                context.Airports.Add(airport);
            }
            context.SaveChanges();
        }
    }
}
