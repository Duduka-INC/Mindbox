namespace Geometry.Shapes.Figures;

/// <summary> Треугольник.</summary>
public class Triangle
{
    // Стороны треугольника.
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    /// <param name="sideA"> Сторона A.</param>
    /// <param name="sideB"> Сторона B.</param>
    /// <param name="sideC"> Сторона C.</param>
    /// <exception cref="ArgumentException"> Стороны должны быть строго положительными и соответствовать
    /// "Неравенству треугольника".</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        var values = new[] { sideA, sideB, sideC };
        double maxValue = values.Max();

        if (values.Any(v => v <= 0))
        {
            throw new ArgumentException("Стороны треугольника должны быть строго положительными.");
        }
        if (sideA + sideB + sideC <= 2 * maxValue)
        {
            throw new ArgumentException("Стороны треугольника не соответствуют " +
                                        "неравенству треугольника.");
        }
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    ///<inheritdoc cref="IShape.CalculateArea()"/>
    public double CalculateArea()
    {
        //Вычисление полупериметра.
        double p = (SideA + SideB + SideC) / 2;
        
        //Вычисление площади треугольника по трем сторонам.
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    /// <summary>
    /// Проверка, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns> Булевое значение, прямоугольный ли треугольник.</returns>
    public bool IsRightAngled()
    {
        double maxValue = new [] { SideA, SideB, SideC }.Max();
        if (Math.Abs((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) - 2 * Math.Pow(maxValue, 2)) < 1e-10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}