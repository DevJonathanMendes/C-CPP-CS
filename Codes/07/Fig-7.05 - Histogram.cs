// Fig. 7.5: Histogram.cs
// Usando dados para criar um Histograma.

using System;
using System.Windows.Forms;

public class Histogram : Form
{
	static void Main(string[] args)
	{
		int[] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };
		string output = "";

		output += "Element\tValue\tHistogram\n";

		for (int i = 0; i < n.Length; i++)
		{
			output += "\n" + i + "\t" + n[i] + "\t";

			for (int j = 1; j <= n[i]; j++)
				output += "*";
		}

		MessageBox.Show(output, "Histogram Printing Program",
			MessageBoxButtons.OK, MessageBoxIcon.Information
		);
	}
}
