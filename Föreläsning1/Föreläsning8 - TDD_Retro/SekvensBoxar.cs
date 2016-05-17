using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning8___TDD_Retro
{
    public class SekvensBoxar
    {
        public double Square(double number)
        {
            //double result = number*number;
            //double result = Math.Sqrt(number);
            var result = Math.Pow(number,2D);
            return result;
        }
    }
}
