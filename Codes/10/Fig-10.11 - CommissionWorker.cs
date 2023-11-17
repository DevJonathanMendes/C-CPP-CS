// Fig. 10.11: CommissionWorker.cs
// Classe CommissionWorker derivada de Employee.

using System;

// Cole a classe Employee (Fig-10.09 - Employee.cs) aqui.

// Cole a classe Boss (Fig-10.10 - Boss.cs) aqui.

public class CommissionWorker : Employee
{
	private decimal salary;
	private decimal commission;
	private int quantity;

	public CommissionWorker(string firstNameValue, string lastNameValue,
		decimal salaryValue, decimal commissionValue, int quantityValue)
		: base(firstNameValue, lastNameValue)
	{
		WeeklySalary = salaryValue;
		Commission = commissionValue;
		Quantity = quantityValue;
	}

	public decimal WeeklySalary
	{
		get { return salary; }
		set { if (value > 0) salary = value; }
	}

	public decimal Commission
	{
		get { return commission; }
		set { if (value > 0) commission = value; }
	}

	public int Quantity
	{
		get { return quantity; }
		set { if (value > 0) quantity = value; }
	}

	public override decimal Earning()
	{ return WeeklySalary + Commission * Quantity; }

	public override string ToString()
	{ return "Commission Worker: " + base.ToString(); }
}
