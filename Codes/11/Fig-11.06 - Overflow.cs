// Fig. 11.6: Overflow.cs
// Demonstrando os operadores checked e unchecked.

using System;

class Overflow
{
	static void Main(string[] args)
	{
		int number1 = Int32.MaxValue; // 2.147.483.647.
		int number2 = Int32.MaxValue; // 2.147.483.647.
		int sum = 0;

		Console.WriteLine("number1: {0}\nnumber2: {1}", number1, number2);

		// Calcula a soma de number1 e number2.
		try
		{
			Console.WriteLine("\nSum integers in checked context:");
			sum = checked(number1 + number2);
		}
		// Captura exceção de estouro.
		catch (OverflowException overflowException)
		{
			Console.WriteLine(overflowException.ToString());
		}

		Console.WriteLine("\nsum after checked operation: {}", sum);

		Console.WriteLine("\nSum integers in unchecked context:");

		sum = unchecked(number1 + number2);

		Console.WriteLine("sum after unchecked operations: {0}", sum);
	}
}
