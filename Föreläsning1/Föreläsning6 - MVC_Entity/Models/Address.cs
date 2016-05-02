using System.Collections;
using System.Collections.Generic;

namespace Föreläsning6___MVC_Entity.Models
{
    public class Address
    {
        public Address()
        {
            
        }
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public IList<Person> Persons { get; set; }
    }
}