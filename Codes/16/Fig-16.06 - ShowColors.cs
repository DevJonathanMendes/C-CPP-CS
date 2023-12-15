// Fig. 16.6: ShowColors.cs
// Usando diferentes cores em C#.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ShowColors : Form
{
	// Cor do retângulo em segundo plano.
	private Color behindColor = Color.White;
	private GroupBox nameGroup;
	private GroupBox colorValueGroup;
	private TextBox colorNameTextBox;
	private TextBox alphaTextBox;
	private TextBox redTextBox;
	private TextBox greenTextBox;
	private TextBox blueTextBox;
	private Button colorValueButton;
	private Button colorNameButton;

	// Cor do retângulo em primeiro plano.
	private Color frontColor = Color.FromArgb(100, 0, 0, 255);

	private void InitializeComponent()
	{
		this.nameGroup = new GroupBox();
		this.colorNameTextBox = new TextBox();
		this.colorNameButton = new Button();

		this.colorValueGroup = new GroupBox();
		this.alphaTextBox = new TextBox();
		this.redTextBox = new TextBox();
		this.greenTextBox = new TextBox();
		this.blueTextBox = new TextBox();
		this.colorValueButton = new Button();

		// nameGroup.
		this.nameGroup.Name = "nameGroup";
		this.nameGroup.Text = "Set Back Color Name";
		this.nameGroup.Location = new Point(10, 200);
		this.nameGroup.AutoSize = true;
		this.nameGroup.Controls.AddRange(new Control[]{
			this.colorNameTextBox, this.colorNameButton
		});

		// colorNameTextBox.
		this.colorNameTextBox.Name = "colorNameTextBox";
		this.colorNameTextBox.Text = "";
		this.colorNameTextBox.Location = new Point(15, 20);

		// colorNameButton.
		this.colorNameButton.Name = "colorNameButton";
		this.colorNameButton.Text = "Set Color Name";
		this.colorNameButton.AutoSize = true;
		this.colorNameButton.Location = new Point(115, 19);
		this.colorNameButton.Click += new EventHandler(colorNameButton_Click);

		// colorValueGroup.
		this.colorValueGroup.Name = "colorValueGroup";
		this.colorValueGroup.Text = "Set Front Color Value Group";
		this.colorValueGroup.Location = new Point(10, 300);
		this.colorValueGroup.AutoSize = true;
		this.colorValueGroup.Controls.AddRange(new Control[]{
			this.alphaTextBox, this.redTextBox,
			this.greenTextBox, this.blueTextBox,
			this.colorValueButton
		});

		// alphaTextBox.
		this.alphaTextBox.Name = "alphaTextBox";
		this.alphaTextBox.Text = "";
		this.alphaTextBox.Size = new Size(30, 30);
		this.alphaTextBox.Location = new Point(15, 20);

		// redTextBox.
		this.redTextBox.Name = "redTextBox";
		this.redTextBox.Text = "";
		this.redTextBox.Size = new Size(30, 30);
		this.redTextBox.Location = new Point(55, 20);

		// greenTextBox.
		this.greenTextBox.Name = "greenTextBox";
		this.greenTextBox.Text = "";
		this.greenTextBox.Size = new Size(30, 30);
		this.greenTextBox.Location = new Point(95, 20);

		// blueTextBox.
		this.blueTextBox.Name = "blueTextBox";
		this.blueTextBox.Text = "";
		this.blueTextBox.Size = new Size(30, 30);
		this.blueTextBox.Location = new Point(135, 20);

		// colorValueButton.
		this.colorValueButton.Name = "colorValueButton";
		this.colorValueButton.Text = "Set Color Value";
		this.colorValueButton.AutoSize = true;
		this.colorValueButton.Location = new Point(175, 19);
		this.colorValueButton.Click += new EventHandler(colorValueButton_Click);

		// ShowColors.
		this.Controls.AddRange(new Control[]{
			this.nameGroup, this.colorValueGroup
		});
		this.Name = "ShowColors";
		this.Text = "ShowColors";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Sobrepõe o método Form OnPaint.
	protected override void OnPaint(PaintEventArgs e)
	{
		Graphics graphicsObject = e.Graphics; // Obtém os elementos gráficos.

		// Cria pincel de texto.
		SolidBrush textBrush = new SolidBrush(Color.Black);

		// Cria pincel sólido.
		SolidBrush brush = new SolidBrush(Color.White);

		// Desenha um fundo branco.
		graphicsObject.FillRectangle(brush, 4, 4, 275, 180);

		// Exibe o nome de behindColor.
		graphicsObject.DrawString(behindColor.Name, this.Font, textBrush, 40, 5);

		// Configura a cor do pincel e exibe o retângulo em segundo plano.
		brush.Color = behindColor;

		graphicsObject.FillRectangle(brush, 45, 20, 150, 120);

		// Exibe valores ARGB da cor em primeiro plano.
		graphicsObject.DrawString("Alpha: " + frontColor.A +
			" Red: " + frontColor.R + " Green: " + frontColor.G +
			" Blue: " + frontColor.B, this.Font, textBrush, 55, 165);

		// Configura a cor do pincel e exibe o retângulo em primeiro plano.
		brush.Color = frontColor;

		graphicsObject.FillRectangle(brush, 65, 35, 170, 130);
	}

	// Manipula o evento Click de colorValueButton.
	private void colorValueButton_Click(object? sender, EventArgs e)
	{
		frontColor = Color.FromArgb(Convert.ToInt32(
		alphaTextBox.Text),
		Convert.ToInt32(redTextBox.Text),
		Convert.ToInt32(greenTextBox.Text),
		Convert.ToInt32(blueTextBox.Text));

		Invalidate(); // Atualiza Form.
	}

	// Manipula o evento Click de colorNameButton.
	private void colorNameButton_Click(object? sender, EventArgs e)
	{
		// Configura behindColor com a cor especificada na caixa de texto
		behindColor = Color.FromName(colorNameTextBox.Text);

		Invalidate(); // Atualiza Form.
	}
}

partial class ShowColors
{
	private Container? components = null;

	public ShowColors()
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
		Application.Run(new ShowColors());
	}
}
