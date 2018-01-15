using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreeneCodeChallenge;
using GreeneCodeChallenge.Controllers;
using GreeneCodeChallenge.Models;

namespace GreeneCodeChallenge.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
       
         [TestMethod]
        public void CalculateOhmCalculator()
        {
            // Arrange
            string bandAColor = "Yellow";
            string bandBColor = "Violet";
            string bandCColor = "Red";
            string bandDColor = "Red";
            double value = 4700;
            double tolerance = 2;
            var calculator = new OhmCalculator();

            // Act
            var result = calculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);

            // Assert
            Assert.AreEqual(result.OhmValue, value);
            Assert.AreEqual(result.Tolerance, tolerance);

        }
    }
}
