// Fig. 8.8: Date.cs
// A definição da classe Date encapsula mês, dia e ano.

using System;

public class Date
{
	private int month;  // 1 a 12.
	private int day;    // 1 a 31 baseado no mês.
	private int year;   // Qualquer ano.

	public Date(int theMonth, int theDay, int theYear)
	{
		if (theMonth > 0 && theMonth <= 12)
			month = theMonth;
		else
		{
			month = 1;
			Console.WriteLine("Month {0} invalid. Set to month 1.", theMonth);
		}

		year = theYear;
		day = CheckDay(theDay);
	}

	private int CheckDay(int testDay)
	{
		int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		if (testDay > 0 && testDay <= daysPerMonth[month])
			return testDay;
		if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
			return testDay;

		Console.WriteLine("Day {0} invalid. Set to day 1.", testDay);
		return 1;
	}

	public string ToDateString()
	{ return month + "/" + day + "/" + year; }
}
