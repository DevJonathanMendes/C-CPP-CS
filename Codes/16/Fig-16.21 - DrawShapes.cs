// Fig. 16.21: DrawShapes.cs
// Desenhando várias figuras em um formulário.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

partial class DrawShapesForm : Form
{
	private void InitializeComponent()
	{
		this.Paint += new PaintEventHandler(this.DrawShapesForm_Paint);

		// DrawShapesForm.
		this.Name = "DrawShapesForm";
		this.Text = "DrawShapesForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void DrawShapesForm_Paint(object? sender, PaintEventArgs e)
	{
		Graphics graphicsObject = e.Graphics;

		// Elipse retângulo e pincel de gradientes.
		Rectangle drawArea1 = new Rectangle(5, 35, 30, 100);
		LinearGradientBrush linearBrush = new LinearGradientBrush(
			drawArea1, Color.Blue, Color.Yellow, LinearGradientMode.ForwardDiagonal);

		// Caneta e localização do retângulo de contorno vermelho.
		Pen thickRedPen = new Pen(Color.Red, 10);
		Rectangle drawArea2 = new Rectangle(80, 30, 65, 100);

		// Textura de bitmap.
		Bitmap textureBitmap = new Bitmap(10, 10);

		// Obtém elementos gráficos de bitmap.
		Graphics graphicsObject2 = Graphics.FromImage(textureBitmap);

		// Pincel e caneta usados por todo o programa.
		SolidBrush solidColorBrush = new SolidBrush(Color.Red);
		Pen coloredPen = new Pen(solidColorBrush);

		// Desenha elipse preenchida com um gradiente azul e amarelo.
		graphicsObject.FillEllipse(linearBrush, 5, 30, 65, 100);

		// Desenha contorno de retângulo grosso em vermelho.
		graphicsObject.DrawRectangle(thickRedPen, drawArea2);

		// Preenche textureBitmap com amarelo.
		solidColorBrush.Color = Color.Yellow;
		graphicsObject.FillEllipse(solidColorBrush, 0, 0, 10, 10);

		// Desenha pequeno retângulo preto em textureBitmap.
		coloredPen.Color = Color.Black;
		graphicsObject2.DrawRectangle(coloredPen, 1, 1, 6, 6);

		// Desenha pequeno retângulo azul em textureBitmap.
		solidColorBrush.Color = Color.Blue;
		graphicsObject2.FillRectangle(solidColorBrush, 1, 1, 3, 3);

		// Desenha pequeno quadrado vermelho em textureBitmap.
		solidColorBrush.Color = Color.Red;
		graphicsObject2.FillRectangle(solidColorBrush, 4, 4, 3, 3);

		// Cria pincel texturizado e exibe retângulo texturizado.
		TextureBrush texturedBrush = new TextureBrush(textureBitmap);
		graphicsObject.FillRectangle(texturedBrush, 155, 30, 75, 100);

		// Desenha arco branco em forma de torta.
		coloredPen.Color = Color.White;
		coloredPen.Width = 6;
		graphicsObject.DrawPie(coloredPen, 240, 30, 75, 100, 0, 270);

		// Desenha linhas verdes e amarelas.
		coloredPen.Color = Color.Green;
		coloredPen.Width = 5;
		graphicsObject.DrawLine(coloredPen, 395, 30, 320, 150);

		// Desenha uma linha pontilhada amarela grossa, com a ponta de cada traço arredondado.
		coloredPen.Color = Color.Yellow;
		coloredPen.DashCap = DashCap.Round;
		coloredPen.DashStyle = DashStyle.Dash;
		graphicsObject.DrawLine(coloredPen, 320, 30, 395, 150);
	}
}

partial class DrawShapesForm
{
	private Container? components = null;

	public DrawShapesForm()
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
		Application.Run(new DrawShapesForm());
	}
}
