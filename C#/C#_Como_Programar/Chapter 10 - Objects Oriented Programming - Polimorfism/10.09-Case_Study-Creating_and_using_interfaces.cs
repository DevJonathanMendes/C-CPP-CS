// 10.09: Estudo de caso: Criando e usando interfaces.
// Apresentaremos dois exemplos de polimorfismo, usando interfaces que
// especificam conjuntos de serviços public que as classes devem implementar.

// Usamos interface quando não há implementação padrão para herdar.
// Enquanto classes abstratas é mais bem usada para fornecer dados e serviços
// para objetos em um relacionamento hierárquico.

using System;

// Interface que declara propriedade para configurar e obter a idade.
public interface IAge
{
	int Age { get; }
	string Name { get; }
}

// Implementa a interface.
public class Person : IAge
{
	private string firstName;
	private string lastName;
	private int yearBorn;

	public Person(string fNameValue, string lNameValue, int yearBornValue)
	{
		firstName = fNameValue;
		lastName = lNameValue;

		if (yearBornValue > 0 && yearBornValue <= DateTime.Now.Year)
			yearBorn = yearBornValue;
		else
			yearBorn = DateTime.Now.Year;
	}

	public int Age
	{ get { return DateTime.Now.Year - yearBorn; } }

	public string Name
	{ get { return $"{firstName} {lastName}"; } }
}

static class Program
{
	static void Main(string[] args)
	{
		Person person = new Person("Jonathan", "Mendes", 2001);

		Console.WriteLine("\nDemonstrating Polymorphism\n");
		Console.WriteLine($"Person: {person.Name}");
		Console.WriteLine($"Age is: {person.Age}\n");
	}
}
