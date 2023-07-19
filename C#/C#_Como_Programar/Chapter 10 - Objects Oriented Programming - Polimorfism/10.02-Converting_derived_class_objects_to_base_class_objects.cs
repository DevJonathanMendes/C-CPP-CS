// 10.2: Conversão de objetos de classes derivadas para objetos da classe base.
// Um objeto de uma classe derivada pode ser tratado como um objeto de sua classe base.
// Isso possibilita várias manipulações interessantes.

using System;

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

public class Circle : Point
{
	private double radius;

	public Circle(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
	{
		Radius = radiusValue;
	}

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return Radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public virtual double Area()
	{ return Math.PI * Math.Pow(Radius, 2); }

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
		Point point1 = new Point(30, 50);
		Circle circle1 = new Circle(120, 89, 2.7);

		// Um relacionamento "é um" para atribuir
		// circle1 de Circle à referência Point.
		Point point2 = circle1;

		// Converte para baixo ("downcast" - converte a referência à class base
		// para tipo de dados da classe) point2 para circle2 de Circle.
		Circle circle2 = (Circle)point2;

		// Tenta atribuir o objeto point1 à referência a Circle
		if (point1 is Circle)
		{
			circle2 = (Circle)point1;
			Console.WriteLine($"cast successful");
		}
		else
			Console.WriteLine($"point1 does not refer to a Circle");
	}
}
