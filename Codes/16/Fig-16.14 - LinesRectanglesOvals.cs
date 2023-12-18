// Fig. 16.14: LinesRectanglesOvals.cs
// Demonstrando linhas, retângulos e elipse.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class LinesRectanglesOvals : Form
{
	private void InitializeComponent()
	{
		// LinesRectanglesOvals.
		this.Name = "LinesRectanglesOvals";
		this.Text = "LinesRectanglesOvals";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	protected override void OnPaint(PaintEventArgs paintEvent)
	{
		Graphics g = paintEvent.Graphics;

		SolidBrush brush = new SolidBrush(Color.Blue);
		Pen pen = new Pen(Color.AliceBlue);

		// Cria retângulo preenchido.
		g.FillRectangle(brush, 90, 30, 150, 90);

		// Desenha linhas para conectar retângulos.
		g.DrawLine(pen, 90, 30, 110, 40);
		g.DrawLine(pen, 90, 120, 110, 130);
		g.DrawLine(pen, 240, 30, 260, 40);
		g.DrawLine(pen, 240, 120, 260, 130);

		// Desenha retângulo superior.
		g.DrawRectangle(pen, 110, 40, 150, 90);

		// Configura o pincel como vermelho.
		brush.Color = Color.Red;

		// Desenha a elipse de base.
		g.FillEllipse(brush, 280, 75, 100, 50);

		// Desenha linhas de conexão.
		g.DrawLine(pen, 380, 55, 380, 100);
		g.DrawLine(pen, 280, 55, 280, 100);

		// Desenha o contorno da elipse.
		g.DrawEllipse(pen, 280, 30, 100, 50);
	}
}

partial class LinesRectanglesOvals
{
	private Container? components = null;

	public LinesRectanglesOvals()
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
		Application.Run(new LinesRectanglesOvals());
	}
}
