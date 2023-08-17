using Moq;
using Xunit;

namespace UnitTestingSmallExample
{
    public class CalculatorTestXUnit
    {
        private readonly Mock<ICalculatorService> mockService;
        private readonly Calculator calculator;
        public CalculatorTestXUnit()
        {
            mockService = new Mock<ICalculatorService>();
            calculator = new Calculator(mockService.Object);
        }

        [Fact]
        public void ShouldModulus()
        {
            // Arrange
            var expected = 2;
            this.mockService.Setup(x => x.Modulus(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            // Act
            var result = calculator.Modulus(12, 10);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(12,10)]
        public void ShouldModulus2(int a, int b)
        {
            // Arrange
            var expected = 2;
            this.mockService.Setup(x => x.Modulus(It.IsAny<int>(), It.IsAny<int>())).Returns(expected);

            // Act
            var result = calculator.Modulus(a, b);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
