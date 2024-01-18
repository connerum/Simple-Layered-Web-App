using Xunit;
using FactorialLibrary;

public class FactorialCalculatorTests
{
    [Fact]
    public void Calculate_FactorialOf5_Returns120()
    {
        // Arrange
        var calculator = new FactorialCalculator();

        // Act
        var result = calculator.Calculate(5);

        // Assert
        Assert.Equal(120, result);
    }

    [Fact]
    public void Calculate_FactorialOf0_Returns1()
    {
        // Arrange
        var calculator = new FactorialCalculator();

        // Act
        var result = calculator.Calculate(0);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Calculate_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var calculator = new FactorialCalculator();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
    }
}
