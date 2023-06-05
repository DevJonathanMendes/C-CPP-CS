// 6.12: Duração das Variáveis.
// A variáveis possuem um "tempo de vida", mas se for variável estática, fica até o fim.

// 6.13: Regras de Escopo.
// Nada a acrescentar sobre escopo de declaração.

using System;

static class Program
{
	public static int publicScope = 10;

	public static int ScopeA()
	{
		int scopeA = 20;
		return scopeA;
	}

	public static int ScopedB()
	{
		int scopeB = 20;
		return scopeB;
	}

	static void Main(string[] args)
	{
		Console.WriteLine($"Public Scope: {publicScope}");
		Console.WriteLine($"ScopeA: {ScopeA()}");
		Console.WriteLine($"ScopeB: {ScopeA()}");
	}
}
