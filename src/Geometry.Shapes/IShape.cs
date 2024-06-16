namespace Geometry.Shapes;

/// <summary> Абстрактная фигура.</summary>
public interface IShape
{
    /// <summary>
    /// Вычисление площади.
    /// </summary>
    /// <returns> Площадь фигуры.</returns>
    double CalculateArea();
}