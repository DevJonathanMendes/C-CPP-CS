// Fig. 12.28: PictureBoxTest.cs
// Usando uma PictureBox para exibir imagens.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

partial class PictureBoxTest : Form
{
	private PictureBox imagePictureBox;
	private Label promptLabel;

	private int imageNum = -1;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.promptLabel = new Label();
		this.imagePictureBox = new PictureBox();

		// promptLabel.
		this.promptLabel.Name = "promptLabel";
		this.promptLabel.Text = "Click On PictureBox to View Images";
		this.promptLabel.AutoSize = true;
		this.promptLabel.Location = new Point(5, 5);

		// imagePictureBox.
		this.imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		this.imagePictureBox.Location = new Point(5, 35);
		this.imagePictureBox.Size = new Size(200, 200);
		this.imagePictureBox.BorderStyle = BorderStyle.Fixed3D;
		this.imagePictureBox.Click += new EventHandler(imagePictureBox_Click);

		// PictureBoxTest.
		this.AutoSize = true;
		this.Controls.AddRange(new Control[]{
			this.promptLabel,
			this.imagePictureBox,
		});
		this.Name = "PictureBoxTest";
		this.Text = "PictureBoxTest";
		this.ResumeLayout(false);
	}
	#endregion

	private void imagePictureBox_Click(object sender, EventArgs e)
	{
		imageNum = (imageNum + 1) % 2;

		imagePictureBox.Image =
			Image.FromFile(
				Directory.GetCurrentDirectory() +
				"\\images\\" + imageNum + ".png"
			);
	}
}

partial class PictureBoxTest
{
	private Container components = null;

	public PictureBoxTest()
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
		Application.Run(new PictureBoxTest());
	}
}
