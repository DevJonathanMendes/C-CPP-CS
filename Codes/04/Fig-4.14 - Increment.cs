// Fig. 4.14: Increment.cs
// Pré-incremento e pós-incremento.

using System;

class Increment
{
	static void Main(string[] args)
	{
		int c;

		c = 5;
		Console.WriteLine(c);
		Console.WriteLine(c++);
		Console.WriteLine(c);

		Console.WriteLine();

		c = 5;
		Console.WriteLine(c);
		Console.WriteLine(++c);
		Console.WriteLine(c);
	}
}
