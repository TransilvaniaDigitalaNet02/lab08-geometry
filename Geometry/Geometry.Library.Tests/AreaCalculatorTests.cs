namespace Geometry.Library.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void GetArea_Triangle_WhenTriangleIsNull_ThrowArgumentNullException()
        {
            try
            {
                Triangle t = null;
                AreaCalculator.GetArea(t);
                Assert.Fail("Get area should fail for a null triangle");
            }
            catch (Exception ex)
            {
                Assert.True(ex is ArgumentNullException);
            }
        }

        [InlineData(1, 2, -1, 1, 0, 5, 3.5D)]
        [InlineData(-1, 2, 2, 3, 4, -3, 10D)]
        [InlineData(1, -2, -3, 4, 2, 3, 13D)]
        [InlineData(3, 4, 4, 7, 6, -3, 8D)]
        [Theory]
        public void GetArea_Triangle_ReturnsExpectedArea(int x1, int y1, int x2, int y2, int x3, int y3, double area)
        {
            Triangle t = new Triangle(
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3));

            double actualArea = AreaCalculator.GetArea(t);

            Assert.Equal(area, actualArea);
        }
    }
}