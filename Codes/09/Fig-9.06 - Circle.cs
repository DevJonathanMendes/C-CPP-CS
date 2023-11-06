// Fig. 9.6: Circle.cs
// A classe Circle contém um par de coordenadas x, y e um raio.

using System;

public class Circle
{
	private int x, y;
	private double radius;

	public Circle()
	{ }

	public Circle(int xValue, int yValue, double radiusValue)
	{
		x = xValue;
		y = yValue;
		Radius = radiusValue;
	}

	public int X
	{
		get { return x; }
		set { x = value; }
	}

	public int Y
	{
		get { return y; }
		set { y = value; }
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
