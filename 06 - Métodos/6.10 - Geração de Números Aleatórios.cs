// 6.10: Números Aleatórios.
// Gerando valores inteiros pseudoaleatórios.
// Não há aleatoriedade 100% em computação.

using System;

static class Program
{
	static void Main(string[] args)
	{
		Random randomObj = new Random();
		int randomInt = randomObj.Next(); // Gera um número positivo entre 0 e 2.147.483.647.

		Console.WriteLine($"Random Number: {randomInt}");

		randomInt = randomObj.Next(1, 10); // Aceitar dois argumentos, que é óbvio.
		Console.WriteLine($"New Random Number: {randomInt}");
	}
}
