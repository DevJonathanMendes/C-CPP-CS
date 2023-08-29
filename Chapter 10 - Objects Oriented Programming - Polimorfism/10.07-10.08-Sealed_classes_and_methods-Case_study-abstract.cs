// 10.07: Classes e métodos sealed.
// A palavra chave "sealed" é aplicada nos métodos
// e nas classes para impedir sobreposição e herança.

// 10.08: Estudo de caso: Sistema de folha de pagamento usando polimorfismo.
// Vamos usar classes abstract, métodos abstract e polimorfismo para efetuar
// cálculos de folha de pagamento para vários tipos de funcionários.

using System;

public abstract class Employee
{
	private string firstName;
	private string lastName;

	public Employee(string fNameValue, string lNameValue)
	{
		FirstName = fNameValue;
		LastName = lNameValue;
	}

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}

	public override string ToString()
	{ return $"{FirstName} {LastName}"; }

	// Método abstrato que deve ser implementado para cada classe
	// derivada de Employee para calcular os ganhos específicos.
	public abstract decimal Earning();
}

public class Boss : Employee
{
	private decimal salary;

	public Boss(string fNameValue, string lNameValue, decimal salaryValue)
	: base(fNameValue, lNameValue)
	{ WeeklySalary = salaryValue; }

	public decimal WeeklySalary
	{
		get { return salary; }
		set { if (value > 0) salary = value; }
	}

	public override decimal Earning()
	{ return WeeklySalary; }

	public override string ToString()
	{ return $"Boss: {base.ToString()}"; }
}

public class CommissionWorker : Employee
{
	private decimal salary, commission;
	private int quantity;

	public CommissionWorker(string fNameValue, string lNameValue,
	decimal salaryValue, decimal commissionValue, int quantityValue)
	: base(fNameValue, lNameValue)
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
	{ return $"Commission Worker: {base.ToString()}"; }
}

public class PieceWorker : Employee
{
	private decimal wagePerPiece;
	private int quantity;

	public PieceWorker(string fNameValue, string lNameValue,
	decimal wagePerPieceValue, int quantityValue)
: base(fNameValue, lNameValue)
	{
		WagePerPiece = wagePerPieceValue;
		Quantity = quantityValue;
	}

	public decimal WagePerPiece
	{
		get { return wagePerPiece; }
		set { if (value > 0) wagePerPiece = value; }
	}

	public int Quantity
	{
		get { return quantity; }
		set { if (value > 0) quantity = value; }
	}

	public override decimal Earning()
	{ return Quantity * WagePerPiece; }

	public override string ToString()
	{ return $"Piece Worker: {base.ToString()}"; }
}

public class HourlyWorker : Employee
{
	private decimal wage;
	private double hoursWorked;

	public HourlyWorker(string fNameValue, string lNameValue,
	decimal wageValue, double hoursWorkedValue)
: base(fNameValue, lNameValue)
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
	{ return $"Hourly Worker: {base.ToString()}"; }
}

static class Program
{
	static void Main(string[] args)
	{
		Boss boss = new Boss("John", "Smith", 800);
		CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jones", 400, 3, 150);
		PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", Convert.ToDecimal(2.5), 200);
		HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price", Convert.ToDecimal(13.75), 50);

		Employee employee = boss;

		Console.WriteLine("Demonstrating Polymorphism\n");
		Console.WriteLine($"{boss} earned {boss.Earning().ToString("C")}");
		Console.WriteLine($"{GetString(commissionWorker)}");
		Console.WriteLine($"{GetString(pieceWorker)}");
		Console.WriteLine($"{GetString(hourlyWorker)}");

		static string GetString(Employee worker)
		{
			return $"{worker.ToString()} earned {worker.Earning().ToString("C")}";
		}
	}
}
