namespace Geometry.Library
{
    public class Square
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

        public Square(
            Point topLeft,
            int width) 
        {
            TopLeft = topLeft ?? throw new ArgumentNullException(nameof(topLeft));
            Width = width >= 0 ? width : throw new ArgumentException(nameof(width));
            TopRight = new Point(TopLeft.X + width, TopLeft.Y);
            BottomLeft = new Point(TopLeft.X, TopLeft.Y + width);
            BottomRight = new Point(topLeft.X + width, TopLeft.Y + width);
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }
    }
}
