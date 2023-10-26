// Fig. 15.14: StringBuilderInsertRemove.cs
// Demonstrando os métodos Insert e Remove da classe StringBuilder.

using System;
using System.Text;
using System.Windows.Forms;

class StringBuilderInsertRemove
{
	[STAThread]
	static void Main(string[] args)
	{
		object objectValue = "hello";
		string stringValue = "good bye";
		char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

		bool booleanValue = true;
		char characterValue = 'K';
		int integerValue = 7;
		long longValue = 1000000;
		float floatValue = 2.5F;
		double doubleValue = 33.333;
		StringBuilder buffer = new StringBuilder();
		string output;

		buffer.Insert(0, objectValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, stringValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, characterArray);
		buffer.Insert(0, "  ");
		buffer.Insert(0, booleanValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, characterValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, integerValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, longValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, floatValue);
		buffer.Insert(0, "  ");
		buffer.Insert(0, doubleValue);
		buffer.Insert(0, "  ");

		output = "buffer after inserts: \n" +
			buffer.ToString() + "\n\n";

		buffer.Remove(10, 1); // Exclui 2 em 2.5.
		buffer.Remove(2, 4); // Exclui .333 em 33.333.

		output += "buffer after Removes:\n" +
			buffer.ToString();

		MessageBox.Show(output, "demonstrating StringBuilder " +
			"Insert e Remove methods", MessageBoxButtons.OK,
			MessageBoxIcon.Information);
	}
}
