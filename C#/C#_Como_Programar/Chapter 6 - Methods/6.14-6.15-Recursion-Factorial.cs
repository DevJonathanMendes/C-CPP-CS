// 6.14: Recursividade.
// Fig. 6.15: Factorial.
// Calculando fatoriais com recursividade.
// A função chama ela própria até chegar no caso básico.

using System;

static class Program
{
	static void Main(string[] args)
	{
		long Factorial(long num)
		{
			return num <= 1 ? 1
				: num * Factorial(num - 1); // Caso básico.
		}

		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine(
			 $"Fatorial {i.ToString("00")}: {Factorial(i)}"
			);
		}
	}
}
