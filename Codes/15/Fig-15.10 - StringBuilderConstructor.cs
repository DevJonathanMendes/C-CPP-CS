// Fig. 15.10: StringBuilderConstructor.cs
// Demonstrando os construtores da classe StringBuilder.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderConstructor
{
	[STAThread]
	static void Main()
	{
		StringBuilder buffer1, buffer2, buffer3;
		string output;

		buffer1 = new StringBuilder();
		buffer2 = new StringBuilder(10);
		buffer3 = new StringBuilder("hello");

		output = "buffer1 = \"" + buffer1.ToString() + "\"\n";
		output += "buffer2 = \"" + buffer2.ToString() + "\"\n";
		output += "buffer3 = \"" + buffer3.ToString() + "\"\n";

		MessageBox.Show(output,
			"Demonstrating StringBuilder class constructor",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
