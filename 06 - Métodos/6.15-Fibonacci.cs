// 6.15: Fibonacci.
// Exemplo de recursividade com Fibonacci.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int Fibonacci(int num)
		{
			return (num == 0 || num == 1) ?
			 num : Fibonacci(num - 1) + Fibonacci(num - 2);
		}

		int num = 38;
		Console.WriteLine(
			$"Fibonacci({num}): {Fibonacci(num)}"
		);
	}
}
