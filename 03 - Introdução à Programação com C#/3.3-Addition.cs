// Fig. 3.11: Addition.
// Um simples programa de soma de inteiros.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int num1, num2;

		Console.WriteLine("Please, enter the first number: ");
		num1 = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Please, enter the second number: ");
		num2 = Int32.Parse(Console.ReadLine());

		Console.WriteLine("The sum is: {0}", num1 + num2);
	}
}
