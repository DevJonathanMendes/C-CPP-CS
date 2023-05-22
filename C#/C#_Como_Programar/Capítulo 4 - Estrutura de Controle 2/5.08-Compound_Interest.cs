// Fig. 5.08: Juros composto.
// Calculando juros composto.

using System;

static class Program
{
	static void Main(string[] args)
	{
		decimal amount, principal = (decimal)1000.00;
		double rate = .05;
		string output = "Year\tAmount on deposit\n";

		Console.Clear();
		for (int year = 1; year <= 10; year++)
		{
			amount = principal * (decimal)Math.Pow(1.0 + rate, year);
			// Interessante: Códigos de formato para string.
			output += $"{year.ToString("00")}\t{String.Format("{0:C}", amount)}\n";
		}
		Console.WriteLine(output);
	}
}
