// 9.04: Relacionamento entre classes base e classes derivadas.
// Parte 1.

using System;

// Herdam indiretamente System.Object.
public class Point
{
	private int x, y;

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

	// Uma sobreposição usa override.
	// Então ToString() foi declarado como "virtual".
	public override string ToString()
	{ return $"[{x}, {y}]"; }

	public void Test()
	{
		Console.WriteLine($"Demonstrating Class Point\n");

		Console.WriteLine($"X coordinate is {X}");
		Console.WriteLine($"Y coordinate is {Y}");

		X = 10;
		Y = 10;
		Console.WriteLine($"The new location of point is {ToString()}\n");
	}
}

public class Circle
{
	private int x, y;
	private double radius;

	public Circle(int xValue, int yValue, double radiusValue)
	{
		x = xValue;
		y = yValue;
		Radius = radiusValue;
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

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public double Area()
	{ return Math.PI * Math.Pow(radius, 2); }

	public override string ToString()
	{
		return $"Center = [{x}, {y}]; Radius = {radius}";
	}

	public void Test()
	{
		Console.WriteLine("Demonstrating Class Circle\n");

		Console.WriteLine($"X coordinate is {X}");
		Console.WriteLine($"Y coordinate is {Y}");
		Console.WriteLine($"Radius is {Radius}\n");

		X = 2;
		Y = 2;
		Radius = 4.25;

		Console.WriteLine($"The new location and radius of circle are");
		Console.WriteLine(ToString());
		Console.WriteLine($"Diameter is {Diameter():F}");
		Console.WriteLine($"Circumference is {Circumference():F}");
		Console.WriteLine($"Area is {Area():F}\n");
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Point point = new Point(72, 115);
		Circle circle = new Circle(37, 43, 2.5);

		Console.Clear();
		point.Test();
		circle.Test();
	}
}
