// Fig. 15.6: StringIndexMethods.cs
// Usando métodos de busca de String.

using System;
using System.Windows.Forms;

class StringIndexMethods
{
	[STAThread]
	static void Main()
	{
		string letters = "abcdefghijklmabcdefghijklm";
		string output = "";
		char[] searchLetters = { 'c', 'a', '$' };

		// Testa IndexOf para localizar um caractere em uma string.
		output += "'c' is located at index " +
			letters.IndexOf('c');

		output += "\n'a' is located at index " +
			letters.IndexOf('a', 1);

		output += "\n'$' is located at index " +
			letters.IndexOf('$', 3, 5);

		// Testa LastIndexOf para localizar um caractere em uma string.
		output += "\n\nLast 'c' is located at index " +
			letters.LastIndexOf('c');

		output += "\nLast 'a' is located at index " +
			letters.LastIndexOf('a', 25);

		output += "\nLast '$' is located at index " +
			letters.LastIndexOf('$', 15, 5);

		// Testa IndexOf para localizar uma substring em uma string.
		output += "\n\n\"def\" is located at" +
			" index " + letters.IndexOf("def");

		output += "\n\"def\" is located at" +
			" index " + letters.IndexOf("def", 7);

		output += "\n\"hello\" is located at index " +
			letters.IndexOf("hello", 5, 15);

		// Testa LastIndexOf para localizar uma substring em uma string.
		output += "\n\nLast \"def\" is located " +
			" index " + letters.LastIndexOf("def");

		output += "\nLast \"def\" is located at " +
			letters.LastIndexOf("def", 25);

		output += "\nLast \"hello\" is located at index " +
			letters.LastIndexOf("hello", 20, 15);

		// Testa IndexOfAny para localizar a primeira ocorrência do caractere no array.
		output += "\n\nFirst occurrence of 'c', 'a', '$' is " +
			"located at " + letters.IndexOfAny(searchLetters);

		output += "\nFirst occurrence of 'c', 'a' ou '$' is " +
			"located at " + letters.IndexOfAny(searchLetters, 7);

		output += "\nFirst occurrence of 'c', 'a' ou '$' is " +
			"located at " + letters.IndexOfAny(searchLetters, 20, 5);

		// Testa IndexOfAny para localizar a última ocorrência do caractere no array.
		output += "\n\nLast occurrence of 'c', 'a' ou '$' is " +
			"located at " + letters.LastIndexOfAny(searchLetters);

		output += "\nLast occurrence of 'c', 'a' ou '$' is " +
			"located at " + letters.LastIndexOfAny(searchLetters, 1);

		output += "\nLast occurrence of 'c', 'a' ou '$' is " +
			"located at " + letters.LastIndexOfAny(searchLetters, 25, 5);

		MessageBox.Show(output, "Demonstrating class index methods",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
