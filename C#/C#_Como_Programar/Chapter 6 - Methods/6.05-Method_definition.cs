// 6.5: Definições de métodos.
// Fig. 6.3: SquareInt

using System;

static class Program
{
	static void Main(string[] args)
	{
		int Square(int y)
		{
			return y * y; // Retorna o quadrado de y.
		}

		for (int i = 1; i <= 10; i++)
			Console.WriteLine($"The square of: {i} = {Square(i)}");
	}
}
