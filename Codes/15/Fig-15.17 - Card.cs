// Fig. 15.17: Card.cs
// Armazena informações de naipe e valor de cada carta.

using System;

// A representação de uma carta.
public class Card
{
	private string face;
	private string suit;

	public Card(string faceValue, string suitValue)
	{
		face = faceValue;
		suit = suitValue;
	}

	public override string ToString()
	{
		return face + " of " + suit;
	}
}
