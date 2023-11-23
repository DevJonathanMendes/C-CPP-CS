// Fig. 10.26: ComplexNumber.cs
// Classe que sobrecarrega operadores para soma, subtração e multiplicação de número complexos.

using System;

public class ComplexNumber
{
	private int real;
	private int imaginary;

	public ComplexNumber() { }

	public ComplexNumber(int a, int b)
	{
		Real = a;
		Imaginary = b;
	}

	public int Real
	{
		get { return real; }
		set { real = value; }
	}

	public int Imaginary
	{
		get { return imaginary; }
		set { imaginary = value; }
	}

	public override string ToString()
	{
		return "{" + real +
			(imaginary < 0 ? " - " + (imaginary * -1) :
			" + " + imaginary) + "i )";
	}

	// Sobrecarga o operador soma.
	public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
	{ return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary); }

	// Fornece alternativa para o operador sobrecarregado + para soma.
	public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
	{ return x + y; }

	// Sobrecarga o operador de subtração.
	public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
	{ return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary); }

	// Fornece alternativa para o operador sobrecarregado - para a subtração.
	public static ComplexNumber Subtract(ComplexNumber x, ComplexNumber y)
	{ return x - y; }

	// Sobrecarga o operador de multiplicação.
	public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
	{
		return new ComplexNumber(
			x.Real * y.Real - x.Imaginary * y.Imaginary,
			x.Real * y.Imaginary + y.Real * x.Imaginary);
	}

	// Fornece alternativa para o operador sobrecarregado * para a multiplicação.
	public static ComplexNumber Multiply(ComplexNumber x, ComplexNumber y)
	{ return x * y; }
}
