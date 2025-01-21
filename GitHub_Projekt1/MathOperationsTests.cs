using MathLibrary;
using Xunit;

namespace GitHub_Projekt1
{
    public class MathOperationsTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = MathOperations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ShouldReturnIncorrectSum()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int expected = 9;

            // Act
            int result = MathOperations.Add(a, b);

            // Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expected = 5;

            // Act
            int result = MathOperations.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int expected = 12;

            // Act
            int result = MathOperations.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;
            double expected = 5.0;

            // Act
            double result = MathOperations.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ShouldThrowException_WhenDivisorIsZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => MathOperations.Divide(a, b));
        }
    }
}
