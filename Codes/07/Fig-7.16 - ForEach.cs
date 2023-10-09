// Fig. 7.16: ForEach.cs
// Demonstrando a estrutura for/each;

using System;

class ForEach
{
	static void Main(string[] args)
	{
		int[,] gradeArray = {{ 77, 68, 86, 73 },
			{ 98, 87, 89, 81 }, { 70, 90, 86, 81 }};

		int lowGrade = 100;

		foreach (int grade in gradeArray)
			if (grade < lowGrade)
				lowGrade = grade;

		Console.WriteLine("The minimum grade is: " + lowGrade);
	}
}
