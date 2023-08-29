// 8.4: Controlando Acesso aos Membros.
// Os modificadores de acesso a membro "public" e "private" controlam
// o acesso aos dados e e métodos de uma classe.

using System;

class User : Object
{
	public string username = "Jonathan";
	private string password = "thanjona123"; // Se omitir o modificador de acesso, "private" é o padrão.
}

static class Program
{
	static void Main(string[] args)
	{
		User TestUser = new User();

		Console.WriteLine(TestUser.username);
		Console.WriteLine(TestUser.password); // Gera um erro de inacessibilidade.
	}
}
