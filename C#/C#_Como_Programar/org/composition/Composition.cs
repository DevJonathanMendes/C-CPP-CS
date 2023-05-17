// Fig. 8.10: CompositionTest.cs.
// Demonstra um objeto com referência a um objeto membro.

namespace console;

using System;

static class Program
{
    static void Main(string[] args)
    {
        Employee e = new Employee("Jonathan", "Mendes", 18, 01, 1949, 3, 12, 1998);
        Console.WriteLine(e.ToEmployeeString());
    }
}
