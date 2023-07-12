// 8.11: Membros de Classe static.
// Variáveis static terá os mesmos valores para todas as instâncias.
// Isso pode poupar tempo e recurso.

using System;

public class StaticTest
{
	public static int staticInt;

	static StaticTest()
	{
		staticInt = 10;
	}

	public int staticIntValue
	{
		get { return staticInt; }
		set { staticInt = value; }
	}
}

static class Program
{
	static void Main(string[] args)
	{
		StaticTest aInt0 = new StaticTest(), aInt1 = new StaticTest();

		Console.WriteLine($"{aInt0.staticIntValue}\n{aInt0.staticIntValue}");

		StaticTest.staticInt = 100;
		Console.WriteLine($"{aInt0.staticIntValue}\n{aInt0.staticIntValue}");
	}
}
