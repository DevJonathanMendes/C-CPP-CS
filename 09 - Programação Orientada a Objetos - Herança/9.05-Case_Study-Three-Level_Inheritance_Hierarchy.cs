// 9.05: Estudo de Caso: Hierarquia de herança de três níveis.
// Exemplo de herança mais substancial, envolvendo uma hierarquia de
// cilindro, círculo e ponto de três níveis.

using System;

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

	public virtual double Area()
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

public class Cylinder : Circle4
{
	private double height;

	public Cylinder(int xValue, int yValue, double radiusValue, double heightValue)
	: base(xValue, yValue, radiusValue)
	{
		Height = heightValue;
	}

	public double Height
	{
		get { return height; }
		set
		{
			if (value >= 0)
				height = value;
		}
	}

	public override double Area()
	{
		return 2 * base.Area() + base.Circumference() * Height;
	}

	public double Volume()
	{
		return base.Area() * Height;
	}

	public override string ToString()
	{
		return base.ToString() + $"; Height = {Height}";
	}

	public override void Test()
	{
		Console.WriteLine("Demonstrating Class Cylinder\n");
		Console.WriteLine($"X coordinate is {X}");
		Console.WriteLine($"Y coordinate is {Y}");
		Console.WriteLine($"Radius is {Radius}");
		Console.WriteLine($"Height is {Height}\n");

		X = 2;
		Y = 2;
		Radius = 4.45;
		Height = 10;

		Console.WriteLine("The new location, radius and height of cylinder are");
		Console.WriteLine($"{ToString()}\n");
		Console.WriteLine($"Diameter is {Diameter():F}");
		Console.WriteLine($"Circumference is {Circumference():F}");
		Console.WriteLine($"Area is {Area():F}");
		Console.WriteLine($"Volume is {Volume():F}\n");
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Cylinder cylinder = new Cylinder(12, 23, 2.5, 5.7);

		Console.Clear();
		cylinder.Test();
	}
}
