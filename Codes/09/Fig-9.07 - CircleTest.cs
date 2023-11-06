// Fig. 9.7: CircleTest.cs
// Testando a classe Circle.

using System;
using System.Windows.Forms;

// Cole a classe Circle (Fig-9.06 - Circle.cs) aqui.

class CircleTest
{
	static void Main(string[] args)
	{
		Circle circle = new Circle(37, 43, 2.5);

		string output = "X coordinate is " + circle.X +
			"\nY coordinate is " + circle.Y +
			"\nRadius is " + circle.Radius;

		circle.X = 2;
		circle.Y = 2;
		circle.Radius = 4.25;

		output += "\n\nThe new location and radius of " +
			"circle are \n" + circle + "\n";

		output += "Diameter is " +
			String.Format("{0:F}", circle.Diameter()) + "\n";

		output += "Circumference is " +
			String.Format("{0:F}", circle.Circumference()) + "\n";

		output += "Area is " +
			String.Format("{0:F}", circle.Area()) + "\n";

		MessageBox.Show(output, "Demonstrating Class Circle");
	}
}
