// Fig. 8.9: Employee.cs
// A definição da classe Employee encapsula o primeiro nome,
// o sobrenome, a data de nascimento e a data de contratação do funcionário.

using System;

// Cole a classe Date (Fig-8.08 - Date.cs) aqui.

public class Employee
{
	private string firstName;
	private string lastName;
	private Date birthDate; // Referência a um objeto Date.
	private Date hireDate;  // Referência a um objeto Date.

	public Employee(string first, string last,
		int birthMonth, int birthDay, int birthYear,
		int hireMonth, int hireDay, int hireYear)
	{
		firstName = first;
		lastName = last;

		birthDate = new Date(birthMonth, birthDay, birthYear);
		hireDate = new Date(hireMonth, hireDay, hireYear);
	}

	public string ToEmployeeString()
	{
		return lastName + ", " + firstName +
			" Hired: " + hireDate.ToDateString() +
			" Birthday: " + birthDate.ToDateString();
	}
}
