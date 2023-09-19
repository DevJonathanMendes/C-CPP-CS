// Fig. 6.9: RandomInt.cs
// Gerando valores inteiros aleatórios.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class RandomInt : Form
{
	private Button showOutputButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.showOutputButton = new Button();
		this.outputLabel = new Label();

		// showOutputButton.
		this.showOutputButton.Name = "showOutputButton";
		this.showOutputButton.Text = "Show Output";
		this.showOutputButton.AutoSize = true;
		this.showOutputButton.Location = new Point(10, 10);
		this.showOutputButton.Click += new EventHandler(showOutputButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// RandomInt.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "RandomInt";
		this.Text = "RandomInt";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		Random randomInteger = new Random();
		outputLabel.Text = "";

		for (int counter = 1; counter <= 20; counter++)
		{
			int nextValue = randomInteger.Next(1, 7);

			outputLabel.Text += nextValue + "  ";

			if (counter % 5 == 0)
				outputLabel.Text += "\n";
		}
	}
}

partial class RandomInt
{
	private Container? components = null;

	public RandomInt()
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
		Application.Run(new RandomInt());
	}
}
