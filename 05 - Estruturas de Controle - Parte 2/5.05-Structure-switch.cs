// 5.05: Estrutura de seleção múltipla - switch.
// O valor de expressão de controle é avaliada, comparada com os casos.
// Se não houver, cai no default.

using System;

static class Program
{
	static void Main(string[] args)
	{
		string dropCase = "another case";

		switch (dropCase)
		{
			case "a case": Console.WriteLine("a case"); break;
			case "another case": Console.WriteLine("another case"); break;
			default: Console.WriteLine("default"); break;
		}
	}
}
