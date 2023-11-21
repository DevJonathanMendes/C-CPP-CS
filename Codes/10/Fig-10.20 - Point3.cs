// Fig. 10.20: Point3.cs
// Point3 implementa a interface IShape e representa um par de coordenadas x, y.

using System;

// Cole a interface IShape (Fig-10.19 - IShape.cs) aqui.

public class Point3 : IShape
{
	private int x, y;

	public Point3()
	{ }

	public Point3(int xValue, int yValue)
	{
		X = xValue;
		Y = yValue;
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

	public override string ToString()
	{ return "[" + x + ", " + y + "]"; }

	public virtual double Area()
	{ return 0; }

	public virtual double Volume()
	{ return 0; }

	public virtual string Name
	{ get { return "Point3"; } }
}
