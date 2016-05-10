using System;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace Föreläsning7___Mer_Tester_Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]

        public void AddCorrectCalculation()
        {
            //Arrange
            var expected = 5;
            //Act
            var acctual = Goofy.Add(3, 2);
            //Assert
            Assert.AreEqual(expected, acctual);
        }
    }
}
