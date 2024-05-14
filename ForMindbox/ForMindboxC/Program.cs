using ForMindbox;

namespace ForMindboxC
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Проверка на возможность вычислить площадь фигуры без знания типа в compile-time
			Figure figure;
			string s = Console.ReadLine();
			if (s == "0")
			{
				figure = new Triangle(3, 4, 5);
			}
			else { figure = new Circle(1); }
			Console.WriteLine(figure.GetArea());
		}
	}
}