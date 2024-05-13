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
				figure = new Triangle() { a = 3, b = 4, c = 5 };
			}
			else { figure = new Circle() { radius = 1 };}
			Console.WriteLine(figure.GetArea());
		}
	}
}