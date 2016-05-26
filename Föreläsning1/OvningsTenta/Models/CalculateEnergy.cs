using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OvningsTenta.Models
{
    public class CalculateEnergy
    {
        public double CalculateMass(string mass)
        {
            double parsedMass;//= double.Parse(mass);
            string rightvalue = mass.Replace(",", ".");
            if (!double.TryParse(rightvalue, out parsedMass))
            {
                throw new Exception("Fel, använd inte bokstäver!");
            }

            double speedOfLight = 299792458;
            var energy = parsedMass*(Math.Pow(speedOfLight, 2));
            return energy;
        }
    }
}   