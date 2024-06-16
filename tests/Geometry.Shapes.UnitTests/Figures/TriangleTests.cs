using Geometry.Shapes.Figures;

namespace Geometry.Shapes.UnitTests.Figures;

public class TriangleTests
{
    [Fact]
    public void Triangle_EnterCorrectSides_TriangleCreatedSuccessfully()
    {
        //Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        
        //Act
        var exception = Record.Exception(() => new Triangle(sideA, sideB, sideC));
    
        //Assert 
        Assert.Null(exception);
    }

    [Fact]
    public void Triangle_EnterLessThanZeroSide_ThrowArgumentExceptionWithCorrectMessage()
    {
        //Arrange
        double sideA = 3;
        double sideB = -2;
        double sideC = 5;
        
        //Act
        Action act = () => new Triangle(sideA, sideB, sideC);
        
        //Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
        
        Assert.Equal("Стороны треугольника должны быть строго положительными.", exception.Message);
    }
    
    [Fact]
    public void Triangle_EnterZeroSide_ThrowArgumentExceptionWithCorrectMessage()
    {
        //Arrange
        double sideA = 3;
        double sideB = 0;
        double sideC = 5;
        
        //Act
        Action act = () => new Triangle(sideA, sideB, sideC);
        
        //Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
        
        Assert.Equal("Стороны треугольника должны быть строго положительными.", exception.Message);
    }
    
    [Fact]
    public void Triangle_EnterIncorrectSidesToCreateUnrealTriangle_ThrowArgumentExceptionWithCorrectMessage()
    {
        //Arrange
        double sideA = 3;
        double sideB = 1;
        double sideC = 4;
        
        //Act
        Action act = () => new Triangle(sideA, sideB, sideC);
        
        //Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
        
        Assert.Equal("Стороны треугольника не соответствуют неравенству треугольника.", exception.Message);
    }
    
    [Fact]
    public void CalculateArea_AreaCalculation_ReturnCalculatedArea()
    {
        //Arrange
        double sideA = 3;
        double sideB = 6;
        double sideC = 4;
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        
        double p = (sideA + sideB + sideC) / 2;
        double correctResult = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        
        //Act
        var result = triangle.CalculateArea();
        
        //Assert
        Assert.Equal(correctResult, result);
    }
    
    [Fact]
    public void IsRightAngled_EnterRightAngleSides_ReturnTrue()
    {
        //Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        bool correctResult = true;
        
        //Act
        var result = triangle.IsRightAngled();
        
        //Assert
        Assert.Equal(correctResult, result);
    }
    
    [Fact]
    public void IsRightAngled_EnterNotRightAngleSides_ReturnFalse()
    {
        //Arrange
        double sideA = 3;
        double sideB = 6;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        bool correctResult = false;
        
        //Act
        var result = triangle.IsRightAngled();
        
        //Assert
        Assert.Equal(correctResult, result);
    }
}