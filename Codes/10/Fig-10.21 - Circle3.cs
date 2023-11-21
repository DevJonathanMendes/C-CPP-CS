// Fig. 10.21: Circle3.cs
// Circle3 herda da classe POint3 e sobrepõe membros importantes.

using System;

// Cole a interface IShape (Fig-10.19 - IShape.cs) aqui.

// Cole a classe Point3 (Fig-10.20 - Point3.cs) aqui.

public class Circle3 : Point3
{
	private double radius;

	public Circle3()
	{ }

	public Circle3(int xValue, int yValue, double radiusValue)
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
		return "Center = " + base.ToString() +
			"; Radius = " + Radius;
	}

	public override string Name
	{ get { return "Circle3"; } }
}
