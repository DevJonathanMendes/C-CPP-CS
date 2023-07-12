// 8.8: Composição (ou agregação): Referenciar a objetos como variáveis de instância de outras classes.
// Referenciar objetos existentes é mais conveniente do que reescrever o código dos
// objetos para novas classes em novos projetos.
// (encapsulamento)

using System;

public class Time3 : Object
{
	private int hour;   // 0 a 23.
	private int minute; // 0 a 59.
	private int second; // 0 a 59.

	// GET E SET.
	public int Hour
	{
		get { return hour; }
		set { hour = ((value >= 0 && value < 24) ? value : 0); }
	}

	public int Minute
	{
		get { return minute; }
		set { minute = ((value >= 0 && value < 60) ? value : 0); }
	}

	public int Second
	{
		get { return second; }
		set { second = ((value >= 0 && value < 60) ? value : 0); }
	}

	// Inicializa como zero, padrão meia-noite.
	public Time3()
	{ SetTime(0, 0, 0); }

	// Inicializa hora.
	public Time3(int hour)
	{ SetTime(hour, 0, 0); }

	// Inicializa hora, minuto.
	public Time3(int hour, int minute)
	{ SetTime(hour, minute, 0); }

	// Inicializa hora, minuto e segundo.
	public Time3(int hour, int minute, int second)
	{ SetTime(hour, minute, second); }

	// Inicializa usando outro objeto Time3.
	public Time3(Time3 time)
	{ SetTime(time.hour, time.minute, time.second); }

	// Verifica os valores e os configura. Se inválidos, seta como 0.
	public void SetTime(int h, int m, int s)
	{
		hour = (h >= 0 && h < 24) ? h : 0;
		minute = (m >= 0 && m < 60) ? m : 0;
		second = (s >= 0 && s < 60) ? s : 0;
	}

	// Converte a hora para a string de formato de hora universal (24h).
	public string ToUniversalString()
	{
		return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
	}

	// Converte a hora para a string de formato de hora padrão (12h).
	public string ToStandardString()
	{
		return String.Format("{0}:{1:D2}:{2:D2} {3}",
			((hour == 12 || hour == 0) ? 12 : hour % 12),
			minute, second, (hour < 12 ? "AM" : "PM")
		);
	}
}

public class Date
{
	private int day, month, year;

	public Date(int theDay, int theMonth, int theYear)
	{
		if (theMonth > 0 && theMonth <= 12)
			month = theMonth;
		else
		{
			month = 1;
			Console.WriteLine($"Month {theMonth} invalid. Set to month {month}.");
		};

		day = theDay;
		year = theYear;
	}

	private int CheckDay(int testDay)
	{
		int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		if (testDay > 0 && testDay <= dayPerMonth[month])
			return testDay;

		if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
			return day;

		day = 1;
		Console.WriteLine($"Day {day} invalid. Set to day {day}");
		return day;
	}

	public override string ToString()
	{
		return $"{day}/{month:D2}/{year}";
	}
}

// Faz encapsulamento.
public class Employee
{
	private string firstName, lastName;
	private Date hireDate;

	public Employee(string first, string last)
	{
		firstName = first;
		lastName = last;

		hireDate = new Date(18, 01, 2001);
	}

	public string EmployeeToString()
	{
		return $"First name: {firstName}\nLast name:{lastName:2D}\nHire date: {hireDate}";
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Employee emp = new Employee("John", "Jones");
		Console.WriteLine(emp.EmployeeToString());
	}
}
