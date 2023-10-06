// Fig. 15.4: StringStartEnd.cs
// Demonstrando os métodos StartsWith e EndsWith.

using System;
using System.Windows.Forms;

class StringStartEnd
{
	[STAThread]
	static void Main(string[] args)
	{
		string[] strings = { "started", "starting", "ended", "ending" };
		string output = "";

		// Testa cada string para ver se ela começa com "st".
		for (int i = 0; i < strings.Length; i++)
			if (strings[i].StartsWith("st"))
				output += "\"" + strings[i] + "\"" +
				" starts with \"st\"\n";

		output += "\n";

		// Testa cada string para ver se ela termina com "ed".
		for (int i = 0; i < strings.Length; i++)
			if (strings[i].EndsWith("ed"))
				output += "\"" + strings[i] + "\"" +
				" ends with \"ed\"\n";

		MessageBox.Show(output, "Demonstrating StartsWith and " +
			"EndsWith methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
