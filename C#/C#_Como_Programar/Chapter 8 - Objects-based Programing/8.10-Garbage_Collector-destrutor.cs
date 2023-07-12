// 8.10: Coletor de Lixo.
// Estouros de memória são raros em C#.
// A coleta de lixo pode acontecer com destrutores, "~NomeDaClasse".

using System;

public class GarbageCollector
{
	public string garbage;

	public GarbageCollector() // Construtor.
	{
		garbage = "There is garbage";
	}

	~GarbageCollector() // Destrutor, não aceita parâmetros.
	{
		garbage = "Nothing";
		Console.WriteLine("Collected garbage.");
	}
}

static class Program
{
	static void Main(string[] args)
	{
		GarbageCollector trash = new GarbageCollector();
		Console.WriteLine(trash.garbage);

		trash = null;
		System.GC.Collect(); // Força a coleta de lixo.
		System.GC.WaitForPendingFinalizers(); // Espera até a coleta termine.
	}
}
