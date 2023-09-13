// Fig. 5.10: SwitchTest.cs
// Contando notas.

using System;

static class SwitchTest
{
	static void Main(string[] args)
	{
		char grade;
		int aCount = 0,
				bCount = 0,
				cCount = 0,
				dCount = 0,
				fCount = 0;

		for (int i = 1; i <= 10; i++)
		{
			Console.Write("Enter a letter grade: ");
			grade = Char.Parse(Console.ReadLine());

			switch (grade)
			{
				case 'A':
				case 'a':
					++aCount;
					break;
				case 'B':
				case 'b':
					++bCount;
					break;
				case 'C':
				case 'c':
					++cCount;
					break;
				case 'D':
				case 'd':
					++dCount;
					break;
				case 'F':
				case 'f':
					++fCount;
					break;

				default:
					Console.WriteLine(
						"Incorrect letter grade entered:" +
						"\nGrade not added to totals.");
					break;
			}
		}

		Console.WriteLine(
			"\nTotals for each letter grade are:\nA: {0}" +
			"\nB: {1}\nC: {2}\nD: {3}\nF: {4}", aCount, bCount,
			cCount, dCount, fCount);
	}
}
