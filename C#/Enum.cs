using System;

enum week
{
    monday = 2,
    tuesday = 4,
    wednesday = 99,
    thursday, // Vira 100.
    friday = 6,
    saturday = 8,
    sunday = 10,
    partyDay = saturday
}

class Program
{
    static void Main()
    {

        int monday = (int)week.monday;
        int thursday = (int)week.thursday;
        int partyDay = (int)week.partyDay;

        Console.WriteLine(monday);
        Console.WriteLine(thursday);
        Console.WriteLine(partyDay);
        Console.WriteLine(Enum.Format(typeof(week), monday, "G")); // "G" string, "x" hexadecimal, "d" decimal.
        Console.WriteLine(Enum.Format(typeof(week), week.wednesday, "G"));
        Console.WriteLine(Enum.GetName(typeof(week), monday));

        foreach (string str in Enum.GetNames(typeof(week)))
        { Console.WriteLine("dia: {0}", str); }

        Console.WriteLine("Tipo subjacente: {0}", Enum.GetUnderlyingType(typeof(week)));

        Console.WriteLine("Is monday on the enum?: {0}", Enum.IsDefined(typeof(week), "monday"));
    }
}