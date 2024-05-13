namespace ForMindbox
{
	public static class MathArea
	{
		public static double GetArea(Circle circle)
		{
			return Math.PI * circle.radius * circle.radius;
		}

		public static double GetArea(Triangle triangle)
		{
			double p = (triangle.a + triangle.b + triangle.c) / 2;
			return Math.Sqrt(p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
		}
	}
}