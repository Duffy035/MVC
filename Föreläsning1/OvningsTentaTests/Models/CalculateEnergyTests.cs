using Microsoft.VisualStudio.TestTools.UnitTesting;
using OvningsTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace OvningsTenta.Models.Tests
{
    [TestClass()]
    public class CalculateEnergyTests
    {
        [TestMethod()]
        public void CalculateMassTest()
        {
            Assert.Fail();
        }

        [Test]
        public void CalculateEnery_RightValue()
        {
            //Arrange
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            //Act
            var expected = calculateEnergy.CalculateMass("5");
            var actual = 4.493775893684088e+17;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateEnergy_NegativeValue()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();

            var expected = calculateEnergy.CalculateMassNegative("-5");
            var actual = -4.4937758936840883E+17d;
            Assert.AreEqual(expected, actual);
        }

        public void CalculateEnergy_UsedStringvalue()
        {
            CalculateEnergy calculateEnergyWithString = new CalculateEnergy();

            var expected = calculateEnergyWithString.CalculateMass("5g");
            var actual = 4.493775893684088e+17;
            Assert.AreEqual(expected, actual);
        }

    }
}