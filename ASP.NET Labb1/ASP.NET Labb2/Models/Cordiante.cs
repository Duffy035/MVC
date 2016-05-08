using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Labb2.Models
{
    public class Cordiante
    {
        public int ID { get; set; }

        public char sign { get; set; }

        public int XCordiante { get; set; }

        public int YCordiante { get; set; }

        public bool DisableButton { get; set; }

    }
}