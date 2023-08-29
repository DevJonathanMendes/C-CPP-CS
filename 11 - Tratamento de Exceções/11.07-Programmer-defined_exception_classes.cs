// 11.07: Classes de exceções definidas pelo programador.
// Em muitos casos, os programadores podem querer criar tipos de exceção
// mais específicos para os problemas que ocorrem em seus programas.

using System;

// De acordo com a Microsoft, as exceções definidas pelo programador devem
// estender a classe ApplicationException.
class NegativeNumberException : ApplicationException
{
	// Padrão.
	public NegativeNumberException()
	: base("Illegal operation for a negative number")
	{ }

	// Personaliza mensagens de erro.
	public NegativeNumberException(string message)
	: base(message)
	{ }

	// Personaliza mensagem de erro e especificar o objeto de exceção interno.
	public NegativeNumberException(string message, Exception inner)
	: base(message, inner)
	{ }
}

static class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			try
			{
				Console.Write("\rPlease, enter a number: ");
				double result = SquareRoot(Convert.ToDouble(Console.ReadLine()));

				Console.Write($"Square Root: ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"{result}\n");

				Console.ResetColor();
				Console.WriteLine(String.Format($"Want to calculate another square root? (Y/N)\n"));

				var input = Console.ReadKey();
				switch (input.Key)
				{
					case ConsoleKey.Y: break;
					default: Console.WriteLine("\rUnknown command."); return;
				}
			}
			catch (FormatException notInteger)
			{
				Console.WriteLine(notInteger.Message);
			}
			catch (NegativeNumberException error)
			{
				Console.WriteLine(error.Message);
			}
		}

		double SquareRoot(double operand)
		{
			if (operand < 0)
				throw new NegativeNumberException(
					"Negative number not permitted."
				);

			return Math.Sqrt(operand);
		}
	}
}
