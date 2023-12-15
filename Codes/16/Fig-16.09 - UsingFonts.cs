// Fig. 16.9: UsingFonts.cs
// Demonstrando várias configurações de fonte.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class UsingFonts : Form
{
	private void InitializeComponent()
	{
		// UsingFonts.
		this.Name = "UsingFonts";
		this.Text = "UsingFonts";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Demonstra várias configurações de fonte e estilo.
	protected override void OnPaint(PaintEventArgs paintEvent)
	{
		Graphics graphicsObject = paintEvent.Graphics;
		SolidBrush brush = new SolidBrush(Color.DarkBlue);

		// Arial, 12pt negrito.
		FontStyle style = FontStyle.Bold;
		Font arial = new Font(new FontFamily("Arial"), 12, style);

		// Times New Roman, 12pt regular.
		style = FontStyle.Regular;
		Font timeNewRoman = new Font("Times New Roman", 12, style);

		// Courier New, 16pt negrito e itálico.
		style = FontStyle.Bold | FontStyle.Italic;
		Font courierNew = new Font("Courier New", 16, style);

		// Tahoma, 18pt taxado.
		style = FontStyle.Strikeout;
		Font tahoma = new Font("Tahoma", 18, style);

		graphicsObject.DrawString(arial.Name + " 12 point bold.", arial, brush, 10, 10);

		graphicsObject.DrawString(timeNewRoman.Name + " 12 point bold.", timeNewRoman, brush, 10, 30);

		graphicsObject.DrawString(courierNew.Name + " 16 point and italic.", courierNew, brush, 10, 54);

		graphicsObject.DrawString(tahoma.Name + " 18 point strikeout.", tahoma, brush, 10, 75);
	}
}

partial class UsingFonts
{
	private Container? components = null;

	public UsingFonts()
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
		Application.Run(new UsingFonts());
	}
}
