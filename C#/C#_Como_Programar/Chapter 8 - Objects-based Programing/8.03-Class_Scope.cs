// 8.3: Escopo de Classe.
// As variáveis de instância e métodos de uma classe pertencem ao escopo dessa classe.
// Não há nada de especial neste conceito já revisado.

using System;

public class Scope : Object
{
	private int VALUE = 10;

	public string Scope1()
	{
		return $"Scope only with return of VALUE: {VALUE}";
	}

	public string Scope2()
	{
		int VALUE = 20;
		return $"Scope with new VALUE statement: {VALUE}";
	}

	public string Scope3()
	{
		int VALUE = 30;
		return $"Scope with this.VALUE: {this.VALUE}";
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Scope TestScope = new Scope();

		Console.WriteLine($"{TestScope.Scope1()}");
		Console.WriteLine($"{TestScope.Scope2()}");
		Console.WriteLine($"{TestScope.Scope3()}");
	}
}
