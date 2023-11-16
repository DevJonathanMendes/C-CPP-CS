// Fig. 10.7: Cylinder2.cs
// Cylinder2 herda da classe Circle2 e sobrepõe membros importantes.

using System;

// Cole a classe Shape (Fig-10.04 - Shape.cs) aqui.

// Cole a classe Point2 (Fig-10.05 - Point2.cs) aqui.

// Cole a classe Circle2 (Fig-10.06 - Circle2.cs) aqui.

public class Cylinder2 : Circle2
{
	private double height;

	public Cylinder2()
	{ }

	public Cylinder2(int xValue, int yValue, double radiusValue,
		double heightValue) : base(xValue, yValue, radiusValue)
	{
		Height = heightValue;
	}

	public double Height
	{
		get { return height; }
		set { if (value >= 0) height = value; }
	}

	public override double Area()
	{ return 2 * base.Area() + base.Circumference() * Height; }

	public override double Volume()
	{ return base.Area() * Height; }

	public override string ToString()
	{ return base.ToString() + "; Height = " + Height; }

	public override string Name
	{
		get { return "Cylinder2"; }
	}
}
