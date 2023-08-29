// 8.5: Inicializando Objetos de uma Classe: Construtores.
// Quando uma instância de classe é iniciada, ela chama o construtor.
// Pode conter construtores sobrecarregados.

// Se omitir um construtor, o padrão é fornecido, não contém argumentos.

using System;

class User : Object
{
	public string username;
	public string? email; // "?" Define como "pode ser anulável".
	private string password; // Se omitir o modificador de acesso, "private" é o padrão.

	// Constructor.
	public User(string nameValue, string passValue)
	{
		username = nameValue;
		password = passValue;
	}

	// Constructor Sobrecarga.
	public User(string nameValue, string passValue, string emailValue)
	{
		username = nameValue;
		password = passValue;
		email = emailValue;
	}
}

static class Program
{
	static void Main(string[] args)
	{
		// new indica que um novo objeto está sendo criado.
		User TestUser1 = new User("Jonathan", "qwerty123");
		User TestUser2 = new User("John", "123qwerty", "john@email.com");

		Console.WriteLine(TestUser1.username);
		Console.WriteLine(TestUser1.email); // Não foi definida.

		Console.WriteLine(TestUser2.username);
		Console.WriteLine(TestUser2.email);
	}
}
