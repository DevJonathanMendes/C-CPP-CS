// 8.13: Indexadores.
// Às vezes uma classe encapsula dados que um programa pode manipular como uma lista de elementos.
// Tal classe pode definir propriedades especiais chamadas indexadores,
// que permitem acesso indexado às listas de elementos no estilo de um array.

using System;

public class Box
{
	private string[] names = { "length", "width", "height" };
	private double[] dimensions = new double[3];

	public Box(double length, double width, double height)
	{
		dimensions[0] = length;
		dimensions[1] = width;
		dimensions[2] = height;
	}

	public double this[int index] // Acessa as dimensões pelo número de índice inteiro.
	{
		get
		{
			return (index < 0 || index >= dimensions.Length) ? -1 : dimensions[index];
		}
		set
		{
			if (index >= 0 && index < dimensions.Length)
				dimensions[index] = value;
		}
	}

	public double this[string name] // Acessa as dimensões por seus nomes de string.
	{
		get
		{
			int i = 0;
			while (i < names.Length && name.ToLower() != names[i])
				i++;

			return (i == names.Length) ? -1 : dimensions[i];
		}
		set
		{
			int i = 0;
			while (i < names.Length && name.ToLower() != names[i])
				i++;

			if (i != name.Length)
				dimensions[i] = value;
		}
	}
}

static class Program
{
	static void Main(string[] args)
	{
		Box box = new Box(2.5, 4.5, 6.5);

		double boxLength = box[0]; // length.
		double boxWidth = box["width"];
		double boxHeight = box["height"];

		Console.WriteLine($"Box\nLength: {boxLength}\nWidth: {boxWidth}\nHeight: {boxHeight}");
	}
}
