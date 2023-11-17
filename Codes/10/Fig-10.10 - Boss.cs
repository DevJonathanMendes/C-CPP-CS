// Fig. 10.10: Boss.cs
// Classe Boss derivada de Employee.

using System;

// Cole a classe Employee (Fig-10.09 - Employee.cs) aqui.

public class Boss : Employee
{
	private decimal salary;

	public Boss(string firstNameValue, string lastNameValue,
		decimal salaryValue)
		: base(firstNameValue, lastNameValue)
	{
		WeeklySalary = salaryValue;
	}

	public decimal WeeklySalary
	{
		get { return salary; }
		set { if (value > 0) salary = value; }
	}

	// Sobrepõe o método da classe base para calcular os ganhos do chefe.
	public override decimal Earning()
	{ return WeeklySalary; }

	// Retorna a representação de string de Boss.
	public override string ToString()
	{ return "Boss: " + base.ToString(); }
}
