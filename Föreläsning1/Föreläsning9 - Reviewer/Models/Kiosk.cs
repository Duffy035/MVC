using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning9___Reviewer.Models
{
    public class Kiosk
    {
        public virtual int ID { get; set; } //virtual för att kunna override:a
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}