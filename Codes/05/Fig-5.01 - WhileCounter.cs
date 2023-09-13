// Fig. 5.1: WhileCounter.cs
// Repetição controlada por contador.

using System;

static class WhileCounter
{
	static void Main(string[] args)
	{
		int counter = 1;

		while (counter <= 5)
		{
			Console.WriteLine(counter);
			counter++;
		}
	}
}
