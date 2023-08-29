// 10.10: Delegados.
// Pode ser vantajoso aos objetos passar métodos como
// argumentos a outros métodos crescentes/decrescentes.

// C# não permite a passagem de referências a métodos como argumentos diretamente
// para outros métodos, mas fornece delegados, que são classes que
// encapsulam conjuntos de referências para métodos.

using System;

public class DelegateBubbleSort
{
	// O delegado define uma assinatura de método para métodos
	// que recebem dois argumentos int e retornam um valor bool.
	public delegate bool Comparator(int element1, int element2);

	public static void SortArray(int[] array, Comparator Compare)
	{
		for (int pass = 0; pass < array.Length - 1; pass++)
			for (int i = 0; i < array.Length - 1; i++)
				if (Compare(array[i], array[i + 1]))
					Swap(ref array[i], ref array[i + 1]);
	}

	private static void Swap(ref int firsElement, ref int secondElement)
	{
		int hold = firsElement;
		firsElement = secondElement;
		secondElement = hold;
	}
}

static class Program
{
	static void Main(string[] args)
	{
		int[] arr = new int[10];
		Random randomNumber = new Random();

		Console.WriteLine("Array Data:");
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = randomNumber.Next(100);
			Console.Write($"{arr[i]} ");
		}

		bool SortAscending(int element1, int element2)
		{ return element1 > element2; }
		DelegateBubbleSort.SortArray(arr, new DelegateBubbleSort.Comparator(SortAscending));

		Console.WriteLine("\n\nSort Ascending Array Data:");
		for (int i = 0; i < arr.Length; i++)
		{ Console.Write($"{arr[i]} "); }
	}
}
