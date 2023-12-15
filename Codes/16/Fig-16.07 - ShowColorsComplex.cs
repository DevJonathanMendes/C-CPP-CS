// Fig. 16.7: ShowColorsComplex.cs
// Muda as cores de fundo e de texto de um formulário.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ShowColorsComplex : Form
{
	private Button backgroundColorButton;
	private Button textColorButton;

	private void InitializeComponent()
	{
		this.backgroundColorButton = new Button();
		this.textColorButton = new Button();

		// backgroundColorButton.
		this.backgroundColorButton.Name = "backgroundColorButton";
		this.backgroundColorButton.Text = "Change Background Color";
		this.backgroundColorButton.AutoSize = true;
		this.backgroundColorButton.Location = new Point(10, 10);
		this.backgroundColorButton.Click += new EventHandler(backgroundColorButton_Click);

		// textColorButton.
		this.textColorButton.Name = "textColorButton";
		this.textColorButton.Text = "Change Text Color";
		this.textColorButton.AutoSize = true;
		this.textColorButton.Location = new Point(10, 40);
		this.textColorButton.Click += new EventHandler(textColorButton_Click);

		// ShowColorsComplex.
		this.Controls.AddRange(new Control[]{
			this.backgroundColorButton, this.textColorButton
		});
		this.Name = "ShowColorsComplex";
		this.Text = "ShowColorsComplex";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Muda cor do texto.
	private void textColorButton_Click(object? sender, EventArgs e)
	{
		ColorDialog colorChooser = new ColorDialog();
		DialogResult result;

		// Obtém a cor escolhida.
		result = colorChooser.ShowDialog();

		if (result == DialogResult.Cancel)
			return;

		// Atribui a cor de primeiro plano no resultado da caixa de diálogo.
		backgroundColorButton.ForeColor = colorChooser.Color;
		textColorButton.ForeColor = colorChooser.Color;
	}

	// Muda cor de fundo.
	private void backgroundColorButton_Click(object? sender, EventArgs e)
	{
		ColorDialog colorChooser = new ColorDialog();
		DialogResult result;

		// Mostra ColorDialog e obtém o resultado.
		colorChooser.FullOpen = true;
		result = colorChooser.ShowDialog();

		if (result == DialogResult.Cancel)
			return;

		// Configura a cor de fundo.
		this.BackColor = colorChooser.Color;
	}
}

partial class ShowColorsComplex
{
	private Container? components = null;

	public ShowColorsComplex()
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
		Application.Run(new ShowColorsComplex());
	}
}
