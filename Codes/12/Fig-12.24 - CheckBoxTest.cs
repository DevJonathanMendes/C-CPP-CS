// Fig. 12.24: CheckBoxTest.cs
// Usando CheckBoxes para alternar entre os estilos itálicos e negrito.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class CheckBoxTest : Form
{
	private CheckBox boldCheckBox;
	private CheckBox italicCheckBox;

	private Label outputLabel;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.boldCheckBox = new CheckBox();
		this.italicCheckBox = new CheckBox();
		this.outputLabel = new Label();

		// outputLabel.
		this.outputLabel.Text = "Watch the font style change";
		this.outputLabel.Location = new Point(10, 20);
		this.outputLabel.AutoSize = true;

		// boldCheckBox.
		this.boldCheckBox.Text = "Bold";
		this.boldCheckBox.AutoSize = true;
		this.boldCheckBox.Location = new Point(10, 40);
		this.boldCheckBox.Click += new EventHandler(this.boldCheckBox_CheckedChanged);

		// italicCheckBox.
		this.italicCheckBox.Text = "Italic";
		this.italicCheckBox.AutoSize = true;
		this.italicCheckBox.Location = new Point(70, 40);
		this.italicCheckBox.Click += new EventHandler(this.italicCheckBox_CheckedChanged);

		// CheckBoxTest.
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(250, 150);
		this.Controls.AddRange(new Control[]{
			this.boldCheckBox,
			this.italicCheckBox,
			this.outputLabel});
		this.Name = "CheckBoxTest";
		this.Text = "CheckBoxTest";
		this.ResumeLayout(false);
	}
	#endregion

	private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		outputLabel.Font = new Font(
			outputLabel.Font.Name,
			outputLabel.Font.Size,
			outputLabel.Font.Style ^ FontStyle.Bold
		);
	}

	private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		outputLabel.Font = new Font(
			outputLabel.Font.Name,
			outputLabel.Font.Size,
			outputLabel.Font.Style ^ FontStyle.Italic
		);
	}
}

partial class CheckBoxTest
{
	private Container components = null;

	public CheckBoxTest()
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
		Application.Run(new CheckBoxTest());
	}
}
