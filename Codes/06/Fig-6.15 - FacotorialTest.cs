// Fig. 6.15: FactorialTest.cs
// Calculando fatoriais com recursividade.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class FactorialTest : Form
{
	private Button showFactorialsButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.showFactorialsButton = new Button();
		this.outputLabel = new Label();

		// showFactorialsButton.
		this.showFactorialsButton.Name = "showFactorialsButton";
		this.showFactorialsButton.Text = "Show Factorials";
		this.showFactorialsButton.AutoSize = true;
		this.showFactorialsButton.Location = new Point(10, 10);
		this.showFactorialsButton.Click += new EventHandler(showFactorialsButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// FactorialTest.
		this.Controls.AddRange(new Control[]{
			this.showFactorialsButton, this.outputLabel
		});
		this.Name = "FactorialTest";
		this.Text = "FactorialTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public long Factorial(long number)
	{
		if (number <= 1)
			return 1;
		else
			return number * Factorial(number - 1);
	}

	private void showFactorialsButton_Click(object? sender, EventArgs e)
	{
		outputLabel.Text = "";

		for (long i = 0; i <= 10; i++)
			outputLabel.Text += i + "! = " +
				Factorial(i) + "\n";
	}
}

partial class FactorialTest
{
	private Container? components = null;

	public FactorialTest()
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
		Application.Run(new FactorialTest());
	}
}
