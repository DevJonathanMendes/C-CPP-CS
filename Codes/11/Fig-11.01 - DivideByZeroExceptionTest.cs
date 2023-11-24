// Fig. 11.1: DivideByZeroException.cs
// Fundamentos do tratamento de exceções do C#.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// A classe demonstra como tratar exceções de
// divisão por zero em aritmética de inteiros e de
// formatação numérica imprópria.
partial class DivideByZeroTest : Form
{
	private Label numeratorLabel;
	private TextBox numeratorTextBox;

	private Label denominatorLabel;
	private TextBox denominatorTextBox;

	private Button divideButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.numeratorLabel = new Label();
		this.numeratorTextBox = new TextBox();
		this.denominatorLabel = new Label();
		this.denominatorTextBox = new TextBox();
		this.divideButton = new Button();
		this.outputLabel = new Label();

		// numeratorLabel.
		this.numeratorLabel.Name = "numeratorLabel";
		this.numeratorLabel.Text = "Enter numerator";
		this.numeratorLabel.AutoSize = true;
		this.numeratorLabel.Location = new Point(10, 10);

		// numeratorTextBox.
		this.numeratorTextBox.Name = "numeratorTextBox";
		this.numeratorTextBox.Text = "";
		this.numeratorTextBox.Location = new Point(130, 10);

		// denominatorLabel.
		this.denominatorLabel.Name = "denominatorLabel";
		this.denominatorLabel.Text = "Enter denominator";
		this.denominatorLabel.AutoSize = true;
		this.denominatorLabel.Location = new Point(10, 40);

		// denominatorTextBox.
		this.denominatorTextBox.Name = "denominatorTextBox";
		this.denominatorTextBox.Text = "";
		this.denominatorTextBox.Location = new Point(130, 40);

		// divideButton.
		this.divideButton.Name = "divideButton";
		this.divideButton.Text = "Click to Divide";
		this.divideButton.AutoSize = true;
		this.divideButton.Location = new Point(10, 80);
		this.divideButton.Click += new EventHandler(divideButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		//this.outputLabel.AutoSize = true;
		this.outputLabel.BorderStyle = BorderStyle.Fixed3D;
		this.outputLabel.Location = new Point(130, 80);

		// DivideByZeroTest.
		this.Controls.AddRange(new Control[]{
			this.numeratorLabel, this.numeratorTextBox,
			this.denominatorLabel, this.denominatorTextBox,
			this.divideButton, this.outputLabel
		});
		this.Name = "DivideByZeroTest";
		this.Text = "DivideByZeroTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void divideButton_Click(object? sender, EventArgs e)
	{
		outputLabel.Text = "";

		// Recupera a entrada do usuário e chama Quotient.
		try
		{
			// Convert.ToInt32 gera FormatException se
			// o argumento não for um inteiro.
			int numerator = Convert.ToInt32(numeratorTextBox.Text);
			int denominator = Convert.ToInt32(denominatorTextBox.Text);

			// A divisão gera DivideByZeroException se
			// o denominator for 0.
			int result = numerator / denominator;

			outputLabel.Text = result.ToString();
		}
		// Processa o formato de número inválido.
		catch (FormatException)
		{
			MessageBox.Show("You must enter two integer",
				"Invalid Number Format",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		// O usuário tentou dividir por zero.
		catch (DivideByZeroException divideByZeroException)
		{
			MessageBox.Show(divideByZeroException.Message,
				"Attempted to Divide by Zero",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}

partial class DivideByZeroTest
{
	private Container? components = null;

	public DivideByZeroTest()
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
		Application.Run(new DivideByZeroTest());
	}
}
