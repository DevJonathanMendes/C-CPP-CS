// Fig. 16.20: DrawPolygons.cs
// Demonstrando polígonos

using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;

partial class PolygonForm : Form
{
	private Button colorButton;
	private Button clearButton;
	private GroupBox typeGroup;
	private RadioButton filledPolygonOption;
	private RadioButton lineOption;
	private RadioButton polygonOption;
	private Panel drawPanel;

	// Contém a lista dos vértices do polígono.
	private ArrayList points = new ArrayList();

	// Inicializa a caneta e o pincel padrão.
	Pen pen = new Pen(Color.DarkBlue);

	SolidBrush brush = new SolidBrush(Color.DarkBlue);

	private void InitializeComponent()
	{
		this.drawPanel = new Panel();
		this.typeGroup = new GroupBox();
		this.lineOption = new RadioButton();
		this.polygonOption = new RadioButton();
		this.filledPolygonOption = new RadioButton();
		this.colorButton = new Button();
		this.clearButton = new Button();

		// drawPanel.
		this.drawPanel.Name = "drawPanel";
		this.drawPanel.Size = new Size(300, 300);
		this.drawPanel.BackColor = Color.White;
		this.drawPanel.Location = new Point(10, 10);
		this.drawPanel.MouseDown += new MouseEventHandler(drawPanel_MouseDown);
		this.drawPanel.Paint += new PaintEventHandler(drawPanel_Paint);

		// typeGroup.
		this.typeGroup.Name = "typeGroup";
		this.typeGroup.Text = "Select Type";
		this.typeGroup.AutoSize = true;
		this.typeGroup.Location = new Point(320, 10);
		this.typeGroup.Controls.AddRange(new Control[]{
			this.lineOption, this.polygonOption,
			this.filledPolygonOption
		});

		// lineOption.
		this.lineOption.Name = "lineOption";
		this.lineOption.Text = "Lines";
		this.lineOption.Location = new Point(10, 20);
		this.lineOption.CheckedChanged += new EventHandler(this.lineOption_CheckedChanged);

		// polygonOption.
		this.polygonOption.Name = "polygonOption";
		this.polygonOption.Text = "Polygon";
		this.polygonOption.Location = new Point(10, 50);
		this.polygonOption.CheckedChanged += new EventHandler(this.polygonOption_CheckedChanged);

		// filledPolygonOption.
		this.filledPolygonOption.Name = "filledPolygonOption";
		this.filledPolygonOption.Text = "Filled Polygon";
		this.filledPolygonOption.Location = new Point(10, 80);
		this.filledPolygonOption.CheckedChanged += new EventHandler(this.filledPolygonOption_CheckedChanged);

		// clearButton.
		this.clearButton.Name = "clearButton";
		this.clearButton.Text = "Clear";
		this.clearButton.AutoSize = true;
		this.clearButton.Location = new Point(320, 150);
		this.clearButton.Click += new EventHandler(clearButton_Click);

		// colorButton.
		this.colorButton.Name = "colorButton";
		this.colorButton.Text = "Change Color";
		this.colorButton.AutoSize = true;
		this.colorButton.Location = new Point(320, 180);
		this.colorButton.Click += new EventHandler(colorButton_Click);

		// PolygonForm.
		this.Controls.AddRange(new Control[]{
			this.drawPanel, this.typeGroup,
			this.clearButton, this.colorButton
		});
		this.Name = "PolygonForm";
		this.Text = "PolygonForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Manipulador de evento de mouse pressionado no painel de desenho.
	private void drawPanel_MouseDown(object? sender, MouseEventArgs e)
	{
		// Adiciona a posição do mouse na lista de vértices.
		points.Add(new Point(e.X, e.Y));
		drawPanel.Invalidate(); // Atualiza o painel.
	}

	private void drawPanel_Paint(object? sender, PaintEventArgs e)
	{
		Graphics graphicsObject = e.Graphics;

		// Se o arrayList tem 2 ou mais pontos, exibe a figura.
		if (points.Count > 1)
		{
			// Obtém o array para uso em funções de desenho.
			Point[] pointArray = (Point[])points.ToArray(points[0].GetType());

			if (polygonOption.Checked)
				// Desenha o polígono.
				graphicsObject.DrawPolygon(pen, pointArray);
			else if (lineOption.Checked)
				// Desenha linhas.
				graphicsObject.DrawLines(pen, pointArray);
			else if (filledPolygonOption.Checked)
				// Desenha preenchido.
				graphicsObject.FillPolygon(brush, pointArray);
		}
	}

	private void clearButton_Click(object? sender, EventArgs e)
	{
		points = new ArrayList(); // Remove pontos.
		drawPanel.Invalidate();
	}

	// Manipula o evento CheckedChanged do botão de seleção de polígono.
	private void polygonOption_CheckedChanged(object? sender, EventArgs e)
	{ drawPanel.Invalidate(); }

	// Manipula o evento CheckedChanged do botão de seleção de linha.
	private void lineOption_CheckedChanged(object? sender, EventArgs e)
	{ drawPanel.Invalidate(); }

	// Manipula o evento CheckedChanged do botão de seleção de polígono preenchido.
	private void filledPolygonOption_CheckedChanged(object? sender, EventArgs e)
	{ drawPanel.Invalidate(); }

	// Manipula o evento de clique em colorButton.
	private void colorButton_Click(object? sender, EventArgs e)
	{
		// Cria uma nova caixa de diálogo de cor.
		ColorDialog dialogColor = new ColorDialog();

		// Mostra a caixa de diálogo e obtém o resultado.
		DialogResult result = dialogColor.ShowDialog();

		// Retorna se o usuário cancelar.
		if (result == DialogResult.Cancel)
			return;

		pen.Color = dialogColor.Color;   // Configura a caneta com cor.
		brush.Color = dialogColor.Color; // Configura o pincel.
		drawPanel.Invalidate();
	}
}

partial class PolygonForm
{
	private Container? components = null;

	public PolygonForm()
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
		Application.Run(new PolygonForm());
	}
}
