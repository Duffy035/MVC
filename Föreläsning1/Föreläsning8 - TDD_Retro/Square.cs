using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning8___TDD_Retro
{
   public class Square
    {
       public double GetSquare(string number)
       {
           var t = int.Parse(number);
           return Math.Pow(t, 2);

           //return 9999; - Kan göra såhär också - blir vårt felmeddelande
           //throw new NotImplementedException();
       }

       public string Test()
       {
           throw new NotImplementedException();
       }
    }
}

