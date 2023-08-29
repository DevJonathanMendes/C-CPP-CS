// 7.9: Structure Foreach.
// Para fazer iteração por valores em estrutura de dados, como arrays.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int[,] arr1 = new int[,] { { 2, 4 }, { 6, 8 } };

		foreach (var item in arr1)
			Console.WriteLine(item);
	}
}
