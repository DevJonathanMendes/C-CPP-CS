// 11.01: Introdução: Tratamento de Exceções.
// Técnica que permite lidar com erros e situações inesperadas durante a execução de um programa.
// O programa pode ser projetado para detectar, responder e recuperar de erros, garantindo a estabilidade e confiabilidade.
// Assim, evitando falhas inesperadas e permite que continue executando de maneira adequada mesmo quando ocorrem situações problemáticas.

// 11.03: Exemplo.
// Exemplo simples de tratamento de exceções.

// 11.04: Hierarquia de exceções do .NET.
// 	A classe Exception (de System) é a base da hierarquia de exceções da plataforma .NET.
// Duas classes derivadas importantes: ApplicationException e SystemException.
// 	A vatangem de usar hierarquia é que o manipulador catch pode capturar um tipo
// específico ou pode usar um tipo de classe base para capturar exceções relacionadas. 

using System;

static class Program
{
	static void Main(string[] args)
	{
		try
		{
			Console.Write("Numerator: ");
			int numerator = Convert.ToInt32(Console.ReadLine());

			Console.Write("Denominator: ");
			int denominator = Convert.ToInt32(Console.ReadLine());

			int result = numerator / denominator;

			Console.WriteLine($"{numerator}/{denominator} = {result}");
		}
		// Formato de número inválido.
		catch (FormatException FormatException)
		{
			Console.WriteLine(FormatException.Message);
		}
		// Se tentar dividir por zero.
		catch (DivideByZeroException DivideByZeroException)
		{
			Console.WriteLine($"{DivideByZeroException.Message}");
		}
	}
}