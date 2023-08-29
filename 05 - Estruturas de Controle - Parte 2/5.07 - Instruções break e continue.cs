// 5.07: Instruções break e continue.
// Alteram o fluxo de controle
// break: causa a saída.
// continue: pula as instruções restantes

using System;

static class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 10; i++)
		{
			if (i == 3)
				continue;

			if (i == 6)
				break;

			Console.WriteLine(i);
		}
	}
}
