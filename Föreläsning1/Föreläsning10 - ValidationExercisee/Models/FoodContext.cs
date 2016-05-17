using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Föreläsning10___ValidationExercisee.Models
{
    public class FoodContext : DbContext
    {
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<CakeReview> Reviews { get; set; }

        public FoodContext() : base("CaakesDB")
        {

        }

    }
}