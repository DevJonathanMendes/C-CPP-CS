// Laços.

using System;

class Program
{
    static void Main()
    {
        int i = 0;
        int[] inArr = { 1, 2 };

        for (i = 0; i < 1; i++)
            Console.WriteLine(i);
        //
        foreach (int index in inArr)
            Console.WriteLine(index);
        //
        while (i < 2)
        {
            Console.WriteLine(i);
            i++;
        }
        //
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 3);
    }
}