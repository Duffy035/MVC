using Microsoft.VisualStudio.TestTools.UnitTesting;
using Föreläsning9___Reviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning9___Reviewer.Models.Tests
{
    [TestClass()]
    public class ReviewTests
    {
        const int NumberOfRatingsToUse = 10;

        [TestMethod()]
        public void TempTest_AverageForOneReview()
        {
            var myKiosk = BuildKiosk(8); 
            var rater = new KioskRater(myKiosk);

            var result = rater.ComputeOverallRate(NumberOfRatingsToUse); //Ska beräkna de senaste ratings vi har. 10 är antalet ratings
            var actual = result.Rating;
            var expected = 8;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TempTest_ForTwoReviews()
        {

            //Nedan: Behövs inte då vi har refaktoriserat

            //var kiosk = new Kiosk();
            //kiosk.Reviews = new List<Review>();
            //kiosk.Reviews.Add(new Review() { Rating = 4 });
            //kiosk.Reviews.Add(new Review() { Rating = 6 });
            //var rater = new KioskRater(kiosk);

            //var rater = BuildKiosk(new int[] { 4, 6 });  
            var myKiosk = BuildKiosk(4, 6);  //samma som ovan
            var rater = new KioskRater(myKiosk);
            
            var result = rater.ComputeOverallRate(NumberOfRatingsToUse); //Ska beräkna de senaste ratings vi har. 10 är antalet ratings
            var actual = result.Rating;
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TempTest_ComputedTwoRatings()
        {
            var data = BuildKiosk(3,9);
            var rater = new KioskRater(data);

            var actual = rater.ComputeWeightedRate(NumberOfRatingsToUse);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        private Kiosk BuildKiosk(params int[] ratings)//'params' är parameterar som gör att vi kan skicka in komma-separerade parameterar - hur många som helst
        {
            var result = new Kiosk();
            result.Reviews = ratings.Select(r => new Review { Rating = r }).ToList();
            return result;
        }

    }
}