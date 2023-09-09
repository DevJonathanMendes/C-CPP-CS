// Fig. 4.7: Average1.cs
// Média da turma com repetição controlada por contador.

using System;

class Average1
{
	static void Main(string[] args)
	{
		int total,
				gradeCounter,
				gradeValue,
				average;

		total = 0;
		gradeCounter = 1;

		while (gradeCounter <= 10)
		{
			Console.Write("Enter integer grade: ");
			gradeValue = Int32.Parse(Console.ReadLine());

			total = total + gradeValue;

			gradeCounter = gradeCounter + 1;
		}

		average = total / 10;

		Console.WriteLine("\nClass average is {0}", average);
	}
}
