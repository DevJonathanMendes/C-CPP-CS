// Fig. 7.5: StudentPoll.cs
// Um programa de pesquisa de alunos.

using System;
using System.Windows.Forms;

public class StudentPoll : Form
{
	static void Main(string[] args)
	{
		int[] responses = {
			1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 6, 3, 8, 6,
			10, 1, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7,
			5, 6, 6, 5, 6, 7, 5, 6, 4, 8, 6, 8, 10
		};

		int[] frequency = new int[11];
		string output = "";

		for (int answer = 0; answer < responses.Length; answer++)
			++frequency[responses[answer]];

		output += "Rating\tFrequency\n";

		for (int rating = 1; rating < frequency.Length; rating++)
			output += rating + "\t" + frequency[rating] + "\n";

		MessageBox.Show(output, "Student poll program",
			MessageBoxButtons.OK, MessageBoxIcon.Information
		);
	}
}
