// Fig 8.8: Date.cs.
// A definição da classe Date encapsula dia, mês e ano.

namespace console;

using System;

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
            Console.WriteLine($"Month{theMonth} is invalid. Set to month 1.");
        }

        if (theYear > 1900 && theMonth <= 2150)
            year = theYear;
        else
        {
            year = 1;
            Console.WriteLine($"Year {theYear} is invalid. Set to year 1900.");
        }

        day = checkDay(theDay);
    }

    private int checkDay(int testDay)
    {
        int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (testDay > 0 && testDay <= daysPerMonth[month])
            return testDay;

        if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            return testDay;

        Console.WriteLine($"Day {testDay} invalid. Set to day 1.");
        return 1;
    }

    public string ToDateString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }
}