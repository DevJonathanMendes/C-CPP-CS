// Fig. 15.3: StringCompare.cs
// Comparando strings.

using System;
using System.Windows.Forms;

class StringCompare
{
	[STAThread]
	static void Main(string[] args)
	{
		string string1 = "hello";
		string string2 = "good bye";
		string string3 = "Happy Birthday";
		string string4 = "happy birthday";
		string output;

		output =
			"string1 = \"" + string1 + "\"" +
			"\nstring2 = \"" + string2 + "\"" +
			"\nstring3 = \"" + string3 + "\"" +
			"\nstring4 = \"" + string4 + "\"" + "\n\n";

		// Testa a igualdade usando o método Equals.
		if (string1.Equals("hello"))
			output += "string1 equals \"hello\"\n";
		else
			output += "string1 does not equal \"hello\"\n";

		// Testa a igualdade com ==.
		if (string1 == "hello")
			output += "string1 equals \"hello\"\n";
		else
			output += "string1 does not equal \"hello\"\n";

		// Testa a igualdade levando em conta diferenças entre letras maiúsculas e minúsculas.
		if (String.Equals(string3, string4))
			output += "string3 equals string4\n";
		else
			output += "string3 does not equal string4\n";

		// Testa CompareTo.
		output +=
			"\nstring1.CompareTo(string2) is " +
			string1.CompareTo(string2) + "\n" +
			"string2.CompareTo(string1) is " +
			string2.CompareTo(string1) + "\n" +
			"string1.CompareTo(string1) is " +
			string1.CompareTo(string1) + "\n" +
			"string3.CompareTo(string4) is " +
			string3.CompareTo(string4) + "\n" +
			"string4.CompareTo(string3) is " +
			string4.CompareTo(string3) + "\n";

		MessageBox.Show(output, "Demonstrating string " +
			"Comparisons", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
