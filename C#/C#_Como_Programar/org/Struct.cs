// Estruturas.

using System;

struct StructExample // : [interface]
{
    public int number;

    public StructExample(int param1)
    { number = param1; }
}

class Program
{
    static void Main()
    {
        StructExample testStructExample = new StructExample(10);
        Console.WriteLine(testStructExample.number);
    }
}