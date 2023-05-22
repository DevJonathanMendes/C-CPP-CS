// Fig. 5.02: Estrutura de Repetição for.
// Repetição controlada pela estrutura for.

using System;

static class Program
{
	static void Main(string[] args)
	{
		Console.Clear();
		// Declara a variável, testa, se true, faça até que.
		for (int counter = 1; counter <= 5; counter++)
			Console.WriteLine($"Counter: {counter}");
	}
}
