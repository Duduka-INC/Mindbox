using Geometry.Shapes.Figures;

namespace Geometry.Shapes.UnitTests.Figures;

public class CircleTests
{
    [Fact]
    public void Circle_EnterCorrectRadiuses_CircleCreatedSuccessfully()
    {
        //Arrange
        double[] radiuses = new[] { 0, 1.0, 2.2, 11.1, 333.3 };

        foreach (var radius in radiuses)
        {
            //Act
            var exception = Record.Exception(() => new Circle(radius));
        
            //Assert 
            Assert.Null(exception);
        }
    }

    [Fact]
    public void Circle_EnterIncorrectRadius_ThrowArgumentException()
    {
        //Arrange
        double radius = -0.1;
        
        //Act
        Action act = () => new Circle(radius);
        
        //Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
        
        Assert.Equal("Радиус окружности не должен быть меньше нуля.", exception.Message);
    }

    [Fact]
    public void CalculateArea_AreaCalculation_ReturnCalculatedArea()
    {
        //Arrange
        double radius = 20.2;
        Circle circle = new Circle(radius);
        double correctResult = Math.PI * Math.Pow(radius, 2);
        
        //Act
        var result = circle.CalculateArea();
        
        //Assert
        Assert.Equal(correctResult, result);
    }
}