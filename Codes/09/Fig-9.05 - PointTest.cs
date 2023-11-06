// Fig. 9.5: PointTest.cs
// Testando a classe Point.

using System;
using System.Windows.Forms;

// Cole a classe Point (Fig-9.04 - Point.cs) aqui.

class PointTest
{
	static void Main(string[] args)
	{
		Point point = new Point(72, 115);

		string output = "X coordinate is " + point.X +
			"\n" + "Y coordinate is " + point.Y;

		point.X = 10;
		point.Y = 10;

		output += "\n\nThe new location of point is " + point;

		MessageBox.Show(output, "Demonstrating Class Point");
	}
}
