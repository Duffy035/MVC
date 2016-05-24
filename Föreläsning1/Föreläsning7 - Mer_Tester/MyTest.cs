﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework; //Denna måste vi ha - bör läggas till per default när vi kör in NUnit via nugets

namespace Föreläsning7___Mer_Tester
{
    [TestFixture]
    public class MyTest
    {
        [Test] //alla testklasser ska vara 'void'
        public void AddCorrectCalculation()
        {
            //Arrange
            var expected = 5;
            //Act
            var actual = Goofy.Add(3, 2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
