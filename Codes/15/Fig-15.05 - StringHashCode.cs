// Fig. 15.5: StringHashCode.cs
// Demonstrando o método GetHashCode da classe String.

using System;
using System.Windows.Forms;

class StringHashCode
{
	[STAThread]
	static void Main()
	{
		string string1 = "hello";
		string string2 = "Hello";
		string output;

		output = "The hash code for \"" + string1 +
			"\" is " + string1.GetHashCode() + "\n";

		output += "The hash code for \"" + string2 +
			"\" is " + string2.GetHashCode() + "\n";

		MessageBox.Show(output, "Demonstrating String " +
			"method GetHashCode", MessageBoxButtons.OK,
			MessageBoxIcon.Information);
	}
}
