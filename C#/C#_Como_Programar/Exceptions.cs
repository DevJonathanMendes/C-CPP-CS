// Tratamento de exceções.

using System;

public class TestException
{
    public TestException(bool ThrowError)
    {
        if (ThrowError)
            throw new System.Exception("This is a Exception.");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            TestException ThrowError = new TestException(true);
        }
        catch (Exception Error)
        {
            Console.WriteLine(Error.Message);
        }
    }
}