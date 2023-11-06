// Fig. 9.10: Circle3.cs
// A classe Circle3 que herda da classe Point2.

using System;

// Cole a classe Point2 (Fig-9.09 - Point2.cs) aqui.

// A definição da classe Circle3 herda de Point2.
public class Circle3 : Point2
{
	private double radius;

	public Circle3()
	{ }

	public Circle3(int xValue, int yValue, double radiusValue)
	{
		x = xValue;
		y = yValue;
		Radius = radiusValue;
	}

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public double Area()
	{ return Math.PI * Math.Pow(radius, 2); }

	public override string ToString()
	{
		return "Center = [" + x + ", " + y + "]" + "; Radius = " + radius;
	}
}
