// Fig. 9.18: Circle5.cs
// A classe Circle5 que herda da classe Point4.

using System;

// Cole a classe Point4 (Fig-9.17 - Point4.cs) aqui.

public class Circle5 : Point4
{
	private double radius;

	public Circle5()
	{ Console.WriteLine("Circle5 constructor: {0}", this); }

	public Circle5(int xValue, int yValue, double radiusValue)
		: base(xValue, yValue)
	{
		Radius = radiusValue;
		Console.WriteLine("Circle5 constructor: {0}", this);
	}

	~Circle5()
	{
		Console.WriteLine("Circle5 destructor: {0}", this);
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
		// Usa a referência base para retornar a representação de string Point.
		return "Center = " + base.ToString() + "; Radius = " + Radius;
	}
}
