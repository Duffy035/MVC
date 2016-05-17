using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning8___TDD_Retro
{
    public class TimeConverter
    {
        public string Time(string time, string unit)
        {
            double convertTime = int.Parse(time);

            if (convertTime > 0 && unit == "minutes")
            {
                var minutes = convertTime*60;
                return minutes.ToString();
            }
            else if (convertTime > 0 && unit == "seconds")
            {
                var seconds = convertTime*3600;
                return seconds.ToString();
            }
            else if (convertTime == 0)
            {
                throw new Exception("You must provide amount of hours to convert, and only use numbers");
            }

            string trimmer = time.Trim();

            return trimmer;
            return time;
        }
    }
}
