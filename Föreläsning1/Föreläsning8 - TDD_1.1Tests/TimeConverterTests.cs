using Microsoft.VisualStudio.TestTools.UnitTesting;
using Föreläsning8___TDD_Retro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning8___TDD_Retro.Tests
{
    [TestClass()]
    public class TimeConverterTests
    {
        [TestMethod()]
        public void TimeTest_CorrectForMinutes()
        {
            //public string Time(string time, string unit) - min metod från TimeConverter
            var time = new TimeConverter();
            var actual = time.Time("2","minutes");
            var expected = "120";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TimeTest_CorrectForSeconds()
        {
            var time = new TimeConverter();
            var actual = time.Time("2","seconds");
            var expected = "7200";

            Assert.AreEqual(actual, expected);
        }

        //TODO - Fixa logik för TimeTest_ExceptionWithString
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TimeTest_ExceptionWithString()
        {
            var time = new TimeConverter();
            time.Time("två","minutes");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TimeTest_ExceptionNoHoursTyped()
        {
            var time = new TimeConverter();
            time.Time("0", "minutes");
        }

        [TestMethod]
        public void TimeTest_TypedNumberStartingWithSpace()
        {
            var time = new TimeConverter();
            var actual = time.Time(" 4", "minutes");
            var expected = "240";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TimeTest_TypedNumberEndingWithSpace()
        {
            var time = new TimeConverter();
            var actual = time.Time("4 ", "minutes");
            var expected = "240";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TimeTest_NullValueMinutes()
        {
            var time = new TimeConverter();
            time.Time(null, "minutes");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TimeTest_NullValueSeconds()
        {
            var time = new TimeConverter();
            time.Time(null, "seconds");
        }

        //sextio
        //360
        //_sextio
        //sextio_
        //null
        //_360
        //360_
        //3_60
        //36_0



    }
}