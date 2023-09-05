// Fig. 00.00: .cs
// .

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class Form1 : Form
{
	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		// Form1
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(224, 262);
		this.Name = "Form1";
		this.Text = "Form1";
		this.ResumeLayout(false);
	}
	#endregion
}

partial class Form1
{
	private Container components = null;

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
