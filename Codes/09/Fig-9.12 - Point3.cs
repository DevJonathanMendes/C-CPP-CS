// Fig. 9.12: Point3.cs
// A classe Point3 representa um par de coordenadas x, y.

using System;

public class Point3
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
}
