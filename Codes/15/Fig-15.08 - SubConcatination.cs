// Fig. 15.8: SubConcatination.cs
// Demonstrando o método Concat da classe String.

using System;
using System.Windows.Forms;

class SubConcatination
{
	[STAThread]
	static void Main()
	{
		string string1 = "Happy ";
		string string2 = "Birthday";
		string output;

		output = "string1 = \"" + string1 + "\"\n" +
			"string2 = \"" + string2 + "\"";

		output +=
			"\n\nResult of String.Concat(string1, string2) = " +
			String.Concat(string1, string2);

		output += "\nstring1 after concatenation = " + string1;

		MessageBox.Show(output, "Demonstrating String method Concat",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
