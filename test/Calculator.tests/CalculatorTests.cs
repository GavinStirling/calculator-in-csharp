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

    [Fact]
    public void checkPower()
    {
        // Arrange
        Operation power = new Power(2, 2);

        // Act
        double actual = power.calculate();

        // Assert
        Assert.Equal(4, actual);
    }

    [Fact]
    public void checkSquareRoot()
    {
        // Arrange
        Operation sqrt = new SquareRoot(81,0);

        // Act
        double actual = sqrt.calculate();

        // Assert
        Assert.Equal(9, actual);
    }
}