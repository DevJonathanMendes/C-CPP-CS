// Fig. 8.15: UsingConstAndReadOnly.cs
// Demonstrando valores constantes com const e readonly.

using System;
using System.Windows.Forms;

public class Constants
{
	public const double PI = 3.14159;

	public readonly int radius;

	public Constants(int radiusValue)
	{ radius = radiusValue; }
}

public class UsingConstAndReadOnly
{
	static void Main(string[] args)
	{
		Random random = new Random();

		Constants constantsValues = new Constants(random.Next(1, 20));

		MessageBox.Show("Radius = " + constantsValues.radius +
			"\nCircumference = " +
			2 * Constants.PI * constantsValues.radius,
			"Circumference");
	}
}
