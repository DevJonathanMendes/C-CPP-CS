// Fig. 15.2: StringMethods.cs
// Usando o indexador, a propriedade Length e o método CopyTo da classe String.

using System;
using System.Windows.Forms;

class StringMethods
{
	[STAThread]
	static void Main(string[] args)
	{
		string string1, output;
		char[] characterArray;

		string1 = "hello there";
		characterArray = new char[5];

		output = "string1: \"" + string1 + "\"";

		output += "\nLength of string1: " + string1.Length;

		output += "\nThe string reversed is: ";

		for (int i = string1.Length - 1; i >= 0; i--)
			output += string1[i];

		string1.CopyTo(0, characterArray, 0, 5);
		output += "\nThe character array is: ";

		for (int i = 0; i < characterArray.Length; i++)
			output += characterArray[i];

		MessageBox.Show(output, "Demonstrating the string Indexer " +
			"Length Property and CopyTo method",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
