// Fig. 17.14: RandomAccessRecord.cs
// Classe de registro de dados para aplicativos de acesso aleatório.

using System;

public class RandomAccessRecord
{
	// Tamanho de firstName e lastName.
	private const int CHAR_ARRAY_LENGTH = 15;

	private const int SIZE_OF_CHAR = 2;
	private const int SIZE_OF_INT32 = 4;
	private const int SIZE_OF_DOUBLE = 8;

	// Tamanho do registro.
	public const int SIZE = SIZE_OF_INT32 +
		2 * (SIZE_OF_CHAR * CHAR_ARRAY_LENGTH) + SIZE_OF_DOUBLE;

	// Grava dados.
	private int account;
	private char[] firstName = new char[CHAR_ARRAY_LENGTH];
	private char[] lastName = new char[CHAR_ARRAY_LENGTH];
	private double balance;

	// Construtor padrão configura os membros com valores padrão.
	public RandomAccessRecord() : this(0, "", "", 0.0) { }

	// O construtor sobrecarregado configura os membros com valores do parâmetro.
	public RandomAccessRecord(int accountValue, string firstNameValue,
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
		get { return new string(firstName); }
		set
		{
			// Determina o tamanho do parâmetro string.
			int stringSize = value.Length;

			// Representação de string de firstName.
			string firstNameString = value;

			// Inclui espaços no final do parâmetro string se for curto demais.
			if (CHAR_ARRAY_LENGTH >= stringSize)
			{
				firstNameString = value + new string(' ', CHAR_ARRAY_LENGTH - stringSize);
			}
			else
			{
				// Remove caracteres do parâmetro string se for longo demais.
				firstNameString = value.Substring(0, CHAR_ARRAY_LENGTH);
			}

			// Converte o parâmetro string em array de char.
			firstName = firstNameString.ToCharArray();
		}
	}

	public string LastName
	{
		get { return new string(lastName); }
		set
		{
			// Determina o tamanho do parâmetro string.
			int stringSize = value.Length;

			// Representação de string de lastName.
			string lastNameString = value;

			// Inclui espaços no final do parâmetro string se for curto demais.
			if (CHAR_ARRAY_LENGTH >= stringSize)
			{
				lastNameString = value +
					new string(' ', CHAR_ARRAY_LENGTH - stringSize);
			}
			else
			{
				// Remove caracteres do parâmetro string se for longo demais.
				lastNameString =
					value.Substring(0, CHAR_ARRAY_LENGTH);
			}

			// Converte o parâmetro string em array char.
			lastName = lastNameString.ToCharArray();
		}
	}

	public double Balance
	{
		get { return balance; }
		set { balance = value; }
	}
}
