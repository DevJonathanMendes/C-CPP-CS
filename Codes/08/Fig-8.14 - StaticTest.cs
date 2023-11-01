// Fig. 8.14: StaticTest.cs
// Demonstrando membros de classe estáticos.

using System;

// Cole a classe Employee (Fig-8.13 - Employee.cs) aqui.

class StaticTest
{
	static void Main(string[] args)
	{
		Console.WriteLine("Employees before instantiation: " +
			Employee.Count + "\n");

		Employee? employee1 = new Employee("Susan", "Baker");
		Employee? employee2 = new Employee("Bob", "Jones");

		Console.WriteLine("\nEmployees after instantiation: " +
			"Employee.Count = " + Employee.Count + "\n");

		Console.WriteLine("Employee 1: " +
			employee1.FirstName + "" + employee1.LastName +
			"\nEmployee 2: " + employee2.FirstName +
			" " + employee2.LastName + "\n");

		// Remove as referências aos objetos para indicar que
		// eles podem ser capturados pela coleta de lixo.
		employee1 = null;
		employee2 = null;

		// Força a coleta de lixo.
		System.GC.Collect();

		// Espera até que a coleta termine.
		System.GC.WaitForPendingFinalizers();

		Console.WriteLine(
			"Employees after garbage collection: " +
			Employee.Count);
	}
}
