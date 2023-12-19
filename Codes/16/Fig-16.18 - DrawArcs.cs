// Fig. 16.18: DrawArcs.cs
// Desenhando vários arcos em um formulário.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class DrawArcs : Form
{
	private void InitializeComponent()
	{
		this.Paint += new PaintEventHandler(this.DrawArcs_Paint);

		// DrawArcs.
		this.Name = "DrawArcs";
		this.Text = "DrawArcs";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void DrawArcs_Paint(object? sender, PaintEventArgs e)
	{
		// Obtém o objeto gráfico
		Graphics graphicsObject = e.Graphics;
		Rectangle rectangle1 = new Rectangle(15, 35, 80, 80);

		SolidBrush brush1 = new SolidBrush(Color.Firebrick);
		SolidBrush brush2 = new SolidBrush(Color.DarkBlue);
		Pen pen1 = new Pen(brush1, 1);
		Pen pen2 = new Pen(brush2, 1);

		// Começa em 0 e varre 360 graus
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.DrawArc(pen2, rectangle1, 0, 360);

		// Começa em 0 e varre 110 graus
		rectangle1.Location = new Point(100, 35);
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.DrawArc(pen2, rectangle1, 0, 110);

		// Começa em 0 e varre -270 graus
		rectangle1.Location = new Point(185, 35);
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.DrawArc(pen2, rectangle1, 0, -270);

		// Começa em 0 e varre 360 graus
		rectangle1.Location = new Point(15, 120);
		rectangle1.Size = new Size(80, 40);
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.FillPie(brush2, rectangle1, 0, 360);

		// Começa em 270 e varre -90 graus
		rectangle1.Location = new Point(100, 120);
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.FillPie(brush2, rectangle1, 270, -90);

		// Começa em 0 e varre -270 graus
		rectangle1.Location = new Point(185, 120);
		graphicsObject.DrawRectangle(pen1, rectangle1);
		graphicsObject.FillPie(brush2, rectangle1, 0, -270);
	}
}

partial class DrawArcs
{
	private Container? components = null;

	public DrawArcs()
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
		Application.Run(new DrawArcs());
	}
}
