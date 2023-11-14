// Fig. 10.2: Circle.cs
// A classe Circle que herda da classe Point.

using System;

// Cole a classe Point (Fig-10.1 - Point.cs) aqui.

public class Circle : Point
{
	private double radius;

	public Circle()
	{ }

	public Circle(int xValue, int yValue, double radiusValue)
	: base(xValue, yValue)
	{ Radius = radiusValue; }

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return Radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public double Area()
	{ return Math.PI * Math.Pow(Radius, 2); }

	public override string ToString()
	{
		return "Center = " + base.ToString() + "; Radius = " + Radius;
	}
}
