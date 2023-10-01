// Fig. 7.8: PassArray.cs
// Passando arrays e elementos individuais a métodos.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class PassArray : Form
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
		this.showOutputButton.Click += new EventHandler(this.showOutputButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// PassArray.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "PassArray";
		this.Text = "PassArray";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		int[] a = { 1, 2, 3, 4, 5 };

		outputLabel.Text = "Effect of passing entire array " +
			"call-by-reference:\n\nThe values of the original " +
			"array are:\n\t";

		for (int i = 0; i < a.Length; i++)
			outputLabel.Text += "  " + a[i];

		ModifyArray(a);

		outputLabel.Text += "\n\nThe values of the modified array are:\n\t";

		for (int i = 0; i < a.Length; i++)
			outputLabel.Text += "  " + a[i];

		outputLabel.Text += "\n\nEffect of passing entire array " +
			"call-by-reference:\n\na[3] before " +
			"ModifyElement: " + a[3];

		ModifyElement(a[3]);

		outputLabel.Text += "\na[3] after ModifyElement: " + a[3];
	}

	public void ModifyArray(int[] b)
	{
		for (int j = 0; j < b.Length; j++)
			b[j] *= 2;
	}

	public void ModifyElement(int e)
	{
		outputLabel.Text += "\nvalue received in ModifyElement: " + e;

		e *= 2;

		outputLabel.Text += "\nvalue calculated in ModifyElement: " + e;
	}
}

partial class PassArray
{
	private Container? components = null;

	public PassArray()
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
		Application.Run(new PassArray());
	}
}
