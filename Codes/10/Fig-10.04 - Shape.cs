// Fig. 10.4: Shape.cs
// Demonstra uma hierarquia de figuras geométricas usando uma classe base abstrata

using System;

public abstract class Shape
{
	// Retorna a área da figura.
	public virtual double Area()
	{ return 0; }

	// Retorna o volume da figura.
	public virtual double Volume()
	{ return 0; }

	// Retorna o nome da figura.
	public abstract string Name
	{ get; }
}
