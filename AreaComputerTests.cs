using AreaComputer;
using Xunit;

namespace AreaComputerTest
{
    public class AreaComputerTests
    {
        [Fact]
        public void ValidateCircleArea()
        {
            Circle circle = new Circle(10);

            Assert.InRange(circle.Area - 314.16, -0.01, 0.01);
        }

        [Fact]
        public void ValidateTriangleArea()
        {
            Triangle triangle = new Triangle(10, 15, 20);

            Assert.InRange(triangle.Area - 72.6184, -0.01, 0.01);
        }

        [Fact]
        public void ValidateRectabgularTriangle()
        {
            Triangle triangle = new Triangle(10, 10, 14.14213);

            Assert.True(triangle.IsRectangular);
        }
    }
}
