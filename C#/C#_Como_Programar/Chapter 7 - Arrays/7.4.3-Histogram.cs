// 7.4.3: Usando histograma.
// Fig. 7.5: Histogram.
// Usando dados para criar um histograma.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int[] n = { 19, 3, 15, 7, 11, 9 };
		string output = "Element\tValue\tHistogram";

		for (int i = 0; i < n.Length; i++)
		{
			output += $"\n{i}\t{n[i]}\t";

			for (int j = 0; j < n[i]; j++)
			{
				output += "*";
			}
		}

		Console.WriteLine(output);
	}
}
