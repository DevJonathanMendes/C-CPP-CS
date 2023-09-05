// Fig. 3.19: Comparison.cs
// Usando instruções if, operadores relacionais e operadores de igualdade.

using System;

class Comparison
{
	static void Main(string[] args)
	{
		int number1, number2;

		Console.Write("Please enter first integer: ");
		number1 = Int32.Parse(Console.ReadLine());

		Console.Write("\nPlease enter second integer: ");
		number2 = Int32.Parse(Console.ReadLine());

		if (number1 == number2)
			Console.WriteLine(number1 + " == " + number2);

		if (number1 != number2)
			Console.WriteLine(number1 + " != " + number2);

		if (number1 < number2)
			Console.WriteLine(number1 + " < " + number2);

		if (number1 > number2)
			Console.WriteLine(number1 + " > " + number2);

		if (number1 <= number2)
			Console.WriteLine(number1 + " <= " + number2);

		if (number1 >= number2)
			Console.WriteLine(number1 + " >= " + number2);
	}
}
