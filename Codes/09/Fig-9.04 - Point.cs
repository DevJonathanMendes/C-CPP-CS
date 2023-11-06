// Fig. 9.4: Point.cs
// A classe Point representa um par de coordenadas x, y.

using System;

public class Point
{
	private int x, y;

	public Point()
	{ }

	public Point(int xValue, int yValue)
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
