// Fig. 8.10: CompositionTest.cs
// Demonstra um objeto com referência a um objeto membro.

using System;
using System.Windows.Forms;

// Cole a classe Date (Fig-8.08 - Date.cs) aqui.

// Cole a classe Employee (Fig-8.09 - Employee.cs) aqui.

partial class CompositionTest
{
	[STAThread]
	static void Main(string[] args)
	{
		Employee e = new Employee("Bob", "Jones", 7, 34, 1949, 3, 12, 1988);

		MessageBox.Show(e.ToEmployeeString(),
			"Testing Class Employee");
	}
}
