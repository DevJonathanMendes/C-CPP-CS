// Fig. 8.5: TimeTest2.cs
// Usando construtores sobrecarregados.

using System;
using System.Windows.Forms;

// Cole a classe Time2 (Fig-8.04 - Time2.cs) aqui.

class TimeTest2
{
	[STAThread]
	static void Main()
	{
		Time2 time1, time2, time3, time4, time5, time6;

		time1 = new Time2();
		time2 = new Time2(2);
		time3 = new Time2(21, 34);
		time4 = new Time2(12, 25, 42);
		time5 = new Time2(27, 74, 99);
		time6 = new Time2(time4);

		String output = "Constructed with: " +
			"\ntime1: all arguments defaulted" +
			"\n\t" + time1.ToUniversalString() +
			"\n\t" + time1.ToStandardString();

		output += "\ntime2: hour specified; minute and " +
			"second defaulted" +
			"\n\t" + time2.ToUniversalString() +
			"\n\t" + time2.ToStandardString();

		output += "\ntime3: hour and minute specified; " +
			"second defaulted" +
			"\n\t" + time3.ToUniversalString() +
			"\n\t" + time3.ToStandardString();

		output += "\ntime4: hour, minute and second specified" +
			"\n\t" + time4.ToUniversalString() +
			"\n\t" + time4.ToStandardString();

		output += "\ntime5: all invalid values specified" +
			"\n\t" + time5.ToUniversalString() +
			"\n\t" + time5.ToStandardString();

		output += "\ntime6: Time2 object time4 specified" +
			"\n\t" + time6.ToUniversalString() +
			"\n\t" + time6.ToStandardString();

		MessageBox.Show(output, "Demonstrating Overloaded Constructors");
	}
}
