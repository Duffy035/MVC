using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestMedEntity__Globalasax.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("TestMedEntity__Globalasax")
        {
            Database.SetInitializer<SchoolContext>(new SchoolInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }

    public class SchoolInitilaizer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    StudnetId = 1,
                    StudentName = "Maja Lindkvist",
                    DateOfBirth = new DateTime(1983, 5, 2, 8, 30, 52),
                    Height = 170,
                    Weight = 88
                },
                new Student()
                {
                    StudnetId = 1,
                    StudentName = "Markus Magnusson",
                    DateOfBirth = new DateTime(1993, 5, 2, 8, 30, 52),
                    Height = 186,
                    Weight = 76
                },
                new Student()
                {
                    StudnetId = 1,
                    StudentName = "Peter Magnusson",
                    DateOfBirth = new DateTime(1983, 5, 2, 8, 30, 52),
                    Height = 185,
                    Weight = 98
                }
            };

            foreach (var student in students)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();

            //Lägger till addresserna:

            var addresses = new List<Address>()
            {
                new Address() {AddressId = 1, Street = "Kungsgatan", City = "Helsingborg", Zip = "123 22"},
                new Address() {AddressId = 1, Street = "Kungsgatan", City = "Helsingborg", Zip = "123 22"},
                new Address() {AddressId = 1, Street = "Kungsgatan", City = "Helsingborg", Zip = "123 22"}

            };

            foreach (var address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();
        }
    }
}