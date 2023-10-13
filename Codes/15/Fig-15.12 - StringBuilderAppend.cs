// Fig. 15.12: StringBuilderAppend.cs
// Demonstrando os métodos Append de StringBuilder.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderAppend
{
	[STAThread]
	static void Main()
	{
		object objectValue = "hello";
		string stringValue = "good bye";
		char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

		bool boolValue = true;
		char characterValue = 'Z';
		int integerValue = 7;
		long longValue = 1000000;
		float floatValue = 2.5F;
		double doubleValue = 33.33;
		StringBuilder buffer = new StringBuilder();

		buffer.Append(objectValue);
		buffer.Append("  ");
		buffer.Append(stringValue);
		buffer.Append("  ");
		buffer.Append(characterArray);
		buffer.Append("  ");
		buffer.Append(characterArray, 0, 3);
		buffer.Append("  ");
		buffer.Append(boolValue);
		buffer.Append("  ");
		buffer.Append(characterValue);
		buffer.Append("  ");
		buffer.Append(integerValue);
		buffer.Append("  ");
		buffer.Append(longValue);
		buffer.Append("  ");
		buffer.Append(floatValue);
		buffer.Append("  ");
		buffer.Append(doubleValue);

		MessageBox.Show("buffer = " + buffer.ToString(),
			"Demonstrating StringBuilder append method",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
