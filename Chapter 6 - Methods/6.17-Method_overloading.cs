// 6.17: Sobrecarga de métodos.
// Vários métodos com o mesmo nome podem ser definidos na mesma classe,
// desde que esses métodos tenham diferentes conjuntos de parâmetro.

using System;

static class Program
{
	static int Square(int num)
	{ return num * num; }

	static double Square(double num)
	{ return num * num; }

	static void Main(string[] args)
	{
		Console.WriteLine(
			$"With int: {Square(7)}\nWith double: {Square(7.5)}"
		);
	}
}
