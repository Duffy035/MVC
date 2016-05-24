using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMedEntity__Globalasax.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public IList<Student> Students { get; set; }
    }
}