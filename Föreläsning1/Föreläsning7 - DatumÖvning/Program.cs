using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Föreläsning7___DatumÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string DateTest(int year, int month, int day)
        {
            string personNummer = "";
            if (year <= 2016 && month <= 12 && day <= 31)
            {
                personNummer = $"{year.ToString("D4")}, {month.ToString("D2")}, {day.ToString("D2")}";
            }
            return personNummer;
        }

        [TestFixture]
        public class TestForDates
        {
            [Test]
            public void RightDate()
            {
                //Arrange
                var program = new Program();

                //Act
                var actual = program.DateTest(2015, 05, 09);
                var expected = "20160509";

                //Assert
                Assert.That(actual, Is.EqualTo(expected));

            }

        }

    }

}
