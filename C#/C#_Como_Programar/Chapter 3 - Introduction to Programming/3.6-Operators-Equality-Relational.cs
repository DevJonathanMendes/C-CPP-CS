// Fig. 3.19: Operadores de igualdade e operadores relacionais.
// Usando operadores relacionais e operadores de igualdade.

/*
Operadores de igualdade:
	==:	é igual a.
  !=:	é diferente de.

Operadores relacionais:
	>:	É maior que.
	<:	É menor que.
	>=:	É maior ou menor a.
	<=:	É menor ou igual a.
*/

using System;

static class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(4 == 2);
		Console.WriteLine(4 != 2);

		Console.WriteLine(4 > 2);
		Console.WriteLine(4 < 2);
		Console.WriteLine(4 >= 2);
		Console.WriteLine(4 <= 2);
	}
}
