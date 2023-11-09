// Fig. 9.17: Point4.cs
// A classe Point4 representa um par de coordenadas x. y.

using System;

public class Point4
{
	private int x, y;

	public Point4()
	{
		// A chama implicita ao construtor de Object ocorre aqui.
		Console.WriteLine("Point4 constructor: {0}", this);
	}

	public Point4(int xValue, int yValue)
	{
		// A chama implicita ao construtor de Object ocorre aqui.
		X = xValue;
		Y = yValue;
		Console.WriteLine("Point4 constructor: {0}", this);
	}

	// Destrutor.
	~Point4()
	{
		Console.WriteLine("Point4 destructor: {0}", this);
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
