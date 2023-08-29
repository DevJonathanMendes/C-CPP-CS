// Fig. 4.11: Operadores de atribuição.
// Uma forma de abreviação.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int variable = 0;

		variable = variable + 2; // Pode ser abreviada.
		variable += 2;
		variable -= 2;
		variable *= 2;
		variable /= 2;
		variable %= 2;

		Console.Clear();
		Console.WriteLine(variable);
	}
}
