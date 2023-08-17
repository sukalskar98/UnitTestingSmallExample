using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator
        }
        [TestMethod]
        public void ShouldAdd()
        {
            // Arrange
            int expected = 5;

            // Act
            var result = 
            // Assert
        }
    }
}
