// 5.06: Estrutura de repetição - do/while.
// Semelhante ao while, porém;
// O teste da condição de continuação do laço ocorre no início do laço. 

using System;

static class Program
{
	static void Main(string[] args)
	{
		int counter = 1;

		do
		{
			Console.WriteLine(counter);
			counter++;
		} while (counter <= 5);
	}
}
