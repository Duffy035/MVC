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
    public class SquareTests
    {
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetSquareNumberTest_TextInString()
        {
            Square sq = new Square();
            sq.GetSquare("fem");
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetSquareNumberTest_NumberMultiplyNumberFault()
        {
            Square sq = new Square();
            sq.GetSquare("2*2");
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetSquareNumberTest_EmptyString()
        {
            Square sq = new Square();
            sq.GetSquare("");
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetSquareNumberTest_NumberTextFault()
        {
            Square sq = new Square();
            sq.GetSquare("7d");
        }
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetSquareNumberTest_NullFault()
        {
            Square sq = new Square();
            sq.GetSquare(null);
        }

        [TestMethod]
        public void GetSquareNumberTest_Correct()
        {
            var sq = new Square();
            var actual = sq.GetSquare("0.8");
            var expected = 0.64;
            Assert.AreEqual(actual, expected, "0.8 test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_CorrectWithComma()
        {
            var sq = new Square();
            var actual = sq.GetSquare("0,9");
            var expected = 0.81;
            Assert.AreEqual(actual, expected, "0,9 test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_SpaceNumberCorrect()
        {
            var sq = new Square();
            var actual = sq.GetSquare(" 9");
            var expected = 81;
            Assert.AreEqual(actual, expected, "space + number test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_NumberSpaceCorrect()
        {
            var sq = new Square();
            var actual = sq.GetSquare("9 ");
            var expected = 81;
            Assert.AreEqual(actual, expected, "number + space test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_MillionWithSpaceCorrect()
        {
            var sq = new Square();
            var actual = sq.GetSquare("1 000");
            var expected = 1000000;
            Assert.AreEqual(actual, expected, "Million + space test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_XerroCorrect()
        {
            var sq = new Square();
            var actual = sq.GetSquare("0");
            var expected = 0;
            Assert.AreEqual(actual, expected, "Zero test is Correct");
        }
        [TestMethod]
        public void GetSquareNumberTest_NegativeNumberCorrect()
        {
            var sq = new Square();
            var actual = sq.GetSquare("-8");
            var expected = 64;
            Assert.AreEqual(actual, expected, "Negative number test is Correct");
        }
        /*
         fem
         0.8
         0,9
         2*2
         7  - hoppar över redundant test
         ""
         _9
         77g
         8_
         1_000_000
         0
         null
         -8
         12345678901234567890
         */
    }
}