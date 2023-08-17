using Moq;
using UnitTestingSmallExample;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTestMSTest
    {
        private readonly Mock<ICalculatorService> mockService;

        private readonly Calculator calculator;

        public CalculatorTestMSTest()
        {
            mockService = new Mock<ICalculatorService>();
            calculator = new Calculator(mockService.Object);
        }

        [TestMethod]
        public void ShouldAddTwoIntegers()
        {
            // Arrange
            var expected = 30;

            // Act
            var result = calculator.Add(20, 10);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldSubtract()
        {
            // Arrange
            var expected = 10;

            // Act
            var result = calculator.Subtract(20, 10);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldModulus()
        {
            // Arrange
            var expected = 0;
            this.mockService.Setup(x => x.Modulus(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            // Act
            var result = calculator.Modulus(20, 10);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}