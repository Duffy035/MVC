using Microsoft.VisualStudio.TestTools.UnitTesting;
using OvningsTenta3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningsTenta3.Models.Tests
{
    [TestClass()]
    public class CalculateEnergyTests
    {
        [TestMethod()]
        public void CalculateEnergyTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateEnery_PosistiveValue()
        {
            //Arrange
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            //Act
            var actual = calculateEnergy.CalculateMass("2");
            var expeced = 179751035747363528;
            //Assert
            Assert.AreEqual(expeced, actual);
        }

        [TestMethod]
        public void CalculateEnergy_RightValue()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            var actual = calculateEnergy.CalculateMass("1");
            var expected = 89875517873681764;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateEnergy_Exception()
        {
            CalculateEnergy calculateEnergy = new CalculateEnergy();
            calculateEnergy.CalculateMass("");
        }
    }
}