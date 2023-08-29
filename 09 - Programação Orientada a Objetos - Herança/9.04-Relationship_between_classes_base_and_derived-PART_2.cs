// 9.04: Relacionamento entre classes base e classes derivadas.
// Observe as heranças, sobreposições etc.
// Parte 2.

using System;

// Herdam indiretamente System.Object.
public class Point3
{
	private int x, y;

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

	// Uma sobreposição usa override.
	// Então ToString() foi declarado como "virtual".
	public override string ToString()
	{ return $"[{x}, {y}]"; }

	virtual public void Test()
	{
		Console.WriteLine($"Demonstrating Class Point\n");

		Console.WriteLine($"X coordinate is {X}");
		Console.WriteLine($"Y coordinate is {Y}");

		X = 10;
		Y = 10;
		Console.WriteLine($"The new location of point is {ToString()}\n");
	}
}

public class Circle4 : Point3
{
	private double radius;

	public Circle4(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
	{
		Radius = radiusValue;
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
		return $"Center = {base.ToString()}; Radius = {Radius}";
	}

	override public void Test()
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
		Point3 point = new Point3(72, 115);
		Circle4 circle = new Circle4(37, 43, 2.5);

		Console.Clear();
		point.Test();
		circle.Test();
	}
}
