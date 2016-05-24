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
            var expected = calculateEnergy.CalculateMass(2);
            var actual = 8.987551787368176e+17;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateEnergy_WrongValue()
        {
            
        }
    }

}