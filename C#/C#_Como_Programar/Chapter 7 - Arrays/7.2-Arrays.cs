// 7.2: Arrays:
// É um grupo de posições na memória adjacentes que têm o mesmo nome e tipo.

// 7.3: Declarando e alocando um array:
// O programador especifica o tipo dos elementos e usa o operador "new"
// para alocar dinamicamente o número de elementos exigidos por cada array.

using System;

static class Program
{
	static void Main(string[] args)
	{
		const int ARRAY_SIZE = 4;

		int[] x; // Declara referência para um array. 
		x = new int[ARRAY_SIZE]; // Aloca dinamicamente e seta os valores padrão.

		string[] b = new string[100];

		// A lista iniciadora especifica o número de elementos
		// e o valor de cada elemento.
		int[] y = { 2, 4, 6, 8 };
	}
}
