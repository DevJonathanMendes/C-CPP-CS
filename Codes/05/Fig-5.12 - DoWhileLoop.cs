// Fig. 5.12: DoWhileLoop.cs
// A estrutura de repetição do/while.

using System;

static class DoWhileLoop
{
	static void Main(string[] args)
	{
		int counter = 1;

		do
		{
			Console.WriteLine(counter);
			counter++;
		} while (counter <= 5);
	}
}
