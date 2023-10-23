using Geometry.Library;

namespace Geometry.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(
                new Point(1, 2),
                new Point(-1, 1),
                new Point(0, 5));

            double area = AreaCalculator.GetArea(t);

            Console.WriteLine(area);
        }
    }
}