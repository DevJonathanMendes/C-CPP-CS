// Fig. 15.20: RegexMatches.cs
// Demonstrando a classe Regex.

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

class RegexMatches
{
	[STAThread]
	static void Main(string[] args)
	{
		string output = "";

		Regex expression = new Regex(@"J.*\d[0-35-9]-\d\d-\d\d");

		string string1 = "Jane's Birthday is 05-12-75\n" +
			"Dave's Birthday is 11-04-68\n" +
			"John's Birthday is 04-28-73\n" +
			"Joe's Birthday is 12-17-77";

		// Faz a correspondência entre a expressão regular e a string e
		// imprime todos os resultados obtidos.
		foreach (Match myMatch in expression.Matches(string1))
			output += myMatch.ToString() + "\n";

		MessageBox.Show(output, "Using class Regex",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
