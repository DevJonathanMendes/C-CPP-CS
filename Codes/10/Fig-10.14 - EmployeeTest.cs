// Fig. 10.14: EmployeeTest.cs
// Demonstra o polimorfismo exibindo os vencimentos
// de vários tipos de funcionários.

using System;
using System.Windows.Forms;

// Cole a classe Employee (Fig-10.09 - Employee.cs) aqui.

// Cole a classe Boss (Fig-10.10 - Boss.cs) aqui.

// Cole a classe CommissionWorker (Fig-10.11 - CommissionWorker.cs) aqui.

// Cole a classe PieceWorker (Fig-10.12 - PieceWorker.cs) aqui.

// Cole a classe HourlyWorker (Fig-10.13 - HourlyWorker.cs) aqui.

public class EmployeeTest
{
	public static void Main(string[] args)
	{
		Boss boss = new Boss("John", "Smith", 800);

		CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jones", 400, 3, 150);

		PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", Convert.ToDecimal(2.5), 200);

		HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price", Convert.ToDecimal(13.75), 50);

		Employee employee = boss;
		string output = GetString(employee);

		employee = commissionWorker;
		output += GetString(employee);

		employee = pieceWorker;
		output += GetString(employee);

		employee = hourlyWorker;
		output += GetString(employee);

		MessageBox.Show(output, "Demonstrating Polymorphism");
	}

	public static string GetString(Employee worker)
	{
		return worker.ToString() + " earned " + worker.Earning().ToString("C") + "\n\n";
	}
}
