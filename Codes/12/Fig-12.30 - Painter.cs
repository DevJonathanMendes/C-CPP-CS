// Fig. 12.30: Painter.cs
// Usando uma PictureBox para exibir imagens.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class Painter : Form
{
	bool shouldPaint = false;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		// Painter
		this.MouseDown += new MouseEventHandler(Painter_MouseDown);
		this.MouseUp += new MouseEventHandler(Painter_MouseUp);
		this.MouseMove += new MouseEventHandler(Painter_MouseMove);
		this.Name = "Painter";
		this.Text = "Painter";
		this.ResumeLayout(false);
	}
	#endregion

	private void Painter_MouseDown(object sender, MouseEventArgs e)
	{ shouldPaint = true; }

	private void Painter_MouseUp(object sender, MouseEventArgs e)
	{ shouldPaint = false; }

	protected void Painter_MouseMove(object sender, MouseEventArgs e)
	{
		if (shouldPaint)
		{
			Graphics graphics = CreateGraphics();

			graphics.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
		}
	}
}

partial class Painter
{
	private Container components = null;

	public Painter()
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
		Application.Run(new Painter());
	}
}
