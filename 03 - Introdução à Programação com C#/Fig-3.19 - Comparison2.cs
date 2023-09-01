// Fig. 3.19: Comparison.cs
// Usando instruções if, operadores relacionais e operadores de igualdade.

using System;

class Comparison
{
	static void Main(string[] args)
	{
		Console.Write("Please enter first integer: ");
		int num1 = Int32.Parse(Console.ReadLine());

		Console.Write("\nPlease enter second integer: ");
		int num2 = Int32.Parse(Console.ReadLine());

		if (num1 == num2)
			Console.WriteLine(num1 + " == " + num2);

		if (num1 != num2)
			Console.WriteLine(num1 + " != " + num2);

		if (num1 < num2)
			Console.WriteLine(num1 + " < " + num2);

		if (num1 > num2)
			Console.WriteLine(num1 + " > " + num2);

		if (num1 <= num2)
			Console.WriteLine(num1 + " <= " + num2);

		if (num1 >= num2)
			Console.WriteLine(num1 + " >= " + num2);
	}
}
