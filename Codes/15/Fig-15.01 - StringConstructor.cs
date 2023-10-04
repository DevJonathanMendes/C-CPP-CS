// Fig. 15.1: StringConstructor.cs
// Demonstrando construtores da classe String.

using System;
using System.Windows.Forms;

class StringConstructor
{
	[STAThread]
	static void Main(string[] args)
	{
		string output;
		string originalString, string1, string2, string3, string4;
		char[] characterArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };

		// Inicialização das strings.
		originalString = "Welcome to C# programming!";
		string1 = originalString;
		string2 = new string(characterArray);
		string3 = new string(characterArray, 6, 3);
		string4 = new string('C', 5);

		output = "string1 = " + "\"" + string1 + "\"\n" +
			"string2 = " + "\"" + string2 + "\"\n" +
			"string3 = " + "\"" + string3 + "\"\n" +
			"string4 = " + "\"" + string4 + "\"\n";

		MessageBox.Show(output, "String Class Constructors",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
