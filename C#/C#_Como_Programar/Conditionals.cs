// Conditionals

using System;

class Program
{
    static void Main()
    {
        int expression = 1;

        if (expression == 1)
        {
            Console.WriteLine("Implementation");
            if (expression != 1)
            { Console.WriteLine("Implementation"); }
            else if (expression == 2)
            { Console.WriteLine("Implementation"); }
            else
            { Console.WriteLine("Implementation"); }
        }

        switch (expression)
        {
            case 0: Console.WriteLine("Implementation"); break;
            case 1: Console.WriteLine("Implementation"); break;
            default: Console.WriteLine("Implementation"); break;
        }
    }
}