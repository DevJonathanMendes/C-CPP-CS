// 9.06: Construtores e destrutores em classes derivadas.
// Instanciar um objeto da classe derivada inicia um encadeamento de chamadas a construtores
// no qual o construtor da classe derivada, antes de executar suas próprias tarefas,
// chama o construtora classe base explícita ou implicitamente.

using System;

public class Point4
{
	private int x, y;

	public Point4()
	{
		Console.WriteLine($"Point constructor: {this}");
	}

	public Point4(int xValue, int yValue)
	{
		X = xValue;
		Y = yValue;
		Console.WriteLine($"Point constructor: {this}");
	}

	~Point4()
	{
		Console.WriteLine($"Point destructor: {this}");
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

public class Circle5 : Point4
{
	private double radius;

	public Circle5()
	{
		Console.WriteLine($"Circle constructor: {this}");
	}

	public Circle5(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
	{
		Radius = radiusValue;
		Console.WriteLine($"Circle constructor: {this}");
	}

	~Circle5()
	{
		Console.WriteLine($"Circle destructor: {this}");
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

static class Program
{
	static void Main(string[] args)
	{
		Circle5 circle1, circle2;

		circle1 = new Circle5(72, 29, 4.5);
		circle2 = new Circle5(5, 5, 10);

		Console.WriteLine();

		// Marca objetos para coleta de lixo.
		circle1 = null;
		circle2 = null;

		// Informa o coletor de lixo para que seja executado.
		System.GC.Collect();
	}
}
