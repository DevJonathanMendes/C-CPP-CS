// 11.08: Tratando estouros com os operadores checked e unchecked.
// O C# oferece os operadores checked e unchecked para especificar
// se a aritmética de inteiro ocorre em um contexto verificado ou não.

// Os operadores "++, --, *, /, + e -" (unários e binários) podemos causar
// estouro quando usados com tipos de dados integrais (como int e long).

using System;

// Demonstra o uso dos operadores checked e unchecked.
static class Program
{
	static void Main(string[] args)
	{
		int maxInt32 = Int32.MaxValue; // 2.147.483.647.
		int sum = 0;

		try
		{
			Console.WriteLine("Sum integers in checked context:");

			sum = checked(maxInt32 + maxInt32);
		}
		catch (OverflowException overflowException)
		{
			Console.WriteLine(overflowException.ToString());
		}

		Console.WriteLine($"\nSum after checked operations: {sum}\n");

		Console.WriteLine($"Sum integers in checked context: {sum}");
		sum = unchecked(maxInt32 + maxInt32);
		Console.WriteLine($"Sum after unchecked operations: {sum}");
	}
}
