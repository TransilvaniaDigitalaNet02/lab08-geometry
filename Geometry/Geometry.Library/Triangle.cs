namespace Geometry.Library
{
    public class Triangle
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1 ?? throw new ArgumentNullException(nameof(p1));
            P2 = p2 ?? throw new ArgumentNullException(nameof(p2));
            P3 = p3 ?? throw new ArgumentNullException(nameof(p3));
        }

        public Point P1 { get; }

        public Point P2 { get; }

        public Point P3 { get; }
    }
}
