// Fig. 9.11: CircleTest3.cs
// Testando a classe Circle3.

using System;
using System.Windows.Forms;

// Cole a classe Point2 (Fig-9.09 - Point2.cs) aqui.

// Cole a classe Circle3 (Fig-9.10 - Circle3.cs) aqui.

class CircleTest3
{
	static void Main(string[] args)
	{
		Circle3 circle = new Circle3(37, 43, 2.5);

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
