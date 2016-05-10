using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Daisy
{
    public class CheckPerson
    {
        public string CheckNumber(string pnr) //Börjar alltid med att skapa en metod med exception
        {
            if (pnr != "130229")
            {
                return pnr;
            }

            else
            {
                return "";
            }

            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class CheckPersonTest
    {
        [Test]
        public void CheckNumberBeginning()
        {
            //Arrange
            CheckPerson person = new CheckPerson();

            //Act
            var actual = person.CheckNumber("20010101");
            var expected = "20010101";

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckForMiddle()
        {
            //Arrange
            CheckPerson middle = new CheckPerson();

            //Act
            var middleCheck = middle.CheckNumber("20080615");
            var expected = "20080615";

            //Assert
            Assert.That(middleCheck, Is.EqualTo(expected));
        }

        [Test]
        public void CheckForEnd()
        {
            //Arrange
            CheckPerson end = new CheckPerson();

            //Act
            var endCheck = end.CheckNumber("20161231");
            var expected = "20161231";

            //Assert
            Assert.That(endCheck, Is.EqualTo(expected));
        }

        //[Test]
        //public void CheckForMonth()
        //{
        //    //Arrange
        //    CheckPerson month = new CheckPerson();

        //    //Act
        //    var monthCheck = month.CheckNumber()


        //    //Assert
        //}

        [Test]
        public void CheckForLeapYear()
        {
            //Arrange
            CheckPerson leapYear = new CheckPerson();

            //Act
            var actual = leapYear.CheckNumber("20120229");
            var expected = "20120229";

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckForNotLeapYear()
        {
            //Arrange
            CheckPerson notLeapYear = new CheckPerson();

            //Act
            var actual = notLeapYear.CheckNumber("20120229");
            var expected = "";

            //Assert
            Assert.That(actual, Is.Null);
        }
    }
}
