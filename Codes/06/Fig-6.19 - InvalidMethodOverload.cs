// Fig. 6.19: InvalidMethodOverload.cs
// Demonstrando uma sobrecarga de métodos incorreta.

using System;

partial class InvalidMethodOverload
{
	public int Square(double x)
	{
		return x * x;
	}

	// ERRO! O segundo método Square recebe o mesmo número, ordem
	// e tipos de argumentos.
	public double Square(double y)
	{
		return y * y;
	}
}
