// Fig. 8.2: TimeTest1.cs
// Demonstrando a classe Time1.

using System;
using System.Windows.Forms;

// Cole a classe Time1 (Fig-8.01 - Time1.cs) aqui.

class TimeTest1
{
	[STAThread]
	static void Main()
	{
		Time1 time = new Time1(); // Chama o construtor de Time1.
		string output;

		// Atribui a representação de string de time a output.
		output = "Initial universal time is: " +
			time.ToUniversalString() +
			"\nInitial standard time is: " +
			time.ToStandardString();

		// Tenta configurações de hora válidas.
		time.SetTime(13, 27, 6);

		output += "\n\nUniversal time after SetTime is: " +
			time.ToUniversalString() +
			"\nStandard time after SetTime is: " +
			time.ToStandardString();

		// Tenta configurações de hora inválidas.
		time.SetTime(99, 99, 99);

		output += "\n\nAfter attempting invalid settings: " +
			"\nUniversal time: " + time.ToUniversalString() +
			"\nStandard time: " + time.ToStandardString();

		MessageBox.Show(output, "Testing Class Time1");
	}
}
