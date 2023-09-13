// Fig. 00.00: Form1.cs
// Descrição.

using System;
using System.Windows.Forms;
using System.ComponentModel;

partial class Form1 : Form
{
	private void InitializeComponent()
	{
		// Form1
		this.Controls.AddRange(new Control[]{

		});
		this.Name = "Form1";
		this.Text = "Form1";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}
}

partial class Form1
{
	private Container? components = null;

	public Form1()
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
		Application.Run(new Form1());
	}
}
