// Fig. 9.14: CircleTest4.cs
// Testando a classe Circle4.

using System;
using System.Windows.Forms;

// Cole a classe Point3 (Fig-9.12 - Point3.cs) aqui.

// Cole a classe Circle4 (Fig-9.13 - Circle4.cs) aqui.

class CircleTest4
{
	static void Main(string[] args)
	{
		Circle4 circle = new Circle4(37, 43, 2.5);

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

		MessageBox.Show(output, "Demonstrating Class Circle4");
	}
}
