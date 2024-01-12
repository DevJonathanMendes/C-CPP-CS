// Fig. 17.08: Record.cs
// Classe serializável que representa um registro de dados.

using System;

[Serializable]
public class Record
{
	private int account;
	private string firstName;
	private string lastName;
	private double balance;

	// Construtor padrão configura os membros com valores padrão.
	public Record() : this(0, "", "", 0.0)
	{ }

	// O construtor sobrecarregado configura os membros com os valores dos parâmetros.
	public Record(int accountValue, string firstNameValue,
		string lastNameValue, double balanceValue)
	{
		Account = accountValue;
		FirstName = firstNameValue;
		LastName = lastNameValue;
		Balance = balanceValue;
	}

	public int Account
	{
		get { return account; }
		set { account = value; }
	}

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}

	public double Balance
	{
		get { return balance; }
		set { balance = value; }
	}
}
