// Fig. 8.13: Employee.cs
// A classe Employee contém dados estáticos e um método estático.

using System;

public class Employee
{
	private string firstName;
	private string lastName;
	private static int count; // Objetos Employee em memória.

	public Employee(string fName, string lName)
	{
		firstName = fName;
		lastName = lName;

		++count;

		Console.WriteLine("Employee object constructor: "
			+ firstName + " " + lastName + "; count = " + Count);
	}

	// O destrutor decrementa a contagem estática de objetos Employee.
	~Employee()
	{
		--count;

		Console.WriteLine("Employee object destructor: " +
			firstName + "" + lastName + "; count = " + Count);
	}

	public string FirstName
	{ get { return firstName; } }

	public string LastName
	{ get { return lastName; } }

	public static int Count
	{ get { return count; } }
}
