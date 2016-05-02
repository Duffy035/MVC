using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning4___ModelControllerView___Razor.Models
{
    public class KungFuMaster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string KungFuStyle { get; set; }
        public string Level { get; set; }
    }
}