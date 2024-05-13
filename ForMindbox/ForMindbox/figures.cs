using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ForMindbox
{
	public abstract class Figure
	{
		public abstract double GetArea();
	}

	public class Triangle : Figure
	{
		public double a {  get; set; }
		public double b { get; set; }
		public double c { get; set; }

		public override double GetArea() => MathArea.GetArea(this);

		public bool IsRightTriangle()
		{
			double hypotenuse = double.Max(double.Max(a, b), c);
			if (a == hypotenuse) {
				if (b * b + c * c == a * a) return true; }
			else if (b == hypotenuse) {
				if (a * a + c * c == b * b) return true; }
			else if (c == hypotenuse){
				if (a * a + b * b == c * c) return true; }
			return false;
		}
	}

	public class Circle : Figure
	{
		public double radius { get; set; }

		public override double GetArea() => MathArea.GetArea(this);
	}
}
