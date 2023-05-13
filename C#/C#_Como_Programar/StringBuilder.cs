using System;
using System.Text; // StringBuilder.


class Program
{
    static void Main()
    {
        string str1 = "str1";
        StringBuilder str2 = new StringBuilder("str2"); // Mais eficiente.

        Console.WriteLine(str1);
        Console.WriteLine(str2.Capacity.ToString());
    }
}
