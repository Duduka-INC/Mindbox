using Geometry.Shapes.Figures;

namespace Geometry.MainApplication;

public abstract class MainApplication
{
    public static void Main(string[] args)
    {
        var circle = new Circle(4);
        Console.WriteLine($"Окружность с радиусом {circle.Radius} имеет площадь " +
                          $"S = {circle.CalculateArea()}.");

        var triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Треугольник со сторонами ({triangle.SideA}, {triangle.SideB}, {triangle.SideC}) имеет площадь " +
                          $"S = {triangle.CalculateArea()}.");
        if (triangle.IsRightAngled())
        {
            Console.WriteLine("Треугольник является Прямоугольным.");
        }
        else
        {
            Console.WriteLine("Треугольник не является прямоугольным.");
        }
    }
}