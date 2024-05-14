using ForMindbox;

namespace ForMindboxTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestAreaOfTriangle()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.AreEqual( 6, triangle.GetArea());
		}

		[TestCase(3,4,5, ExpectedResult = true)]
		[TestCase(6, 8, 10, ExpectedResult = true)]
		[TestCase(6, 7, 10, ExpectedResult = false)]
		public bool TestIsRightTriangle(int a, int b, int c)
		{
			var triangle = new Triangle(a, b, c);
			return triangle.IsRightTriangle();
		}

		[Test]
		public void TestAreaOfCircle()
		{
			var Circle = new Circle(2);
			Assert.AreEqual(12.56, Circle.GetArea(), 0.01);
		}
	}
}