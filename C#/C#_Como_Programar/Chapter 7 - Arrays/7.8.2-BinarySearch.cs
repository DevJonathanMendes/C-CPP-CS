// 7.8.2: Pesquisa binária.
// É mais eficiente para dados maiores, o array terá a metade cortada.

using System;

static class Program
{
	static int BinarySearch(int[] arr, int key)
	{
		int low = 0;                // Índice baixo.
		int high = arr.Length - 1;  // Índice alto.
		int middle;                 // Índice do meio.

		while (low <= high)
		{
			middle = (low + high) / 2;

			// Array sendo manipulado durante
			// cada iteração do laço de pesquisa binária.
			if (key == arr[middle])
				return middle;
			else if (key < arr[middle])
				high = middle - 1; // Pesquisa a extremidade inferior do array.
			else
				low = middle + 1;
		}

		return -1;
	}

	static void Main(string[] args)
	{
		int[] arrNumbers = { 3, 2, 5, 4, 7, 6, 9, 8, 10, 99, 65, 32, 21, 23, 22,
												43, 54, 64, 21, 31, 30, 95, 54, 67, 43, 25, 63, 76 };

		Console.WriteLine("Enter key:");
		int searchKey = Int32.Parse(Console.ReadLine());
		int element = BinarySearch(arrNumbers, searchKey);

		if (element != -1)
			Console.WriteLine($"Found value element: {element}");
		else
			Console.WriteLine("Value not found.");
	}
}
