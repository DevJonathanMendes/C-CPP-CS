// Fig. 6.4: MaximumValue.cs
// Encontrando o máximo de três valores double.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class MaximumValue : Form
{
	private Label firstNumberLabel;
	private Label secondNumberLabel;
	private Label thirdNumberLabel;
	private Label maximumLabel;
	private TextBox firstNumberTextBox;
	private TextBox secondNumberTextBox;
	private TextBox thirdNumberTextBox;
	private Button calculateButton;

	private void InitializeComponent()
	{
		this.firstNumberLabel = new Label();
		this.secondNumberLabel = new Label();
		this.thirdNumberLabel = new Label();
		this.maximumLabel = new Label();
		this.firstNumberTextBox = new TextBox();
		this.secondNumberTextBox = new TextBox();
		this.thirdNumberTextBox = new TextBox();
		this.calculateButton = new Button();

		// firstNumberLabel.
		this.firstNumberLabel.Name = "firstNumberLabel";
		this.firstNumberLabel.Text = "First Floating-Point Value:";
		this.firstNumberLabel.AutoSize = true;
		this.firstNumberLabel.Location = new Point(8, 16);

		// secondNumberLabel.
		this.secondNumberLabel.Name = "secondNumberLabel";
		this.secondNumberLabel.Text = "Second Floating-Point Value:";
		this.secondNumberLabel.AutoSize = true;
		this.secondNumberLabel.Location = new Point(8, 48);

		// thirdNumberLabel.
		this.thirdNumberLabel.Name = "thirdNumberLabel";
		this.thirdNumberLabel.Text = "Third Floating-Point Value:";
		this.thirdNumberLabel.AutoSize = true;
		this.thirdNumberLabel.Location = new Point(8, 80);

		// maximumLabel.
		this.maximumLabel.Name = "maximumLabel";
		this.maximumLabel.Text = "";
		this.maximumLabel.AutoSize = true;
		this.maximumLabel.Location = new Point(176, 120);

		// firstNumberTextBox.
		this.firstNumberTextBox.Name = "firstNumberTextBox";
		this.firstNumberTextBox.Text = "";
		this.firstNumberTextBox.AutoSize = true;
		this.firstNumberTextBox.Location = new Point(176, 16);

		// secondNumberTextBox.
		this.secondNumberTextBox.Name = "secondNumberTextBox";
		this.secondNumberTextBox.Text = "";
		this.secondNumberTextBox.AutoSize = true;
		this.secondNumberTextBox.Location = new Point(176, 49);

		// thirdNumberTextBox.
		this.thirdNumberTextBox.Name = "thirdNumberTextBox";
		this.thirdNumberTextBox.Text = "";
		this.thirdNumberTextBox.AutoSize = true;
		this.thirdNumberTextBox.Location = new Point(176, 81);

		// calculateButton.
		this.calculateButton.Name = "calculateButton";
		this.calculateButton.Text = "Calculate Maximum";
		this.calculateButton.AutoSize = true;
		this.calculateButton.Location = new Point(24, 120);
		this.calculateButton.Click += new EventHandler(this.calculateButton_Click);

		// MaximumValue
		this.Controls.AddRange(new Control[]{
			this.firstNumberLabel, this.secondNumberLabel,
			this.thirdNumberLabel, this.maximumLabel,
			this.firstNumberTextBox, this.secondNumberTextBox,
			this.thirdNumberTextBox, this.calculateButton,
		});
		this.Name = "MaximumValue";
		this.Text = "MaximumValue";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	double Maximum(double x, double y, double z)
	{
		return Math.Max(x, Math.Max(y, z));
	}

	private void calculateButton_Click(object? sender, EventArgs e)
	{
		double number1 = Double.Parse(firstNumberTextBox.Text);
		double number2 = Double.Parse(secondNumberTextBox.Text);
		double number3 = Double.Parse(thirdNumberTextBox.Text);

		double maximum = Maximum(number1, number2, number3);

		maximumLabel.Text = "maximum is: " + maximum;
	}
}

partial class MaximumValue
{
	private Container? components = null;

	public MaximumValue()
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
		Application.Run(new MaximumValue());
	}
}
