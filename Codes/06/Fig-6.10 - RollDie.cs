// Fig. 6.10: RollDie.cs
// Usando a geração de números aleatórios para simular o lançamento de dados.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

partial class RollDie : Form
{
	private Button rollButton;

	private Label dieLabel1;
	private Label dieLabel2;
	private Label dieLabel3;
	private Label dieLabel4;

	private Random randomNumber = new Random();

	private void InitializeComponent()
	{
		this.rollButton = new Button();

		this.dieLabel1 = new Label();
		this.dieLabel2 = new Label();
		this.dieLabel3 = new Label();
		this.dieLabel4 = new Label();

		// dieLabel1.
		this.dieLabel1.Name = "dieLabel1";
		this.dieLabel1.Text = "";
		this.dieLabel1.AutoSize = true;
		this.dieLabel1.Location = new Point(10, 10);

		// dieLabel2.
		this.dieLabel2.Name = "dieLabel2";
		this.dieLabel2.Text = "";
		this.dieLabel2.AutoSize = true;
		this.dieLabel2.Location = new Point(40, 10);

		// dieLabel3.
		this.dieLabel3.Name = "dieLabel3";
		this.dieLabel3.Text = "";
		this.dieLabel3.AutoSize = true;
		this.dieLabel3.Location = new Point(10, 40);

		// dieLabel4.
		this.dieLabel4.Name = "dieLabel4";
		this.dieLabel4.Text = "";
		this.dieLabel4.AutoSize = true;
		this.dieLabel4.Location = new Point(40, 40);

		// rollButton.
		this.rollButton.Name = "rollButton";
		this.rollButton.Text = "Roll";
		this.rollButton.AutoSize = true;
		this.rollButton.Location = new Point(10, 70);
		this.rollButton.Click += new EventHandler(rollButton_Click);

		// RollDie.
		this.Controls.AddRange(new Control[]{
			this.rollButton, this.dieLabel1,
			this.dieLabel2, this.dieLabel3,
			this.dieLabel4
	});
		this.Name = "RollDie";
		this.Text = "RollDie";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	protected void rollButton_Click(object? sender, EventArgs e)
	{
		DisplayDie(dieLabel1);
		DisplayDie(dieLabel2);
		DisplayDie(dieLabel3);
		DisplayDie(dieLabel4);
	}

	public void DisplayDie(Label dieLabel)
	{
		int face = randomNumber.Next(1, 7);

		dieLabel.Text = $"{face}";

		/* dieLabel.Image = Image.FromFile(
			Directory.GetCurrentDirectory() +
			"\\images\\die" + face + ".gif"
		); */
	}
}

partial class RollDie
{
	private Container? components = null;

	public RollDie()
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
		Application.Run(new RollDie());
	}
}
