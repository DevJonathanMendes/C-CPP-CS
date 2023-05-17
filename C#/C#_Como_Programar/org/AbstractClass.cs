// Concretismo e Abstração de Classes.

using System;

abstract class AbstractClass
{
    public abstract string Content();
    public abstract string Show();
}

class DefineAbstractClass : AbstractClass
{
    public override string Content()
    {
        return "Method: Content";
    }

    public override string Show()
    {
        return "Method: Show";
    }
}

class Program
{
    static void Main()
    {
        DefineAbstractClass TestingClass = new DefineAbstractClass();
        Console.WriteLine(TestingClass.Content());
        Console.WriteLine(TestingClass.Show());
    }
}