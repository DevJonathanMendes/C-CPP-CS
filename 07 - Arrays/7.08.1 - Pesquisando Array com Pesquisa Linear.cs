// 7.11: LinearSearch.
// Demonstrando uma pesquisa linear.

using System;

static class Program
{
	static public int LinearSearch(int[] arr, int key)
	{
		for (int i = 0; i < arr.Length; i++)
			if (arr[i] == key)
				return i;

		return -1;
	}

	static void Main(string[] args)
	{
		string output = "";
		int[] arrNumbers = { 3, 2, 5, 4, 7, 6, 9, 8, 10, 99, 65, 32, 21, 23, 22,
											43, 54, 64, 21, 31, 30, 95, 54, 67, 43, 25, 63, 76 };

		Console.WriteLine("Int Value: ");
		int searchKey = Int32.Parse(Console.ReadLine());

		int elementIndex = LinearSearch(arrNumbers, searchKey);
		output = (elementIndex != -1)
			? $"Found value in element {elementIndex}"
			: "Value not found.";

		Console.WriteLine(output);
	}
}
