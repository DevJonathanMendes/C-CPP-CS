// Fig. 9.15: Cylinder.cs
// A classe Cylinder herda da classe Circle4.

using System;

// Colo a classe Point3 (Fig-9.12 - Point3) aqui.

// Colo a classe Circle4 (Fig-9.13 - Circle4) aqui.

public class Cylinder : Circle4
{
	private double height;

	public Cylinder()
	{ }

	public Cylinder(int xValue, int yValue, double radiusValue,
	double heightValue) : base(xValue, yValue, radiusValue)
	{ height = heightValue; }

	public double Height
	{
		get { return height; }
		set { if (value >= 0) height = value; }
	}

	public override double Area()
	{ return 2 * base.Area() + base.Circumference() * Height; }

	public double Volume()
	{ return base.Area() * Height; }

	public override string ToString()
	{ return base.ToString() + "; Height = " + Height; }
}
