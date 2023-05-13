// Classe Selada.

using System;

sealed class SealedClass
{
    public string word = "A string";
}

class InheritClass : SealedClass
{
    // Erro de compilação:
    // Cannot inherit from sealed class...
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
    }
}