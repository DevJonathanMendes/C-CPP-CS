// Fig. 15.18: DeckOfCards.cs
// Simulando distribuição e embaralhamento de cartas.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe Card (Fig-15.17 - Card.cs) aqui.

partial class DeckOfCards : Form
{
	private Button dealButton;
	private Button shuffleButton;

	private Label displayLabel;
	private Label statusLabel;

	private Card[] deck = new Card[52];
	private int currentCard;

	private void InitializeComponent()
	{
		this.dealButton = new Button();
		this.shuffleButton = new Button();

		this.displayLabel = new Label();
		this.statusLabel = new Label();

		// dealButton.
		this.dealButton.Name = "dealButton";
		this.dealButton.Text = "Deal Card";
		this.dealButton.AutoSize = true;
		this.dealButton.Location = new Point(10, 10);
		this.dealButton.Click += new EventHandler(dealButton_Click);

		// shuffleButton.
		this.shuffleButton.Name = "shuffleButton";
		this.shuffleButton.Text = "Shuffle Card";
		this.shuffleButton.AutoSize = true;
		this.shuffleButton.Location = new Point(110, 10);
		this.shuffleButton.Click += new EventHandler(shuffleButton_Click);

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "";
		this.displayLabel.BorderStyle = BorderStyle.Fixed3D;
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 40);

		// statusLabel.
		this.statusLabel.Name = "statusLabel";
		this.statusLabel.Text = "";
		this.statusLabel.BorderStyle = BorderStyle.Fixed3D;
		this.statusLabel.AutoSize = true;
		this.statusLabel.Location = new Point(10, 70);

		// DeckOfCards.
		this.Load += new EventHandler(DeckForm_Load);
		this.Controls.AddRange(new Control[]{
			this.dealButton, this.shuffleButton,
			this.displayLabel, this.statusLabel
		});
		this.Name = "DeckOfCards";
		this.Text = "DeckOfCards";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void DeckForm_Load(object? sender, EventArgs e)
	{
		string[] faces = {
			"Ace", "Deuce", "Three", "Four",
			"Five", "Six", "Seven", "Eight",
			"Nine", "Ten", "Jack", "Queen", "King"
		};

		string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

		// Nenhuma carta foi distribuida.
		currentCard = -1;

		for (int i = 0; i < deck.Length; i++)
			deck[i] = new Card(faces[i % 13], suits[i % 4]);
	}

	private void dealButton_Click(object? sender, EventArgs e)
	{
		Card dealt = DealCard();

		// Se a carta distribuída for nula, então não resta nenhuma carta
		// o jogador deve embaralhar as cartas.
		if (dealt != DealCard())
		{
			displayLabel.Text = dealt.ToString();
			statusLabel.Text = "Card #: " + currentCard;
		}
		else
		{
			displayLabel.Text = "NO MORE CARDS TO DEAL";
			statusLabel.Text = "Shuffle cards to continue";
		}
	}

	private void Shuffle()
	{
		Random randomNumber = new Random();
		Card temporaryValue;

		currentCard = -1;

		for (int i = 0; i < deck.Length; i++)
		{
			int j = randomNumber.Next(52);

			// Troca as cartas.
			temporaryValue = deck[i];
			deck[i] = deck[j];
			deck[j] = temporaryValue;
		}

		dealButton.Enabled = true;
	}

	private Card DealCard()
	{
		// Se houver uma carta para distribuir, então a distribui
		// caso contrário, sinaliza que as cartas precisam ser embaralhadas,
		// desativando dealButton e retornando null.
		if (currentCard + 1 < deck.Length)
		{
			currentCard++;
			return deck[currentCard];
		}
		else
		{
			dealButton.Enabled = false;
			return null;
		}
	}

	private void shuffleButton_Click(object? sender, EventArgs e)
	{
		displayLabel.Text = "SHUFFLING...";
		Shuffle();
		displayLabel.Text = "DECK IS SHUFFLED";
	}
}

partial class DeckOfCards
{
	private Container? components = null;

	public DeckOfCards()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new DeckOfCards());
	}
}
