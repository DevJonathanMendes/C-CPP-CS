// Fig. 10.3: PointCircleTest.cs
// Demonstrando herança e polimorfismo.

using System;
using System.Windows.Forms;

// Cole a classe Point (Fig-10.1 - Point.cs) aqui.

// Cole a classe Circle (Fig-10.2 - Circle.cs) aqui.

class CircleTest
{
	static void Main(string[] args)
	{
		Point point1 = new Point(30, 50);
		Circle circle1 = new Circle(120, 89, 2.7);

		string output = "Point point1: " + point1.ToString() +
		"\nCircle circle1: " + circle1.ToString();

		// Usa relacionamento "é um" para atribuir
		// circle1 de Circle à referência Point.
		Point point2 = circle1;

		output += "\n\nCircle circle1 (via point2): " + point2.ToString();

		// Converte para baixo ("downcast" - Converte a referência à classe base
		// para tipo de dados da classe derivada) point2 para circle2 de Circle.
		Circle circle2 = (Circle)point2;

		output += "\n\nCircle circle1 (via circle2): " +
			circle2.ToString();

		output += "\nArea of circle1 (via circle2): " +
			circle2.Area().ToString("F");

		// Tenta atribuir o objeto à referência a Circle.
		if (point1 is Circle)
		{
			circle2 = (Circle)point1;
			output += "\n\ncast successful";
		}
		else
		{
			output += "\n\npoint1 does not refer to a Circle";
		}

		MessageBox.Show(output, "Demonstrating the 'is a' relationship");
	}
}
