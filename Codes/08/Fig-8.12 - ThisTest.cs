// Fig. 8.12: ThisTest.cs
// Usando a referência this.

using System;
using System.Windows.Forms;

// Cole a classe Time4 (Fig-8.11 - Time4.cs) aqui.

class ThisTest
{
	static void Main(string[] args)
	{
		Time4 time = new Time4(12, 30, 19);

		MessageBox.Show(time.BuildString(),
			"Demonstrating the \"this\" Reference");
	}
}
