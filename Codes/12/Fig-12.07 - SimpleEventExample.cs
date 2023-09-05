// Fig. 12.7: SimpleEventExample.cs
// Usando o Visual Studio .NET para criar manipuladores de evento.

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

public partial class MyForm : Form
{
	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.Click += new EventHandler(this.MyForm_Click);

		this.components = new Container();
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 450);
		this.Text = "SimpleEventHandler";
	}
	#endregion

	private void MyForm_Click(object? sender, EventArgs e)
	{
		MessageBox.Show("Form was pressed");
	}
}

partial class MyForm
{
	private IContainer? components = null;

	public MyForm()
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
		Application.Run(new MyForm());
	}
}
