// Fig. 9.9: Point2.cs
// A classe Point2 contém um par de coordenadas x, y como dados protegidos.

using System;

public class Point2
{
	protected int x, y;

	public Point2()
	{ }

	public Point2(int xValue, int yValue)
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
	{ return "[" + X + ", " + Y + "]"; }
}
