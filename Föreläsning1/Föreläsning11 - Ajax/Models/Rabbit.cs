using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning11___Ajax.Models
{
    public class Rabbit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AngerLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Grudge> Grudges { get; set; }
    }
}