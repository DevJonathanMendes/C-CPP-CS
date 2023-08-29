// 6.9: Passagem de argumentos.
// As duas maneiras de passar argumentos para métodos são por valor e por referência.

// Por VALOR: O método recebe uma cópia do valor do argumento.
// Por REFERÊNCIA: Acessa os dados originais do argumento. (Melhor desempenho)

using System;

static class Program
{
	static void Main(string[] args)
	{
		// Por valor.
		void Square(int value) // Não pode modificar a variável original.
		{ value = value * value; }

		// Por referência ref. Para variáveis que já foram inicializadas.
		void SquareRef(ref int value) // Modifica a variável original.
		{ value = value * value; }

		// Por parâmetro out. O método irá inicializar a variável, evitando erro no compilador.
		void SquareOut(out int value) // Inicializa e modifica a variável original.
		{
			value = 6;
			value = value * value;
		}

		int y = 5;
		int z;

		Console.WriteLine($"Original value of y: {y}");
		Console.WriteLine($"Original value of z: Uninitialized\n");

		SquareRef(ref y);
		SquareOut(out z);

		Console.WriteLine($"Value of y after SquareRef: {y}");
		Console.WriteLine($"Value of z after SquareOut: {z}\n");

		Square(y);
		Square(z);

		Console.WriteLine($"Value of y after Square: {y}");
		Console.WriteLine($"Value of z after Square: {z}");
	}
}
