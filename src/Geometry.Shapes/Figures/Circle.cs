namespace Geometry.Shapes.Figures;

/// <summary> Окружность.</summary>
public class Circle : IShape
{
    //Радиус окружности.
    public double Radius { get; }
    
    /// <param name="radius"> Радиус окружности.</param>
    /// <exception cref="ArgumentException"> Радиус окружности должен быть больше нуля.</exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Радиус окружности не должен быть меньше нуля.");
        }
        Radius = radius;
    }
    
    ///<inheritdoc cref="IShape.CalculateArea()"/>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}