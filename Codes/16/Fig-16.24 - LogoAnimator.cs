// Fig. 16.24: LogoAnimator.cs
// Programa que anima uma série de imagens.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

partial class LogoAnimator : Form
{
	private PictureBox logoPictureBox;
	private Timer Timer;

	private ArrayList images = new ArrayList();
	private int count = -1;

	private void InitializeComponent()
	{
		this.logoPictureBox = new PictureBox();

		// logoPictureBox.
		this.logoPictureBox.Name = "logoPictureBox";
		this.logoPictureBox.Location = new Point(10, 10);

		// LogoAnimator.
		this.Controls.Add(this.logoPictureBox);
		this.Timer.Tick += new EventHandler(Timer_Tick);
		this.Name = "LogoAnimator";
		this.Text = "LogoAnimator";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void Timer_Tick(object? sender, EventArgs e)
	{
		count = (count + 1) % 30;
		logoPictureBox.Image = (Image)images[count];
	}
}

partial class LogoAnimator
{
	private Container? components = null;

	public LogoAnimator()
	{
		InitializeComponent();

		for (int i = 0; i < 30; i++)
			images.Add(Image.FromFile("logo" + i + ".png"));

		// Carrega a primeira imagem.
		logoPictureBox.Image = (Image)images[0];

		// Configura PictureBox com o mesmo tamanho de Image.
		logoPictureBox.Size = logoPictureBox.Image.Size;
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
		Application.Run(new LogoAnimator());
	}
}
