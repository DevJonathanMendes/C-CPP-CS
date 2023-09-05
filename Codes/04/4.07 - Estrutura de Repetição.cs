// 4.7: Estrutura de repetição while.
// As ações são repetidas enquanto uma condição permanecer true.
// Podemos adicionar uma sentinela, para controlar o final da entrada de um dado etc.

using System;

static class Program
{
	static void Main(string[] args)
	{
		int condition = 0;
		while (condition < 10)
		{
			condition++;
			Console.WriteLine(condition);
		}
	}
}
