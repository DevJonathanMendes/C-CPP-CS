// Fig. 3.11: Addition2.cs
// Um programa de soma.

using System;

class Addition2
{
	static void Main(string[] args)
	{
		Console.Write("Please enter the first integer: ");
		int num = Int32.Parse(Console.ReadLine());

		Console.Write("\nPlease enter the second integer: ");
		num += Int32.Parse(Console.ReadLine());

		Console.WriteLine("\nThe sum is {0}", num);
	}
}
