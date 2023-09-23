// Fig. 6.18: MethodOverload.cs
// Usando métodos sobrecarregados.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class MethodOverload : Form
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

		// MethodOverload.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "MethodOverload";
		this.Text = "MethodOverload";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public int Square(int x)
	{ return x * x; }

	public double Square(double y)
	{ return y * y; }

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		outputLabel.Text =
			"The square of integer 7 is " + Square(7) +
			"\nThe square of double 7.5 is " + Square(7.5);
	}
}

partial class MethodOverload
{
	private Container? components = null;

	public MethodOverload()
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
		Application.Run(new MethodOverload());
	}
}
