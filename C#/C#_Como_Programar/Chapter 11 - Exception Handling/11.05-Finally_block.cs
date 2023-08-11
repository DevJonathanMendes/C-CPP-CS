// 11.05: O Bloco Finally
// Este bloco no tratamento de exceções sempre é executado.
// Normalmente contém código para liberar os recursos adquiridos no bloco try.

using System;

static class Program
{
	static void Main(string[] args)
	{
		try
		{
			throw new Exception("Exception in Program");
		}
		catch (Exception error)
		{
			Console.WriteLine(error.Message);
		}
		finally
		{
			Console.WriteLine("Always execute");
		}
	}
}