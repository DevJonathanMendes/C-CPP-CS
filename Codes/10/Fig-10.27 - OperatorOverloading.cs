// Fig. 10.27: OperatorOverloading.cs
// Um exemplo que usa sobrecarga de operadores.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe ComplexNumber (Fig-10.26 - ComplexNumber.cs) aqui.

partial class OperatorOverloading : Form
{
	private Label realLabel;
	private Label imaginaryLabel;
	private Label statusLabel;

	private TextBox realTextBox;
	private TextBox imaginaryTextBox;

	private Button firstButton;
	private Button secondButton;
	private Button addButton;
	private Button subtractButton;
	private Button multiplyButton;

	private ComplexNumber y = new ComplexNumber();
	private ComplexNumber x = new ComplexNumber();

	private void InitializeComponent()
	{
		this.realLabel = new Label();
		this.imaginaryLabel = new Label();
		this.statusLabel = new Label();

		this.realTextBox = new TextBox();
		this.imaginaryTextBox = new TextBox();

		this.firstButton = new Button();
		this.secondButton = new Button();
		this.addButton = new Button();
		this.subtractButton = new Button();
		this.multiplyButton = new Button();

		// realLabel.
		this.realLabel.Name = "realLabel";
		this.realLabel.Text = "Real";
		this.realLabel.AutoSize = true;
		this.realLabel.Location = new Point(10, 10);

		// imaginaryLabel.
		this.imaginaryLabel.Name = "imaginaryLabel";
		this.imaginaryLabel.Text = "Imaginary";
		this.imaginaryLabel.AutoSize = true;
		this.imaginaryLabel.Location = new Point(10, 40);

		// realTextBox.
		this.realTextBox.Name = "realTextBox";
		this.realTextBox.Text = "";
		this.realTextBox.Location = new Point(80, 10);

		// imaginaryTextBox.
		this.imaginaryTextBox.Name = "imaginaryTextBox";
		this.imaginaryTextBox.Text = "";
		this.imaginaryTextBox.Location = new Point(80, 40);

		// firstButton.
		this.firstButton.Name = "firstButton";
		this.firstButton.Text = "Set First Complex Number";
		this.firstButton.AutoSize = true;
		this.firstButton.Location = new Point(180, 10);
		this.firstButton.Click += new EventHandler(firstButton_Click);

		// secondButton.
		this.secondButton.Name = "secondButton";
		this.secondButton.Text = "Set Second Complex Number";
		this.secondButton.AutoSize = true;
		this.secondButton.Location = new Point(180, 40);
		this.secondButton.Click += new EventHandler(secondButton_Click);

		// addButton.
		this.addButton.Name = "addButton";
		this.addButton.Text = "+";
		this.addButton.AutoSize = true;
		this.addButton.Location = new Point(10, 80);
		this.addButton.Click += new EventHandler(addButton_Click);

		// subtractButton.
		this.subtractButton.Name = "subtractButton";
		this.subtractButton.Text = "-";
		this.subtractButton.AutoSize = true;
		this.subtractButton.Location = new Point(90, 80);
		this.subtractButton.Click += new EventHandler(subtractButton_Click);

		// multiplyButton.
		this.multiplyButton.Name = "multiplyButton";
		this.multiplyButton.Text = "+";
		this.multiplyButton.AutoSize = true;
		this.multiplyButton.Location = new Point(170, 80);
		this.multiplyButton.Click += new EventHandler(multiplyButton_Click);

		// statusLabel.
		this.statusLabel.Name = "statusLabel";
		this.statusLabel.Text = "";
		this.statusLabel.AutoSize = true;
		this.statusLabel.Location = new Point(10, 120);

		// OperatorOverloading.
		this.Controls.AddRange(new Control[]{
			this.realLabel, this.imaginaryLabel,
			this.statusLabel, this.realTextBox,
			this.imaginaryTextBox, this.firstButton,
			this.secondButton, this.addButton,
			this.subtractButton, this.multiplyButton
		});
		this.Name = "OperatorOverloading";
		this.Text = "OperatorOverloading";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void firstButton_Click(object? sender, EventArgs e)
	{
		x.Real = Int32.Parse(realTextBox.Text);
		x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
		realTextBox.Clear();
		imaginaryTextBox.Clear();
		statusLabel.Text = "First Complex Number is: " + x;
	}

	private void secondButton_Click(object? sender, EventArgs e)
	{
		y.Real = Int32.Parse(realTextBox.Text);
		y.Imaginary = Int32.Parse(imaginaryTextBox.Text);
		realTextBox.Clear();
		imaginaryTextBox.Clear();
		statusLabel.Text = "Second Complex Number is: " + y;
	}

	private void addButton_Click(object? sender, EventArgs e)
	{ statusLabel.Text = x + " + " + y + " = " + (x + y); }

	private void subtractButton_Click(object? sender, EventArgs e)
	{ statusLabel.Text = x + " - " + y + " = " + (x - y); }

	private void multiplyButton_Click(object? sender, EventArgs e)
	{ statusLabel.Text = x + " * " + y + " = " + (x * y); }
}

partial class OperatorOverloading
{
	private Container? components = null;

	public OperatorOverloading()
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
		Application.Run(new OperatorOverloading());
	}
}
