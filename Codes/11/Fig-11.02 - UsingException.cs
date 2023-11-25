// Fig. 11.2: UsingExceptions.cs
// Usando blocos finally.

using System;

// Demonstra que finally sempre executa.
static class UsingExceptions
{
	static void Main(string[] args)
	{
		// Caso 1: Nenhuma exceção corre no método chamado.
		Console.WriteLine("Calling DoesNotThrowException");
		DoesNotThrowException();

		// Caso 2: A exceção ocorre e é capturada no método chamado.
		Console.WriteLine("\nCalling ThrowExceptionWithCatch");
		ThrowExceptionWithCatch();

		// Caso 3: A exceção ocorre, mas não é capturada
		// no método chamado, pois não existe nenhum manipulador catch.
		Console.WriteLine("\nCalling ThrowExceptionWithoutCatch");

		try
		{
			ThrowExceptionWithoutCatch();
		}
		// Processa a exceção retornada de ThrowExceptionWithoutCatch.
		catch
		{
			Console.WriteLine("Caught exception from " +
				"ThrowExceptionWithoutCatch in Main");
		}

		// Caso 4: A exceção ocorre e é capturada
		// no método chamado e depois novamente lançada para o chamador.
		Console.WriteLine("\nCalling ThrowExceptionCatchRethrow");

		try
		{
			ThrowExceptionCatchRethrow();
		}
		// Processa a exceção retornada de
		// ThrowExceptionCatchRethrow.
		catch (System.Exception)
		{
			Console.WriteLine("Caught exception from " +
				"ThrowExceptionCatchRethrow in Main");
		}
	}

	// Nenhuma exceção lançada.
	public static void DoesNotThrowException()
	{
		// O bloco try não lança nenhuma exceção.
		try
		{
			Console.WriteLine("In DoesNotThrowException");
		}
		// Este catch nunca é executado.
		catch
		{
			Console.WriteLine("This catch never executes");
		}
		// finally é executado, pois o try correspondente foi executado.
		finally
		{
			Console.WriteLine("Finally executed in DoesNotThrowException");
		}
		Console.WriteLine("End of DoesNotThrowException");
	}

	// Lança a exceção e a captura de forma local.
	public static void ThrowExceptionWithCatch()
	{
		// O bloco try lança exceção.
		try
		{
			Console.WriteLine("In ThrowExceptionWithCatch");
			throw new Exception("Exception in ThrowExceptionWithCatch");
		}
		// Captura a exceção lançada no bloco try.
		catch (Exception error)
		{
			Console.WriteLine("Message: " + error.Message);
		}
		// finally é executado porque o try correspondente é executado.
		finally
		{
			Console.WriteLine("Finally executed in ThrowExceptionWithCatch");
		}
		Console.WriteLine("End of ThrowExceptionWithCatch");
	}

	// Lança a exceção e não a captura de forma local.
	public static void ThrowExceptionWithoutCatch()
	{
		// Lança a exceção, mas não a captura.
		try
		{
			Console.WriteLine("In ThrowExceptionWithoutCatch");
			throw new Exception("Exception in ThrowExceptionWithoutCatch");
		}
		// finally é executado porque o try correspondente é executado.
		finally
		{
			Console.WriteLine("Finally executed in ThrowExceptionWithoutCatch");
		}
		// Código inatingível; geraria erro de lógica.
		Console.WriteLine("This will never be printed");
	}

	// Lança a exceção, a captura e a lança novamente.
	public static void ThrowExceptionCatchRethrow()
	{
		// O bloco try lança a exceção.
		try
		{
			Console.WriteLine("In ThrowExceptionCatchRethrow");
			throw new Exception("Exception in ThrowExceptionCatchRethrow");
		}
		// Captura qualquer exceção, coloca no objeto error.
		catch (Exception error)
		{
			Console.WriteLine("Message: " + error.Message);

			// Lança a exceção novamente para mais processamento.
			throw error;
		}
		// finally é executado porque o try correspondente é executado.
		finally
		{
			Console.WriteLine("Finally executed in ThrowExceptionCatchRethrow");
		}
		// Código inatingível; geraria erro de lógica.
		Console.WriteLine("This will never be printed");
	}
}
