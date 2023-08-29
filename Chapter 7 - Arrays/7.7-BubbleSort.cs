// 7.7: BubbleSort.
// Ordenando um array em ordem crescente com Bubble Sort.

using System;

static class Program
{
	static void BubbleSort(int[] arr)
	{
		for (int pass = 1; pass < arr.Length; pass++) // Passagem.
			for (int item = 0; item < arr.Length - 1; item++) // Um passagem.
				if (arr[item] > arr[item + 1]) // Uma comparação.
					Swap(arr, item); // Uma troca.
	}

	static void Swap(int[] arrOrder, int first)
	{
		int hold; // Armazenamento temporário.

		hold = arrOrder[first];
		arrOrder[first] = arrOrder[first + 1];
		arrOrder[first + 1] = hold;
	}

	static void FormatterOutput(ref string output, int[] array)
	{
		foreach (int number in array)
			output += $"  {number}";
	}

	static void Main(string[] args)
	{
		int[] arrayToOrder = { 3, 2, 5, 4, 7, 6, 9, 8, 10, 99, 65, 32, 21, 23, 22 };
		string output = "";

		Console.Clear();

		output += $"Items in original order:\n";
		FormatterOutput(ref output, arrayToOrder);

		BubbleSort(arrayToOrder);

		output += $"\nItems in ascending order:\n";
		FormatterOutput(ref output, arrayToOrder);

		Console.WriteLine(output);
	}
}
