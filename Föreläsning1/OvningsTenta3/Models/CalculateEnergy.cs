using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OvningsTenta3.Models
{
    public class CalculateEnergy
    {
        public double CalculateMass(string mass)
        {
            double parsedMass; //= double.Parse(mass);

            string rightValue = mass.Replace(".", ",");
            if (!double.TryParse(rightValue, out parsedMass))
            {
                throw new Exception("Det blev fel, försök igen");
            }

            const double speedOfLight = 299792458;
            var energy = parsedMass*Math.Pow(speedOfLight, 2);
            return energy;

            //throw new NullReferenceException("Ajabaja, tester först");
        }
    }
}