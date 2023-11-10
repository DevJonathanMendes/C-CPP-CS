// Fig. 9.19: ConstructorAndDestructor.cs
// Exibe a ordem em que os construtores e destrutores da classe base e da classe derivada são chamados.

using System;

// Cole a classe Point4 (Fig-9.17 - Point4.cs) aqui.

// Cole a classe Circle5 (Fig-9.18 - Circle5.cs) aqui.

class ConstructorAndDestructor
{
	static void Main(string[] args)
	{
		Circle5 circle1, circle2;

		circle1 = new Circle5(72, 29, 4.5);
		circle2 = new Circle5(5, 5, 10);

		Console.WriteLine();

		circle1 = null;
		circle2 = null;

		// Informa para o coletor de lixo que seja executado.
		System.GC.Collect();
	}
}
