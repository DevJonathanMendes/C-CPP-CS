// Fig. 11.3: Properties.cs
// Desenrolamento de pilha e propriedades da classe Exception.

using System;

class Properties
{
	static void Main(string[] args)
	{
		// Chama Method1, toda exceção que ele gerar será
		// capturada no manipulador catch que se segue.
		try
		{
			Method1();
		}
		// Produz na saída a representação de string de Exception e, em seguida,
		// produz na saída os valores das propriedades InnerException, Message e StackTrace.
		catch (Exception exception)
		{
			Console.WriteLine("exception.ToString(): \n{0}\n", exception.ToString());
			Console.WriteLine("exception.Message: \n{0}\n", exception.Message);
			Console.WriteLine("exception.StackTrace: \n{0}\n", exception.StackTrace);
			Console.WriteLine("exception.InnerException: \n{0}\n", exception.InnerException);
		}
	}

	public static void Method1() { Method2(); }

	public static void Method2() { Method3(); }

	// Lança uma exceção contendo uma InnerException.
	public static void Method3()
	{
		// Tenta converter string não inteira em int.
		try
		{
			Convert.ToInt32("Not an integer");
		}
		// Captura FormatException e a encerra na nova Exception.
		catch (FormatException error)
		{
			throw new Exception("Exception ocurred in Method3", error);
		}
	}
}

// Pilha de chamadas a métodos:
// Method3
// Method2
// Method1
// Main
