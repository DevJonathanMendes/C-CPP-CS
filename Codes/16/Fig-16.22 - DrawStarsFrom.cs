// Fig. 16.22: DrawStarsFrom.cs
// Usando caminhos para desenhar estrelas no formulário.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

partial class DrawStarsFrom : Form
{
	private void InitializeComponent()
	{
		this.Paint += new PaintEventHandler(DrawStarsFrom_Paint);

		// DrawStarsFrom.
		this.Name = "DrawStarsFrom";
		this.Text = "DrawStarsFrom";
	}

	// Cria caminho e desenha estrelas ao longo dele.
	private void DrawStarsFrom_Paint(object? sender, PaintEventArgs e)
	{
		Graphics graphicsObject = e.Graphics;

		Random random = new Random();

		SolidBrush brush = new SolidBrush(Color.DarkMagenta);


		// Pontos x e y do caminho.
		int[] xPoint = { 55, 67, 109, 73, 83, 55, 27, 37, 1, 43 };
		int[] yPoint = { 0, 36, 36, 54, 96, 72, 96, 54, 36, 36 };

		// Cria caminho de elemento gráfico para estrela.
		GraphicsPath start = new GraphicsPath();

		// Translada a origem para (150, 150).
		graphicsObject.TranslateTransform(150, 150);

		// Cria a estrela a partir de uma série de pontos.
		for (int i = 0; i <= 8; i += 2)
			start.AddLine(xPoint[i], yPoint[i],
				xPoint[i + 1], yPoint[i + 1]);

		// Fecha a figura.
		start.CloseFigure();

		// Gira a origem e desenha estrelas com cores aleatórias.
		for (int i = 1; i <= 18; i++)
		{
			graphicsObject.RotateTransform(20);

			brush.Color = Color.FromArgb(
				random.Next(200, 255), random.Next(255),
				random.Next(255), random.Next(255));

			graphicsObject.FillPath(brush, start);
		}
	}
}

partial class DrawStarsFrom
{
	private Container? components = null;

	public DrawStarsFrom()
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
		Application.Run(new DrawStarsFrom());
	}
}
