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
			var triangle = new Triangle() { a = 3, c = 4 , b = 5};
			Assert.AreEqual( 6, triangle.GetArea());
		}

		[Test]
		public void TestIsRightTriangle()
		{
			var triangle = new Triangle() { a = 3, c = 4, b = 5 };
			Assert.IsTrue(triangle.IsRightTriangle());
		}

		[Test]
		public void TestAreaOfCircle()
		{
			var Circle = new Circle() { radius = 2 };
			Assert.AreEqual(12.56, Circle.GetArea(), 0.01);
		}
	}
}