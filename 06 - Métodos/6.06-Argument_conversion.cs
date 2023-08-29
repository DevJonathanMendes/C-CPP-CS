// 6.6: Conversão de argumentos.
// A conversão mã qualquer coisa para qualquer coisa.
// Veja: Tipo => Poder ser convertido para.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int Square(int y)
		{ return y * y; }

		double y = 4.5;
		Console.WriteLine($"The square of: {y} = {Square((int)y)}"); // func((int)y) é a conversão.
	}
}
