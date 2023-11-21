// Fig. 10.22: Cylinder3.cs
// Cylinder3 herda da classe Circle3 e sobrepõe membros importantes.

using System;

// Cole a interface IShape (Fig-10.19 - IShape.cs) aqui.

// Cole a classe Point3 (Fig-10.20 - Point3.cs) aqui.

// Cole a classe Circle3 (Fig-10.21 - Circle3.cs) aqui.

public class Cylinder3 : Circle3
{
	private double height;

	public Cylinder3()
	{ }

	public Cylinder3(int xValue, int yValue, double radiusValue,
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
	{
		return "Center = " + base.ToString() +
			"; Height = " + Height;
	}

	public override string Name
	{ get { return "Cylinder3"; } }
}
