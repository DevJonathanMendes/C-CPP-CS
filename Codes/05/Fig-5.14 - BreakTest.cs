// Fig. 5.14: BreakTest.cs
// Usando a instrução break em uma estrutura for.

using System;
using System.Windows.Forms;

class BreakTest
{
	static void Main(string[] args)
	{
		string output = "";
		int count;

		for (count = 1; count <= 10; count++)
		{
			if (count == 5)
				break;

			output += count + " ";
		}

		output += "\nBroke out of loop at count = " + count;

		MessageBox.Show(output, "Demonstrating the break statement",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
