// Fig. 6.3: SquareInt.cs
// Demonstrando um método Square definido pelo programador.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class SquareInt : Form
{
	private Button calculateButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.calculateButton = new Button();
		this.outputLabel = new Label();

		// calculateButton
		this.calculateButton.Name = "calculateButton";
		this.calculateButton.Text = "Calculate Squares";
		this.calculateButton.AutoSize = true;
		this.calculateButton.Location = new Point(10, 10);
		this.calculateButton.Click += new EventHandler(this.calculateButton_Click);

		// outputLabel
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);
		this.outputLabel.Click += new EventHandler(this.calculateButton_Click);

		// SquareInt
		this.Controls.AddRange(new Control[]{
			this.calculateButton, this.outputLabel
		});
		this.Name = "SquareInt";
		this.Text = "SquareInt";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}
	int Square(int y)
	{ return y * y; }

	private void calculateButton_Click(object? sender, EventArgs e)
	{
		outputLabel.Text = "";

		for (int counter = 1; counter <= 10; counter++)
		{
			int result = Square(counter);
			outputLabel.Text += "The square of " + counter + " is " + result + "\n";
		}
	}
}

partial class SquareInt
{
	private Container? components = null;

	public SquareInt()
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
		Application.Run(new SquareInt());
	}
}
