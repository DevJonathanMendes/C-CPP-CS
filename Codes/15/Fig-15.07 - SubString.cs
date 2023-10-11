// Fig. 15.7: SubString.cs
// Demonstrando o método Substring de String.

using System;
using System.Windows.Forms;

class SubString
{
	[STAThread]
	static void Main()
	{
		string letters = "abcdefghijklmabcdefghijklm";
		string output = "";

		output += "Substring from index 20 to end is \"" +
			letters.Substring(20) + "\"\n";

		output += "Substring form index 0 to 6 is \"" +
			letters.Substring(0, 6) + "\"";

		MessageBox.Show(output, "Demonstrating String method Substring ",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
