// 10.03: Campos de tipo e instruções switch.
// 10.04: Exemplos de Polimorfismo.
// Uma classe polimórfica base comum é usada de tal maneira para todos os objetos das classes derivados.
// 10.05: Classes e métodos abstratos.
// Com o polimorfismo, um método pode fazer ocorrer diferentes ações,
// dependendo do tipo do objeto em que o método é chamado.

// 10.06: Estudo de caso: Herança de interface e implementação.

using System;

// Classe abstrata Shape
// Define dois métodos concretos e uma propriedade abstract.
public abstract class Shape
{
	public virtual double Area()
	{ return 0; }

	public virtual double Volume()
	{ return 0; }

	public abstract string Name
	{ get; }
}

// Herda da classe abstrata Shape.
public class Point2 : Shape
{
	private int x, y;

	public Point2(int xValue, int yValue)
	{
		X = xValue;
		Y = yValue;
	}

	public int X
	{ get { return x; } set { x = value; } }

	public int Y
	{ get { return y; } set { y = value; } }

	public override string ToString()
	{ return $"[{X}, {Y}]"; }

	public override string Name
	{ get { return "Point2"; } }
}

// Herda da classe Point2 e sobrepõe membros importantes.
public class Circle2 : Point2
{
	private double radius;

	public Circle2(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
	{ Radius = radiusValue; }

	public double Radius
	{ get { return radius; } set { if (value >= 0) radius = value; } }

	public double Diameter()
	{ return Radius * 2; }

	public double Circumference()
	{ return Math.PI * Diameter(); }

	public override double Area()
	{ return Math.PI * Math.Pow(Radius, 2); }

	public override string ToString()
	{ return $"Center = {base.ToString()}; Radius = {Radius}"; }

	public override string Name
	{ get { return "Circle2"; } }
}

// Herda da classe Circle2.
public class Cylinder2 : Circle2
{
	private double height;

	public Cylinder2(int xValue, int yValue, double radiusValue, double heightValue)
	: base(xValue, yValue, radiusValue)
	{ Height = heightValue; }

	public double Height
	{ get { return height; } set { if (value >= 0) height = value; } }

	public override double Area()
	{ return 2 * base.Area() + base.Circumference() * Height; }

	public override double Volume()
	{ return base.Area() * Height; }

	public override string ToString()
	{ return $"{base.ToString()}; Height = {Height}"; }

	public override string Name
	{ get { return "Cylinder2"; } }
}

static class Program
{
	static void Main(string[] args)
	{
		Point2 point = new Point2(7, 11);
		Circle2 circle = new Circle2(22, 8, 3.5);
		Cylinder2 cylinder = new Cylinder2(10, 10, 3.3, 10);

		// Array vazio de referências à classe base Shape.
		Shape[] arrayOfShapes = new Shape[3];

		arrayOfShapes[0] = point;
		arrayOfShapes[1] = circle;
		arrayOfShapes[2] = cylinder;

		Console.Clear();
		Console.WriteLine("Demonstrating Polymorphism\n");
		Console.WriteLine($"{point.Name}: {point}");
		Console.WriteLine($"{circle.Name}: {circle}");
		Console.WriteLine($"{cylinder.Name}: {cylinder}\n");

		foreach (Shape shape in arrayOfShapes)
		{
			Console.WriteLine($"{shape.Name}: {shape}");
			Console.WriteLine($"Area = {shape.Area().ToString("F")}");
			Console.WriteLine($"Volume = {shape.Volume().ToString("F")}\n");
		}
	}
}
