// Fig. 4.9: Average2.cs
// Média da turma com repetição controlada por sentinela.

using System;

class Average2
{
	static void Main(string[] args)
	{
		int total,
				gradeCounter,
				gradeValue;

		double average;

		total = 0;
		gradeCounter = 0;

		Console.Write("Enter Integer Grade, -1 to Quit: ");
		gradeValue = Int32.Parse(Console.ReadLine());

		while (gradeValue != -1)
		{
			total = total + gradeValue;

			gradeCounter = gradeCounter + 1;

			Console.Write("Enter Integer Grade, -1 to Quit: ");
			gradeValue = Int32.Parse(Console.ReadLine());
		}

		if (gradeCounter != 0)
		{
			average = (double)total / gradeCounter;
			Console.WriteLine("\nClass average is {0}", average);
		}
		else
			Console.WriteLine("No grades were entered.");
	}
}
