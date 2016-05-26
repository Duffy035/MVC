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
            Database.SetInitializer(new FoodContextInitializer());
        }

    }

    internal class FoodContextInitializer : DropCreateDatabaseAlways<FoodContext>
    {
        protected override void Seed(FoodContext context)
        {
            var cakes = new Cake()
            {
                CakeID = 1, Name = "Mumma", CookingTime = 60, Ingredients = "sugar, flour, milk, egg, looooove", Summary = "Yummy!", Instructions = "Just do it!", Reviews = new List<CakeReview>()
                {
                    new CakeReview() { CakeID = 1, Title = "Best cake ever!", CakeReviewID = 1, Score = 10, Summary = "Loved it, it was amazing"}
                }
            };
            context.Cakes.Add(cakes);
            context.SaveChanges();
        }
    }
}