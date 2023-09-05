// Fig. 4.11: Analysis.
// Análise dos resultados do exame.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int passes = 0, failures = 0, student = 1, result;

		while (student <= 10)
		{
			Console.Clear();
			Console.WriteLine("Enter result (1=pass, 2=fail)");
			result = Int32.Parse(Console.ReadLine());

			if (result == 1)
				passes++;
			else
				failures++;

			student++;
		}
		Console.Clear();
		Console.WriteLine("Passed: " + passes);
		Console.WriteLine($"Failed: {failures}");

		if (passes > 8)
			Console.WriteLine("Raises Tuition\n");
	}
}
