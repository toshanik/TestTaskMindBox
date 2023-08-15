using TestTask;

namespace TestingTestTask
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void SquareCircle()
        {
            Circle circle = new Circle(10);
            double expected = 314.16;
            double result = circle.Square();
            Assert.AreEqual(expected, Math.Round(result, 2));
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void SquareTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;
            double result = triangle.Square();
            Assert.AreEqual(expected, Math.Round(result, 2));
        }

        [TestMethod]
        public void SquareTriangleNegativeValue()
        {
            try
            {
                Triangle triangle = new Triangle(-4, 3, 5);
                Assert.Fail("Should have thrown exception");
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TriangleIsNotRectangle()
        {
            var triangle = new Triangle(3, 4, 7);
            var result = triangle.IsRectangular();
            Assert.IsFalse(result);
        }
    }
}