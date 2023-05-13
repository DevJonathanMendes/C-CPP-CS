// Destrutor.

using System;

class DestructorClass
{
    ~DestructorClass() // Método com nome igual da classe precedido por um "~" se torna um destructor.
    {
        // Código de liberação de recursos;
        // Base.Finalize() é chamado automaticamente em C#. 
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
    }
}