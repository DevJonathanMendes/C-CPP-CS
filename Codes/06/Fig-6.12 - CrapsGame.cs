// Fig. 6.12: CrapsGame.cs
// Simulando o jogo de craps.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class CrapsGame : Form
{
	private Button rollButton;
	private Button playButton;

	int myPoint;

	private Label statusLabel;
	// private PictureBox pointFirstDieImage;
	// private PictureBox pointSecondDieImagem;
	// private PictureBox firstDieImage;
	// private PictureBox secondDieImage;
	private Label pointFirstDieImage;
	private Label pointSecondDieImagem;
	private Label firstDieImage;
	private Label secondDieImage;
	private GroupBox pointGroupBox;
	int myDie1;
	int myDie2;

	public enum DiceNames
	{
		SNAKE_EYES = 2,
		TREY = 3,
		YO_LEVEL = 11,
		BOX_CARS = 12,
	}

	private void InitializeComponent()
	{
		this.rollButton = new Button();
		this.playButton = new Button();

		this.statusLabel = new Label();
		// this.pointFirstDieImage = new PictureBox();
		// this.pointSecondDieImagem = new PictureBox();
		// this.firstDieImage = new PictureBox();
		// this.secondDieImage = new PictureBox();
		this.pointFirstDieImage = new Label();
		this.pointSecondDieImagem = new Label();
		this.firstDieImage = new Label();
		this.secondDieImage = new Label();
		this.pointGroupBox = new GroupBox();

		// rollButton.
		this.rollButton.Name = "rollButton";
		this.rollButton.Text = "Roll";
		this.rollButton.AutoSize = true;
		this.rollButton.Location = new Point(100, 30);
		this.rollButton.Click += new EventHandler(rollButton_Click);

		// playButton.
		this.playButton.Name = "playButton";
		this.playButton.Text = "Play";
		this.playButton.AutoSize = true;
		this.playButton.Location = new Point(100, 60);
		this.playButton.Click += new EventHandler(playButton_Click);

		// statusLabel.
		this.statusLabel.Name = "statusLabel";
		this.statusLabel.Text = "";
		this.statusLabel.AutoSize = true;
		this.statusLabel.Location = new Point(180, 70);

		// pointGroupBox.
		this.pointGroupBox.Name = "pointGroupBox";
		this.pointGroupBox.Text = "Point";
		this.pointGroupBox.Size = new Size(80, 70);
		this.pointGroupBox.Location = new Point(10, 20);
		this.pointGroupBox.Controls.AddRange(new Control[]{
			this.pointFirstDieImage, this.pointSecondDieImagem
		});

		// pointFirstDieImage.
		this.pointFirstDieImage.Name = "pointFirstDieImage";
		this.pointFirstDieImage.Text = "";
		this.pointFirstDieImage.AutoSize = true;
		this.pointFirstDieImage.Location = new Point(20, 20);

		// pointSecondDieImagem.
		this.pointSecondDieImagem.Name = "pointSecondDieImagem";
		this.pointSecondDieImagem.Text = "";
		this.pointSecondDieImagem.AutoSize = true;
		this.pointSecondDieImagem.Location = new Point(50, 20);

		// firstDieImage.
		this.firstDieImage.Name = "firstDieImage";
		this.firstDieImage.Text = "";
		this.firstDieImage.AutoSize = true;
		this.firstDieImage.Location = new Point(30, 100);

		// secondDieImage.
		this.secondDieImage.Name = "secondDieImage";
		this.secondDieImage.Text = "";
		this.secondDieImage.AutoSize = true;
		this.secondDieImage.Location = new Point(60, 100);

		// CrapsGame.
		this.Controls.AddRange(new Control[]{
			this.rollButton, this.playButton,
			this.statusLabel, this.pointGroupBox,
			this.firstDieImage, this.secondDieImage
		});
		this.Name = "CrapsGame";
		this.Text = "CrapsGame";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	protected void rollButton_Click(object? sender, EventArgs e)
	{
		int sum = rollDice();

		if (sum == myPoint)
		{
			statusLabel.Text = "You Win!!!";
			rollButton.Enabled = false;
			playButton.Enabled = true;
		}
		else if (sum == 7)
		{
			statusLabel.Text = "Sorry. You lose.";
			rollButton.Enabled = true;
			playButton.Enabled = false;
		}
	}

	protected void playButton_Click(object? sender, EventArgs e)
	{
		pointGroupBox.Text = "Point";
		statusLabel.Text = "";
		pointFirstDieImage.Image = null;
		pointSecondDieImagem.Image = null;

		myPoint = 0;
		int sum = rollDice();

		switch (sum)
		{
			case 7:
			case (int)DiceNames.YO_LEVEL:
				rollButton.Enabled = false;
				statusLabel.Text = "You Win!!";
				break;
			case (int)DiceNames.SNAKE_EYES:
			case (int)DiceNames.TREY:
			case (int)DiceNames.BOX_CARS:
				rollButton.Enabled = false;
				statusLabel.Text = "Sorry. You lose.";
				break;
			default:
				myPoint = sum;
				pointGroupBox.Text = "Point is " + sum;
				statusLabel.Text = "Roll again";
				displayDie(pointFirstDieImage, myDie1);
				displayDie(pointSecondDieImagem, myDie2);
				playButton.Enabled = false;
				rollButton.Enabled = true;
				break;
		}
	}

	private void displayDie(Label dieImage /* PictureBox dieImage */, int face)
	{
		dieImage.Text = $"{face}";
		/* dieImage.Image = Image.FromFile(
			Directory.GetCurrentDirectory() +
			"\\images\\die" + face + ".gif"
		); */
	}

	private int rollDice()
	{
		int die1, die2, dieSum;
		Random randomNumber = new Random();

		die1 = randomNumber.Next(1, 7);
		die2 = randomNumber.Next(1, 7);

		displayDie(firstDieImage, die1);
		displayDie(secondDieImage, die2);

		myDie1 = die1;
		myDie2 = die2;
		dieSum = die1 + die2;
		return dieSum;
	}
}

partial class CrapsGame
{
	private Container? components = null;

	public CrapsGame()
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
		Application.Run(new CrapsGame());
	}
}
