// Fig. 6.13: Scoping.cs
// Demonstrando o escopo de variáveis locais e de instância.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class Scoping : Form
{
	private Label outputLabel;
	private Button showOutputButton;

	public int x = 1;

	private void InitializeComponent()
	{
		this.outputLabel = new Label();
		this.showOutputButton = new Button();

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

		// Scoping.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "Scoping";
		this.Text = "Scoping";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public void MethodA()
	{
		int x = 25;

		outputLabel.Text = outputLabel.Text +
			"\n\nlocal x in MethodA is " + x +
			" after entering MethodA";

		++x;

		outputLabel.Text = outputLabel.Text +
			"\nlocal x in MethodA is " + x +
			" before exiting MethodA";
	}

	public void MethodB()
	{
		outputLabel.Text = outputLabel.Text +
			"\n\ninstance variable x in MethodB is " + x +
			" on entering MethodB";

		x *= 10;

		outputLabel.Text = outputLabel.Text +
			"\ninstance variable x in MethodB is " + x +
			" on exiting MethodB";
	}

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		int x = 5;

		outputLabel.Text = "local x in method showOutputButton_Click is " + x;

		MethodA();
		MethodB();
		MethodA();
		MethodB();

		outputLabel.Text = outputLabel.Text + "\n\n" +
			"local x in method showOutputButton_Click is " + x;
	}
}

partial class Scoping
{
	private Container? components = null;

	public Scoping()
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
		Application.Run(new Scoping());
	}
}
