namespace Geometry.Library
{
    public static class PerimeterCalculator
    {
        private static double Distance(Point p1, Point p2)
        {
            if (p1 is null)
            {
                throw new ArgumentNullException(nameof(p1));
            }

            if (p2 is null)
            {
                throw new ArgumentNullException(nameof (p2));
            }

            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)); ;
        }

        public static double GetPerimeter(Triangle triangle)
        {
            if (triangle is null)
            {
                throw new ArgumentNullException(nameof(triangle));
            }

            double perimter =
                Distance(triangle.P1, triangle.P2) +
                Distance(triangle.P2, triangle.P3) +
                Distance(triangle.P3, triangle.P1);

            return perimter;
        }

        public static double GetPerimeter(Rectangle rectangle)
        {
            if (rectangle is null)
            {
                throw new ArgumentNullException(nameof(rectangle));
            }

            double perimeter = rectangle.Width * 2 + rectangle.Height * 2;

            return perimeter;
        }

        public static double GetPerimeter(Square square)
        {
            if (square is null)
            {
                throw new ArgumentNullException(nameof(square));
            }

            double perimeter = square.Width * 4;

            return perimeter;
        }
    }
}
