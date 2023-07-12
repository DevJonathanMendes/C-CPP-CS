// 8.12: Membros const e readonly.
// const são static implicitamente e devem ser inicializados na sua declaração.
// readonly podem ser inicializados na declaração ou no construtor.
// const e readonly não podem ser modificados, mas readonly podem ser atribuídos valores em diversos construtores.

using System;

public class Constants
{
	public const double PI = 3.14159; // PI é uma constante não modificável.
	public readonly int radius; // const que não inicializada.

	public Constants(int radiusValue)
	{
		radius = radiusValue;
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Random random = new Random();
		Constants constantValues = new Constants(random.Next(1, 20));

		Console.WriteLine($"Radius = {constantValues.radius}\nCircumference = {2 * Constants.PI * constantValues.radius}");
	}
}
