// Fig. 15.15: StringBuilderReplace.cs
// Demonstrando o método Replace.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderReplace
{
	[STAThread]
	static void Main(string[] args)
	{
		StringBuilder builder1 = new StringBuilder("Happy Birthday Jane");
		StringBuilder builder2 = new StringBuilder("good bye greg");

		string output = "Before replacement:\n" +
			builder1.ToString() + "\n" + builder2.ToString();

		builder1.Replace("Jane", "Greg");
		builder1.Replace("g", "G", 0, 5);

		output += "\n\nAfter replacement:\n" +
			builder1.ToString() + "\n" + builder2.ToString();

		MessageBox.Show(output,
			"Using StringBuilder method Replace",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
