// Fig. 9.16: CylinderTest.cs
// Testa a classe Cylinder.

using System;
using System.Windows.Forms;

// Cole a classe Point3 (Fig-9.12 - Point3.cs) aqui.

// Cole a classe Circle4 (Fig-9.13 - Circle4.cs) aqui.

// Cole a classe Cylinder (Fig-9.15 - Cylinder.cs) aqui.

static class CylinderTest
{
	static void Main(string[] args)
	{
		Cylinder cylinder = new Cylinder(12, 23, 2.5, 5.7);

		string output = "X coordinate is " + cylinder.X +
			"\nY coordinate is " + cylinder.Y + "\nRadius is " +
			cylinder.Radius + "\n" + "Height is " + cylinder.Height;

		cylinder.X = 2;
		cylinder.Y = 2;
		cylinder.Radius = 4.25;
		cylinder.Height = 10;

		output += "\n\nThe new location, radius and height of " +
			"cylinder are \n" + cylinder + "\n\n";

		output += "Diameter is " +
			String.Format("{0:F}", cylinder.Diameter()) + "\n";

		output += "Circumference is " +
			String.Format("{0:F}", cylinder.Circumference()) + "\n";

		output += "Area is " +
			String.Format("{0:F}", cylinder.Area()) + "\n";

		output += "Volume is " +
			String.Format("{0:F}", cylinder.Volume()) + "\n";

		MessageBox.Show(output, "Demonstrating Class Cylinder");
	}
}
