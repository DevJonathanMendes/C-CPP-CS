// Fig. 15.13: StringBuilderAppendFormat.cs
// Demonstrando o método AppendFormat.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderAppendFormat
{
	[STAThread]
	static void Main()
	{
		StringBuilder buffer = new StringBuilder();
		string string1, string2;

		string1 = "This {0} costs: {1:C}.\n";

		object[] objectArray = new object[2];

		objectArray[0] = "car";
		objectArray[1] = 1234.56;

		buffer.AppendFormat(string1, objectArray);

		string2 = "Number:{0:d3}.\n" +
			"Number right aligned with spaces:{0, 4}.\n" +
			"Number left aligned with spaces:{0, -4}.";

		buffer.AppendFormat(string2, 5);

		MessageBox.Show(buffer.ToString(), "Using AppendFormat",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
