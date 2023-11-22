// Fig. 10.24: DelegateBubbleSort.cs
// Demonstrando delegados para ordenar números.

using System;

public class DelegateBubbleSort
{
	public delegate bool Comparator(int element1, int element2);

	// Ordena o array usando o delegado Comparator.
	public static void SortArray(int[] array, Comparator Compare)
	{
		for (int pass = 0; pass < array.Length; pass++)
			for (int i = 0; i < array.Length - 1; i++)
				if (Compare(array[i], array[i + 1]))
					Swap(ref array[i], ref array[i + 1]);
	}

	// Troca dois elementos.
	private static void Swap(ref int firsElement, ref int secondElement)
	{
		int hold = firsElement;
		firsElement = secondElement;
		secondElement = hold;
	}
}
