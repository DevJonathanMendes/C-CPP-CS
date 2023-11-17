// Fig. 10.12: PieceWorker.cs
// Classe PieceWorker derivada de Employee.

using System;

// Cole a classe Employee (Fig-10.09 - Employee.cs) aqui.

// Cole a classe Boss (Fig-10.10 - Boss.cs) aqui.

// Cole a classe CommissionWorker (Fig-10.11 - CommissionWorker.cs) aqui.

public class PieceWorker : Employee
{
	private decimal wagePerPiece;
	private int quantity;

	public PieceWorker(string firstNameValue, string lastNameValue,
		decimal wagePerPieceValue, int quantityValue)
		: base(firstNameValue, lastNameValue)
	{
		WagePerPiece = wagePerPieceValue;
		Quantity = quantityValue;
	}

	public decimal WagePerPiece
	{
		get { return wagePerPiece; }
		set { if (value > 0) wagePerPiece = value; }
	}

	public int Quantity
	{
		get { return quantity; }
		set { if (value > 0) quantity = value; }
	}

	public override decimal Earning()
	{ return Quantity * WagePerPiece; }

	public override string ToString()
	{ return "Piece Worker: " + base.ToString(); }
}
