// 10.11: Sobrecarga de operadores.
// As manipulações nos objetos de uma classe são realizados por meio
// do envio de mensagens (Chamada a métodos) para objetos.

// O C# permite que o programador sobrecarregue a maioria dos operadores
// para torná-los sensíveis ao contexto em que estão sendo usados.

using System;

public class ComplexNumber
{
	private int real, imaginary;

	public ComplexNumber() { }

	public ComplexNumber(int num1, int num2)
	{
		Real = num1;
		Imaginary = num2;
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
		return $"{Real + (imaginary < 0 ? (imaginary * -1) : imaginary)}";
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

static class Program
{
	static void Main(string[] args)
	{
		ComplexNumber x = new ComplexNumber();
		ComplexNumber y = new ComplexNumber();

		void ReadNumber(ComplexNumber num, string name)
		{
			Console.Write($"Real({name}): ");
			num.Real = Int32.Parse(Console.ReadLine());

			Console.Write($"Imaginary({name}): ");
			num.Imaginary = Int32.Parse(Console.ReadLine());
		}

		ReadNumber(x, "x");
		ReadNumber(y, "y");
		Console.Write($"\nReal(x, y): {x.Real}, {y.Real}");
		Console.Write($"\nImaginary(x, y): {x.Imaginary}, {y.Imaginary}");
	}
}
