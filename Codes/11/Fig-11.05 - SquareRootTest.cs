// Fig. 11.5: SquareRootTest.cs
// Demonstrando uma classe de exceção definida pelo programador.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe NegativeNumberException (Fig-11.04 - NegativeNumberException.cs) aqui.

partial class SquareRootTest : Form
{
	private Label inputLabel;
	private TextBox inputTextBox;
	private Button squareRootButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.inputLabel = new Label();
		this.inputTextBox = new TextBox();
		this.squareRootButton = new Button();
		this.outputLabel = new Label();

		// inputLabel.
		this.inputLabel.Name = "inputLabel";
		this.inputLabel.Text = "Please, enter a number";
		this.inputLabel.AutoSize = true;
		this.inputLabel.Location = new Point(10, 10);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.Location = new Point(140, 10);

		// squareRootButton.
		this.squareRootButton.Name = "squareRootButton";
		this.squareRootButton.Text = "Square Root";
		this.squareRootButton.AutoSize = true;
		this.squareRootButton.Location = new Point(10, 40);
		this.squareRootButton.Click += new EventHandler(squareRootButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 80);

		// SquareRootTest.
		this.Controls.AddRange(new Control[]{
			this.inputLabel, this.inputTextBox,
			this.squareRootButton, this.outputLabel
		});
		this.Name = "SquareRootTest";
		this.Text = "SquareRootTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public double SquareRoot(double operand)
	{
		// Se o operando for negativo, lança NegativeNumberException.
		if (operand < 0)
			throw new NegativeNumberException(
				"Square root of negative number not permitted");

		return Math.Sqrt(operand);
	}

	private void squareRootButton_Click(object? sender, EventArgs e)
	{
		outputLabel.Text = "";

		// Captura qualquer NegativeNumberException lançado.
		try
		{
			double result =
				SquareRoot(Double.Parse(inputTextBox.Text));

			outputLabel.Text = result.ToString();
		}
		// Processa formato de número inválido.
		catch (FormatException notInteger)
		{
			MessageBox.Show(notInteger.Message, "Invalid Operation",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		// Exibe a MessageBox se a entrada for um número negativo.
		catch (NegativeNumberException error)
		{
			MessageBox.Show(error.Message, "Invalid Operation",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}

partial class SquareRootTest
{
	private Container? components = null;

	public SquareRootTest()
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
		Application.Run(new SquareRootTest());
	}
}
