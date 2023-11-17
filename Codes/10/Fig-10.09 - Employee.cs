// Fig. 10.09: Employee.cs
// Classe base abstrata para funcionários da empresa.

using System;

public abstract class Employee
{
	private string firstName;
	private string lastName;

	public Employee(string firstNameValue, string lastNameValue)
	{
		FirstName = firstNameValue;
		LastName = lastNameValue;
	}

	// Propriedade FirstName.
	private string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	// Propriedade LastName.
	private string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}

	// Retorna a representação de string de Employee.
	public override string ToString()
	{
		return FirstName + " " + LastName; ;
	}

	// Método abstrato que deve ser implementado para cada classe
	// derivada de Employee para calcular os ganhos específicos.
	public abstract decimal Earning();
}
