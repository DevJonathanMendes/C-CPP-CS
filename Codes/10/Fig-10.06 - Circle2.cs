// Fig. 10.6: Circle2.cs
// Circle2 herda da classe Point2 e sobrepõe membros importantes.

using System;

// Cole a classe Shape (Fig-10.04 - Shape.cs) aqui.

// Cole a classe Point2 (Fig-10.05 - Point2.cs) aqui.

public class Circle2 : Point2
{
	private double radius;

	public Circle2()
	{ }

	public Circle2(int xValue, int yValue, double radiusValue)
		: base(xValue, yValue)
	{
		Radius = radiusValue;
	}

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return Radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public override double Area()
	{ return Math.PI * Math.Pow(Radius, 2); }

	public override string ToString()
	{
		return "Center = " + base.ToString() + "; Radius = " + Radius;
	}

	public override string Name
	{ get { return "Circle2"; } }
}
