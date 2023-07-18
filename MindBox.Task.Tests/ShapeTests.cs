namespace MindBox.Task.Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleSquare_4_Return_50_3()
        {
            var circle = new Circle("Circle 1", 4);
            double exp = 50.3;

            Assert.AreEqual(exp, circle.CalculateSquare());

        }
        [TestMethod]
        public void Triangle_IsRight_ReturnTrue()
        {
            var triangle = new Triangle(8, 2, 2);

            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}