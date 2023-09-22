// Fig. 6.16: FibonacciTest.cs
// Método de geração recursiva de números de Fibonacci.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class FibonacciTest : Form
{
	private Button calculateButton;

	private TextBox inputTextBox;

	private Label displayLabel;
	private Label promptLabel;

	private void InitializeComponent()
	{
		this.calculateButton = new Button();

		this.inputTextBox = new TextBox();

		this.displayLabel = new Label();
		this.promptLabel = new Label();

		// calculateButton.
		this.calculateButton.Name = "calculateButton";
		this.calculateButton.Text = "Calculate";
		this.calculateButton.AutoSize = true;
		this.calculateButton.Location = new Point(10, 40);
		this.calculateButton.Click += new EventHandler(calculateButton_Click);

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "Enter a Integer";
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 10);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "38";
		this.inputTextBox.AutoSize = true;
		this.inputTextBox.Location = new Point(100, 10);

		// promptLabel.
		this.promptLabel.Name = "promptLabel";
		this.promptLabel.Text = "";
		this.promptLabel.AutoSize = true;
		this.promptLabel.Location = new Point(100, 40);

		// FibonacciTest.
		this.Controls.AddRange(new Control[]{
			this.calculateButton, this.inputTextBox,
			this.displayLabel, this.promptLabel
		});
		this.Name = "FibonacciTest";
		this.Text = "FibonacciTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public int Fibonacci(int number)
	{
		if (number == 0 || number == 1)
			return number;
		else
			return Fibonacci(number - 1) + Fibonacci(number - 2);
	}

	private void calculateButton_Click(object? sender, EventArgs e)
	{
		int number = Convert.ToInt32(inputTextBox.Text);
		int fibonacciNumber = Fibonacci(number);

		promptLabel.Text = "Fibonacci Value is " + fibonacciNumber;
	}
}

partial class FibonacciTest
{
	private Container? components = null;

	public FibonacciTest()
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
		Application.Run(new FibonacciTest());
	}
}
