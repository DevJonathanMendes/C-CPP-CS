// Fig. 5.15: ContinueTest.cs
// Usando a instrução continue em uma estrutura for.

using System;
using System.Windows.Forms;

class ContinueTest
{
	static void Main(string[] args)
	{
		string output = "";

		for (int count = 1; count <= 10; count++)
		{
			if (count == 5)
				continue;

			output += count + " ";
		}

		output += "\nUsed continue to skip printing 5";

		MessageBox.Show(output, "Demonstrating the continue statement",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
