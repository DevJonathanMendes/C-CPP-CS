// 7.9: Arrays multidimensionais.
// Fig. 7.14: TwoDimensionalArray.
// int[,] b = new int[2, 2].
// int[,] b = {{2, 4}, {6, 8}}. Lista inicializadora.

using System;

static class Program
{
	static void Main(string[] args)
	{
		// Declaração e inicialização de array retangular.
		int[,] arr1 = new int[,] { { 2, 4 }, { 6, 8 } };

		// Declaração e inicialização de Array irregular.
		int[][] arr2 = new int[3][];
		arr2[0] = new int[] { 1, 2 };
		arr2[1] = new int[] { 3 };
		arr2[2] = new int[] { 4, 5, 6 };
	}
}
