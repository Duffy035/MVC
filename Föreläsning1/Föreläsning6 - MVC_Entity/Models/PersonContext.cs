using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Föreläsning6___MVC_Entity.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("Min MVC db")
        {
            Database.SetInitializer<PersonContext>(new PersonInitializer());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }

    public class PersonInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>()
            {
                new Person() { PersonId = 1, Name = "Roger Moore", DateOfBirth = new DateTime(1945,01,15), Height = 190.00M, Weight = 80.00M},
                new Person() { PersonId = 2, Name = "Pelle Moore", DateOfBirth = new DateTime(1985,01,15), Height = 160.00M, Weight = 95.00M},
                new Person() { PersonId = 3, Name = "Stina Moore", DateOfBirth = new DateTime(1965,01,15), Height = 164.00M, Weight = 68.00M}
            };
            foreach (var person in persons)
            {
                context.Persons.Add(person);
            }
            context.SaveChanges();


            var addresses = new List<Address>()
            {
                new Address() {AddressID = 1, City = "Helsingborg", Street = "Kungsgatan 12", Zip = "435 45"},
                new Address() {AddressID = 2, City = "Halmstad", Street = "Brogatan 11", Zip = "302 45"},
                new Address() {AddressID = 3, City = "Göteborg", Street = "Skeppargatan 32", Zip = "510 11"},
                new Address() {AddressID = 4, City = "Kungsbacka", Street = "Lummervägen 63", Zip = "120 01"}

            };
            foreach (var address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();

        }
    }
}