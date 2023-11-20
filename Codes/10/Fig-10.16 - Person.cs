// Fig. 10.16: Person.cs
// A classe Person tem uma data de nascimento.

using System;

// Cole a interface IAge (Fig-10.15 - IAge.cs) aqui.

public class Person : IAge
{
	private string firstName;
	private string lastName;
	private int yearBorn;

	public Person(string firstNameValue, string lastNameValue, int yearBornValue)
	{
		firstName = firstNameValue;
		lastName = lastNameValue;

		if (yearBornValue > 0 && yearBornValue <= DateTime.Now.Year)
			yearBorn = yearBornValue;
		else
			yearBorn = DateTime.Now.Year;
	}

	// Implementação da propriedade Age da interface IAge.
	public int Age
	{ get { return DateTime.Now.Year - yearBorn; } }

	// Implementação da propriedade Name da interface IAge.
	public string Name
	{ get { return firstName + " " + lastName; } }
}
