// 10.09: Estudo de caso: Criando e usando interfaces.
// Apresentaremos dois exemplos de polimorfismo, usando interfaces que
// especificam conjuntos de serviços public que as classes devem implementar.

// Usamos interface quando não há implementação padrão para herdar.
// Enquanto classes abstratas é mais bem usada para fornecer dados e serviços
// para objetos em um relacionamento hierárquico.

using System;

public interface IShape
{
	double Area();
	double Volume();
	string Name { get; }
}

public class Point3 : IShape
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

	public virtual string Name
	{ get { return "Point3"; } }

	public virtual double Area()
	{ return 0; }

	public virtual double Volume()
	{ return 0; }

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

public class Circle3 : Point3
{
	private double radius;

	public Circle3(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
	{ Radius = radiusValue; }

	public override string Name
	{ get { return "Circle3"; } }

	public double Radius
	{
		get { return radius; }
		set { if (value >= 0) radius = value; }
	}

	public double Diameter()
	{ return Radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public override double Area()
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

public class Cylinder3 : Circle3
{
	private double height;

	public Cylinder3(int xValue, int yValue, double radiusValue, double heightValue)
	: base(xValue, yValue, radiusValue)
	{ Height = heightValue; }

	public double Height
	{
		get { return height; }
		set { if (value >= 0) height = value; }
	}

	public override string Name
	{ get { return "Cylinder3"; } }

	public override double Area()
	{
		return 2 * base.Area() + base.Circumference() * Height;
	}

	public override double Volume()
	{ return base.Area() * Height; }

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
		Point3 point = new Point3(7, 11);
		Circle3 circle = new Circle3(22, 8, 3.5);
		Cylinder3 cylinder = new Cylinder3(10, 10, 3.3, 10);

		point.Test();
		circle.Test();
		cylinder.Test();
	}
}
