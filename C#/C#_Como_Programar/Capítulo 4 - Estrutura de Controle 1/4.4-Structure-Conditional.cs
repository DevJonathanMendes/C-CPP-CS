// 4.4: Estrutura condicional if, else if e else.
// A estrutura condicional avalia uma expressão booleana.

using System;

static class Program
{
	static void Main(string[] args)
	{
		if (false)
		{
			if (false)
				Console.WriteLine();
			else if (true)
				Console.WriteLine();
		}
		else
		{
			if (false)
				Console.WriteLine();
			else
				Console.WriteLine();
		}
	}
}
