namespace Geometry.Library
{
    public class Rectangle
    {
        /*  Coordinates on a PC screen:
         *  ----------------------------------------
         * 
         *  0 -----------------------------------> X
         *  |
         *  |     TopLeft           TopRight
         *  |        *-----------------*
         *  |        |      width      |
         *  |        |                 | height
         *  |        |                 |
         *  |        *-----------------*
         *  |    BottomLeft       BottomRight
         *  |
         *  |
         *  V
         *  
         *  Y
         */
        public Rectangle(
            Point topLeft,
            int width,
            int height)
        { 
            TopLeft = topLeft ?? throw new ArgumentNullException(nameof(topLeft));
            Width = width >= 0 ? width : throw new ArgumentException(nameof(width));
            Height = height >= 0 ? height : throw new ArgumentException(nameof(height));

            TopRight = new Point(TopLeft.X + width, TopLeft.Y);
            BottomLeft = new Point(TopLeft.X, TopLeft.Y + height);
            BottomRight = new Point(topLeft.X + width, TopLeft.Y + height);
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }

        public int Height { get; }
    }
}
