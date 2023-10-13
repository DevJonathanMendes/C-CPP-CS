// Fig. 15.11: StringBuilderFeatures.cs
// Demonstrando alguns recursos da classe StringBuilder.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderFeatures
{
	[STAThread]
	static void Main()
	{
		StringBuilder buffer = new StringBuilder("Hello, how are you?");

		// Usa as propriedades Length e Capacity.
		string output = "buffer = " + buffer.ToString() +
			"\nLength = " + buffer.Length +
			"\nCapacity = " + buffer.Capacity;

		// Usa o método EnsureCapacity.
		buffer.EnsureCapacity(75);

		output += "\n\nNew capacity = " +
			buffer.Capacity;

		// Trunca StringBuilder, configurando a propriedade Length.
		buffer.Length = 10;

		output += "\n\nNew length = " +
			buffer.Length + "\nbuffer = ";

		for (int i = 0; i < buffer.Length; i++)
			output += buffer[i];

		MessageBox.Show(output, "StringBuilder features",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
