// Fig. 10.5: Point2.cs
// Point2 herda da classe abstrata Shape e representa um par de coordenadas x, y.

using System;

// Cole a classe Shape (Fig-10.04 - Shape.cs) aqui.

// Point2 herda da classe abstrata de Point2.
public class Point2 : Shape
{
	private int x, y;

	public Point2()
	{ }

	public Point2(int xValue, int yValue)
	{
		X = yValue;
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

	// Implementa a propriedade abstrata Name da classe Shape.
	public override string Name
	{
		get { return "Point2"; }
	}
}
