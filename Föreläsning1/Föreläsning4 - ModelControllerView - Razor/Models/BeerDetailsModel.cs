using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning4___ModelControllerView___Razor.Models
{
    public class BeerDetailsModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AlcoholVolume { get; set; }

    }
}