// Fig. 6.8: RefOutTest.cs
// Demonstrando parâmetros ref e out.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class RefOutTest : Form
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

		// RefOutTest.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "RefOutTest";
		this.Text = "RefOutTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	void SquareRef(ref int x)
	{ x = x * x; }

	void SquareOut(out int x)
	{
		x = 6;
		x = x * x;
	}

	void Square(int x)
	{ x = x *= x; }

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		int y = 5;
		int z;

		outputLabel.Text = "Original value of y: " + y + "\n";
		outputLabel.Text += "Original value of z: uninitialized\n\n";

		SquareRef(ref y);
		SquareOut(out z);

		outputLabel.Text += "Value of y after SquareRef: " + y + "\n";
		outputLabel.Text += "Value of z after SquareOut: " + z + "\n\n";

		Square(y);
		Square(z);

		outputLabel.Text += "Value of y after Square: " + y + "\n";
		outputLabel.Text += "Value of z after Square: " + z + "\n";
	}
}

partial class RefOutTest
{
	private Container? components = null;

	public RefOutTest()
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
		Application.Run(new RefOutTest());
	}
}
