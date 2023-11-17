// Fig. 10.13: HourlyWorker.cs
// A classe HourlyWorker derivada de Employee.

using System;

// Cole a classe Employee (Fig-10.09 - Employee.cs) aqui.

// Cole a classe Boss (Fig-10.10 - Boss.cs) aqui.

// Cole a classe CommissionWorker (Fig-10.11 - CommissionWorker.cs) aqui.

// Cole a classe PieceWorker (Fig-10.12 - PieceWorker.cs) aqui.

public class HourlyWorker : Employee
{
	private decimal wage;
	private double hoursWorked;

	public HourlyWorker(string firstNameValue, string lastNameValue,
		decimal wageValue, double hoursWorkedValue)
		: base(firstNameValue, lastNameValue)
	{
		Wage = wageValue;
		HoursWorked = hoursWorkedValue;
	}

	public decimal Wage
	{
		get { return wage; }
		set { if (value > 0) wage = value; }
	}

	public double HoursWorked
	{
		get { return hoursWorked; }
		set { if (value > 0) hoursWorked = value; }
	}

	public override decimal Earning()
	{
		if (HoursWorked <= 40)
		{
			return Wage * Convert.ToDecimal(HoursWorked);
		}
		else
		{
			decimal basePay = Wage * Convert.ToDecimal(40);
			decimal overtimePay = Wage * 1.5M * Convert.ToDecimal(HoursWorked - 40);
			return basePay + overtimePay;
		}
	}

	public override string ToString()
	{
		return "Hourly Worker: " + base.ToString();
	}
}
