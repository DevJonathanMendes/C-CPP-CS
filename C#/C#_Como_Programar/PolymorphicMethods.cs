// Métodos polimórficos.

using System;

class Gene1
{
    public virtual void Message(string msg)
    {
        msg += " Gene 1 ";
        Console.WriteLine(msg);
    }
}

class Gene2 : Gene1
{
    public override void Message(string msg)
    {
        msg += " Gene 2 ";
        base.Message(msg);
    }
}

class Gene3 : Gene2
{
    public override void Message(string msg)
    {
        msg += " Gene 3 ";
        base.Message(msg);
    }
}

class Program
{
    static void Main()
    {
        Gene3 TestGenerations = new Gene3();
        TestGenerations.Message("Genes:");
    }
}