using System;
using System.Linq;

namespace Föreläsning9___Reviewer.Models.Tests
{
    internal class KioskRater
    {
        private Kiosk _kiosk;

        public KioskRater(Kiosk kiosk)
        {
            this._kiosk = kiosk;
        }

        public RateResult ComputeOverallRate(int numberOfRatingsToUse)
        {
            var result = new RateResult();  //Fulkod... vi hårdkodar.
            result.Rating = (int)_kiosk.Reviews.Average(r => r.Rating);
            return result;
            //throw new NotImplementedException();
        }

        public RateResult ComputeWeightedRate(int numberOfRatingsToUse)
        {
            var result = new RateResult();
            var reviews = _kiosk.Reviews.ToList();
            var counter = 0;
            var total = 0;
            for (int i = 0; i < reviews.Count; i++)
            {
                if (i < reviews.Count / 2)
                {
                    counter += 2;
                    total += reviews[i].Rating * 2;
                }
                else
                {
                    counter += 1;
                    total += reviews[i].Rating;
                }
            }
            result.Rating = total/counter;
            return result;
        }
    }
}