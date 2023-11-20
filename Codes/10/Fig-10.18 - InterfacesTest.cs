// Fig. 10.18: [InterfacesTest.cs] ()\
// Demonstrando o polimorfismo com interfaces.

using System;
using System.Windows.Forms;

// Cole a interface IAge (Fig-10.15 - IAge.cs) aqui.

// Cole a classe Person (Fig-10.16 - Person.cs) aqui.

// Cole a Classe Tree (Fig-10.17 - Tree.cs) aqui.

public class InterfacesTest
{
	public static void Main(string[] args)
	{
		Tree tree = new Tree(1978);
		Person person = new Person("Bob", "Jones", 1971);

		// Cria array de referências a IAge.
		IAge[] iAgeArray = new IAge[2];

		iAgeArray[0] = tree;
		iAgeArray[1] = person;

		string output = tree + ": " + tree.Name + "\nAge is " +
			tree.Age + "\n\n";

		output += person + ": " + person.Name + "\nAge is " +
			person.Age + "\n\n";

		foreach (IAge ageReference in iAgeArray)
		{
			output += ageReference.Name + ": Age is " +
				person.Age + "\n";
		}

		MessageBox.Show(output, "Demonstrating Polymorphism");
	}
}
