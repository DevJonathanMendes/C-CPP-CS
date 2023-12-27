// Fig. 16.23: DisplayLogoForm.cs
// Exibindo e redimensionando uma imagem.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class DisplayLogoForm : Form
{
	private Button setButton;
	private TextBox heightTextBox;
	private Label heightLabel;
	private TextBox widthTextBox;
	private Label widthLabel;

	private Image image = Image.FromFile("logo.png");
	private Graphics graphicsObject;

	private void InitializeComponent()
	{
		this.widthLabel = new Label();
		this.widthTextBox = new TextBox();
		this.heightLabel = new Label();
		this.heightTextBox = new TextBox();
		this.setButton = new Button();

		// widthLabel.
		this.widthLabel.Name = "widthLabel";
		this.widthLabel.Text = "Width";
		this.widthLabel.AutoSize = true;
		this.widthLabel.Location = new Point(10, 10);

		// widthTextBox.
		this.widthTextBox.Name = "widthTextBox";
		this.widthTextBox.Text = "";
		this.widthTextBox.Location = new Point(10, 30);

		// heightLabel.
		this.heightLabel.Name = "heightLabel";
		this.heightLabel.Text = "Width";
		this.heightLabel.AutoSize = true;
		this.heightLabel.Location = new Point(10, 60);

		// heightTextBox.
		this.heightTextBox.Name = "heightTextBox";
		this.heightTextBox.Text = "";
		this.heightTextBox.Location = new Point(10, 90);

		// setButton.
		this.setButton.Name = "setButton";
		this.setButton.Text = "Set";
		this.setButton.AutoSize = true;
		this.setButton.Location = new Point(10, 120);
		this.setButton.Click += new EventHandler(setButton_Click);

		// DisplayLogoForm.
		this.Controls.AddRange(new Control[]{
			this.widthLabel,this.widthTextBox,
			this.heightLabel,this.heightTextBox,
			this.setButton
		});
		this.Name = "DisplayLogoForm";
		this.Text = "DisplayLogoForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void setButton_Click(object? sender, EventArgs e)
	{
		// Obtém entrada do usuário.
		int width = Convert.ToInt32(widthTextBox.Text);
		int height = Convert.ToInt32(heightTextBox.Text);

		// Apresenta o problema
		if (width > 375 || height > 225)
		{
			MessageBox.Show("Height or Width too large");
			return;
		}

		// Limpa Windows Form.
		graphicsObject.Clear(this.BackColor);

		// Desenha a imagem.
		graphicsObject.DrawImage(image, 150, 10, width, height);
	}
}

partial class DisplayLogoForm
{
	private Container? components = null;

	public DisplayLogoForm()
	{
		InitializeComponent();
		graphicsObject = this.CreateGraphics();
	}

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
		Application.Run(new DisplayLogoForm());
	}
}
