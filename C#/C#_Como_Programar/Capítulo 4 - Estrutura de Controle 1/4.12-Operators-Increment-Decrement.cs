// Fig: 4.12: Operadores de incremento e decremento.
// Os operadores unários (++ e --) são aplicadas por 1.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int variable = 2;

		Console.Clear();

		Console.WriteLine($"++Pré-incremento: {variable} => {++variable}"); // Primeiro incrementa e depois usa a variável.
		Console.WriteLine($"Pós-incremento++: {variable++} => {variable}"); // Primeiro usa a variável e depois incrementa.

		Console.WriteLine($"--Pré-decremento: {variable} => {--variable}"); // Primeiro decrementa e depois usa a variável.
		Console.WriteLine($"Pós-decremento++: {variable--} => {variable}"); // Primeiro usa a variável e depois decrementa.

		Console.WriteLine($"Final value of the variable: {variable}.\n");
	}
}
