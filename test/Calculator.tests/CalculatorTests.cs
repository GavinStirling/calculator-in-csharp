namespace Calculator.tests;

public class CalculatorTests
{
    [Fact]
    public void checkAddition()
    {
        // Arrange
        Operation add = new Addition(7,5);

        // Act
        double actual = add.calculate();

        // Assert
        Assert.Equal(12, actual);
    }
    
    [Fact]
    public void checkSubtraction()
    {
        // Arrange
        Operation minus = new Subtraction(7, 5);

        // Act
        double actual = minus.calculate();

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void checkDivision()
    {
        // Arrange
        Operation divide = new Division(12, 4);

        // Act
        double actual = divide.calculate();

        // Assert
        Assert.Equal(3, actual);
    }

    [Fact]
    public void checkMultiplication()
    {
        // Arrange
        Operation multiply = new Multiplication(7, 5);

        // Act
        double actual = multiply.calculate();

        // Assert
        Assert.Equal(35, actual);
    }
}