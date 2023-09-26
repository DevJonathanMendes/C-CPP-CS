// Fig. 7.3: InitArray.cs
// Diferentes maneiras de inicializar arrays.

using System;
using System.Windows.Forms;

public class InitArray : Form
{
	static void Main(string[] args)
	{

		string output = "";

		int[] x;
		x = new int[10];

		// A lista inicializadora especifica o número de elementos
		// e o valor de cada elemento.
		int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

		const int ARRAY_SIZE = 10;
		int[] z;

		z = new int[ARRAY_SIZE];

		// Configura os valores no array.
		for (int i = 0; i < z.Length; i++)
			z[i] = 2 + 2 * i;

		output += "Subscript\tArray x\tArray y\tArray z\n";

		for (int i = 0; i < ARRAY_SIZE; i++)
			output += i + "\t\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n";

		MessageBox.Show(output,
			"Initializing an array of int values",
			MessageBoxButtons.OK, MessageBoxIcon.Information
		);
	}
}
