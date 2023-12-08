// Fig. 11.4: NegativeNumberException.cs
// NegativeNumberException representa exceções causadas por
// operações inválidas executadas em números negativos.

using System;

class NegativeNumberException : ApplicationException
{
	// Construtor padrão.
	public NegativeNumberException()
		: base("Illegal operation for a negative number")
	{

	}

	// Construtor para personalizar mensagem de erro.
	public NegativeNumberException(string message)
		: base(message)
	{

	}

	// Construtor para personalizar mensagem de erro e
	// especificar o objeto de exceção interno.
	public NegativeNumberException(string message, Exception inner)
		: base(message, inner)
	{

	}
}
