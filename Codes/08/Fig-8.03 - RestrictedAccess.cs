// Fig. 8.3: RestrictedAccess.cs
// Demonstra erros de compilação da tentativa de acessar membros de classe privados.

using System;

// Cole a classe Time1 (Fig-8.01 - Time1.cs) aqui.

static class RestrictedAccess
{
	static void Main(string[] args)
	{
		Time1 time = new Time1();

		time.hour = 7;
		time.minute = 15;
		time.second = 30;
	}
}
