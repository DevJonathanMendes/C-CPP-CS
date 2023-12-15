// Fig. 16.12: UsingFontMetrics.cs
// Exibindo informações sobre métricas de fontes.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class UsingFontMetrics : Form
{
	private void InitializeComponent()
	{
		// UsingFontMetrics.
		this.Name = "UsingFontMetrics";
		this.Text = "UsingFontMetrics";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Exibe informações sobre a fonte.
	protected override void OnPaint(PaintEventArgs paintEvent)
	{
		Graphics graphicsObject = paintEvent.Graphics;
		SolidBrush brush = new SolidBrush(Color.DarkBlue);

		// Métrica da fonte Arial.
		Font arial = new Font("Arial", 12);
		FontFamily family = arial.FontFamily;
		Font sanSerif = new Font("Microsoft Sans Serif", 14, FontStyle.Italic);

		// Exibe métricas da fonte Arial.
		graphicsObject.DrawString("Current Font " + arial.ToString(), arial, brush, 10, 10);
		graphicsObject.DrawString("Ascent: " + family.GetCellAscent(FontStyle.Regular), arial, brush, 10, 30);
		graphicsObject.DrawString("Descent: " + family.GetCellDescent(FontStyle.Regular), arial, brush, 10, 50);
		graphicsObject.DrawString("Height: " + family.GetEmHeight(FontStyle.Regular), arial, brush, 10, 70);
		graphicsObject.DrawString("Leading: " + family.GetLineSpacing(FontStyle.Regular), arial, brush, 10, 90);

		// Exibe as métricas da font Sans Serif.
		family = sanSerif.FontFamily;
		graphicsObject.DrawString("Current Font " + sanSerif.ToString(), sanSerif, brush, 10, 130);
		graphicsObject.DrawString("Ascent: " + family.GetCellAscent(FontStyle.Regular), sanSerif, brush, 10, 150);
		graphicsObject.DrawString("Descent: " + family.GetCellDescent(FontStyle.Regular), sanSerif, brush, 10, 170);
		graphicsObject.DrawString("Height: " + family.GetEmHeight(FontStyle.Regular), sanSerif, brush, 10, 190);
		graphicsObject.DrawString("Leading: " + family.GetLineSpacing(FontStyle.Regular), sanSerif, brush, 10, 210);
	}
}

partial class UsingFontMetrics
{
	private Container? components = null;

	public UsingFontMetrics()
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
		Application.Run(new UsingFontMetrics());
	}
}
