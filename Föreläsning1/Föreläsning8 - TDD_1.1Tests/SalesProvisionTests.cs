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
    public class SalesProvisionTests
    {
        [TestMethod()]
        public void SalaryTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void Salary_Correct()
        {
            //Arrange
            SalesProvision salesProvision = new SalesProvision();

            //Act
            var actual = salesProvision.Salary(10000);
            var expected = 900;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Salary_None()
        {
            //Arrange
            SalesProvision salesProvision = new SalesProvision();

            //Act
            var actual = salesProvision.Salary(0);
            var expected = 15000;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Assert för exception, Asserten ligger då här
        [ExpectedException(typeof(Exception))]
        public void Salary_Wrong()
        {
            //Arrange
            SalesProvision salesProvision = new SalesProvision();

            //Act
            salesProvision.Salary(-100);
        }
    }
}