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
    public class SekvensBoxarTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void SquareCorrect()
        {
            //Arrange
            SekvensBoxar squareCorrect = new SekvensBoxar();

            //Act
            var actual = squareCorrect.Square(2);
            var expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareZero()
        {
            //Arrange
            SekvensBoxar squareZero = new SekvensBoxar();

            //Act
            var actual = squareZero.Square(0);
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareNegative()
        {
            //Arrange
            SekvensBoxar squareNegative = new SekvensBoxar();

            //Act
            var actual = squareNegative.Square(-1);
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}