using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//1. Skapa ett tomt MVC-projekt
//2. Lägg till Entity via Nugets


namespace TestMedEntity__Globalasax.Models
{
    public class Student
    {
        public int StudnetId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; } //Nullable struct
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int AddressId { get; set; }

        public Address Adress { get; set; }
    }
}