// Fig. 9.13: Circle4.cs
// A classe Circle4 que herda da classe Point3.

using System;

// Cole a classe Point3 (Fig-9.12 - Point3.cs) aqui.

public class Circle4 : Point3
{
	private double radius;

	public Circle4()
	{ }

	public Circle4(int xValue, int yValue, double radiusValue)
		: base(xValue, yValue)
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
		// Usa a referência base para retornar a representação de string Point.
		return "Center = " + base.ToString() + "; Radius = " + radius;
	}
}
