// Fig. 15.9: StringMiscellaneous2.cs
// Demonstrando os métodos Replace, ToLower, ToUpper, Trim e ToString de String.

using System;
using System.Windows.Forms;

class StringMiscellaneous2
{
	[STAThread]
	static void Main()
	{
		string string1 = "cheers!";
		string string2 = "GOOD BYE ";
		string string3 = "   spaces   ";
		string output;

		output = "string1 = \"" + string1 + "\"\n" +
			"string2 = \"" + string2 + "\"\n" +
			"string3 = \"" + string3 + "\"";

		output +=
			"\n\nReplacing \"e\" with \"E\" in string1: \"" +
			string1.Replace('e', 'E') + "\"";

		output += "\n\nstring1.ToUpper() = \"" +
			string1.ToUpper() + "\"\nstring2.ToLower() = \"" +
			string2.ToLower() + "\"";

		output += "\n\nstring3 ater trim = \"" +
			string3.Trim() + "\"";

		output += "\n\nstring1 = \"" + string1.ToString() + "\"";

		MessageBox.Show(output, "Demonstrating various string methods",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
