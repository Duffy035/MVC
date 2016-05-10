using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Föreläsning7___Tester;
using Föreläsning7___Tester.Controllers; //Som sagt, denna måste vi ha tillgågn till

namespace Föreläsning7___Tester.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {

            // Arrange - sätter upp förutsättninarna för att genomföra testen. Vi har en HomController i andra projektet, den behöver vi via ett using. 
            HomeController controller = new HomeController(); //Gör en instans av den RIKTIGA controller-klassen

            // Act - I denna ska man utföra själva arbetet - anropa själva metoden
            ViewResult result = controller.Index() as ViewResult;  //Detta är ett resutlat från vyn.

            // Assert - hävdar att det sak stämma, ananrs har vi misslyckats skapa en vy
            Assert.IsNotNull(result);
            //Assert.IsNotNull(result);  // Detta hade get fel
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
