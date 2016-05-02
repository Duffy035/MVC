using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning6___MVC_Entity.Models
{
    public class Person
    {
        public Person()
        {

        }

        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; } //en nullable struct iom: ?
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public Address Address { get; set; }

    }
}
