// 8.16: Espaços de nomes e assemblies.
// Para evitar colisões de nomes etc.

using System;
using TimeLibrary;

static class Program
{
	static void Main(string[] args)
	{
		Time3 time = new Time3(18, 01, 20);

		Console.WriteLine($"Universal time: {time.ToUniversalString()}");
		Console.WriteLine($"Standard time: {time.ToStandardString()}");
	}
}
