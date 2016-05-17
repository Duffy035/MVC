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
    public class ValueConverterTests
    {
        //[TestMethod()]
        //public void ValueTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod]
        public void ValueTest_PositiveNumber()
        {
            //Arrange
            var valueTest = new ValueConverter();

            //Act
            var actual = valueTest.Value("5","5","5");
            var expected = new KeyValuePair<double, double>();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValueTest_NegativeNumber()
        {
            var valueTest = new ValueConverter();
            var actual = valueTest.Value("-5","-5","-5");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValueTest_DecimalNumber()
        {
            var valueTest = new ValueConverter();

            var actual = valueTest.Value("5.5","5.5","5.5");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValue_TypedWithCharacter()
        {
            var valueTest = new ValueConverter();

            var actual = valueTest.Value("fem","fem","fem");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValue_ComboCharactersStartingWithNumber()
        {
            var valueTest = new ValueConverter();
            var actual = valueTest.Value("5t","5t","5t");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValue_ComboCharactersStartingWithCharacter()
        {
            var valueTest = new ValueConverter();

            var actual = valueTest.Value("t5","t5","t5");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValue_StartingWithSpace()
        {
            var valueTest = new ValueConverter();

            var actual = valueTest.Value(" 5"," 5"," 5");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValue_EndingWithSpace()
        {
            var valueTest = new ValueConverter();

            var actual = valueTest.Value("5 ","5 ","5 ");
            var expected = new KeyValuePair<double, double>();

            Assert.AreEqual(expected, actual);
        }

        //5,5,5
        //-5,-5,-5
        //5.5, 5.5, 5.5
        //fem, fem, fem
        //5t, 5t, 5t
        //t5, t5, t5
        //_5, _5, _5
        //5_, 5_, 5_

    }
}