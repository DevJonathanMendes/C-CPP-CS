// Interfaces.

using System;

public interface IBarCode
{
    void StandardReading3of9();
    void StandardReadingEAN13();
    void IdenticalMethod();
}

public interface IStorageControl
{
    void Locator();
    void Categorization();
    void IdenticalMethod();
}

public class Product : IBarCode, IStorageControl
{
    // Aqui viriam as implementações.
    public void StandardReading3of9()
    {
        // Implementação.
    }

    public void StandardReadingEAN13()
    {
        // Implementação.
    }
    public void Locator()
    {
        // Implementação.
    }
    public void Categorization()
    {
        // Implementação.
    }
    // Em nomes coincidentes, implemente apenas uma vez.
    public void IdenticalMethod()
    {
        // Implementação
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
    }
}