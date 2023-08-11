// 11.06: Propriedade de Exception.
// Os tipos de dados de exceção derivam da classe Exception.
// Também há InnerException, usada para "encerrar" objetos de exceções.

using System;

static class Program
{
	static void Main(string[] args)
	{
		try
		{
			Method1();
		}
		catch (Exception exception)
		{
			Console.WriteLine($"\n{exception.ToString()}\n");
			Console.WriteLine($"{exception.Message}\n");
			Console.WriteLine($"{exception.StackTrace}\n");
			Console.WriteLine($"{exception.InnerException}\n");
		}
	}

	public static void Method1() { Method2(); }

	public static void Method2() { Method3(); }
	
	public static void Method3()
	{
		try
		{
			Convert.ToInt32("Not an integer");
		}
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