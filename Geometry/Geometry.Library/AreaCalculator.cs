namespace Geometry.Library
{
    public static class AreaCalculator
    {
        public static double GetArea(Triangle triangle)
        {
            if (triangle is null)
            {
                throw new ArgumentNullException(nameof(triangle));
            }

            double area = Math.Abs(
                0.5D *
                (
                    triangle.P1.X * (triangle.P2.Y - triangle.P3.Y) +
                    triangle.P2.X * (triangle.P3.Y - triangle.P1.Y) +
                    triangle.P3.X * (triangle.P1.Y - triangle.P2.Y)
                ));

            return area;
        }

        public static double GetArea(Rectangle rectangle)
        {
            if (rectangle is null)
            {
                throw new ArgumentNullException(nameof(rectangle));
            }

            double area = rectangle.Width * rectangle.Height;

            return area;
        }

        public static double GetArea(Square square)
        {
            if (square is null)
            {
                throw new ArgumentNullException(nameof(square));
            }

            double area = square.Width * square.Width;

            return area;
        }
    }
}
