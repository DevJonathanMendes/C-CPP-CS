// Destrutor.

using System;

class DestructorClass
{
    ~DestructorClass() // Método com nome igual da classe precedido por um "~" se torna um destructor.
    {
        // Código de liberação de recursos;
        // (Base.)Finalize() é chamado automaticamente em C#. 
    }
}

class Program
{
    static void Main()
    {
        DestructorClass TDC;
        TDC = new DestructorClass();

        Console.WriteLine();

        // Para coleta de lixo.
        TDC = null;

        // Informa o coletor de lixo para que seja executado.
        System.GC.Collect();
    }
}