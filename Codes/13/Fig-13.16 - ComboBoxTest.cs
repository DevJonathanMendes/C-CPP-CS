// Fig. 13.16: ComboBoxTest.cs
// Usando ComboBox para selecionar a figura a ser desenhada.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ComboBoxTest : Form
{
	private ComboBox imageComboBox;

	private void InitializeComponent()
	{
		this.imageComboBox = new ComboBox();

		// imageComboBox.
		this.imageComboBox.Name = "imageComboBox";
		this.imageComboBox.Text = "";
		this.imageComboBox.Items.AddRange(new object[]{
			"Circle", "Square", "Ellipse", "Pie",
			"Filled Circle", "Filled Square",
			"Filled Ellipse", "Filled Pie"
		});
		this.imageComboBox.Size = new Size(150, 150);
		this.imageComboBox.Location = new Point(10, 10);
		this.imageComboBox.SelectedIndexChanged += new EventHandler(imageComboBox_SelectedIndexChanged);

		// ComboBoxTest.
		this.Controls.AddRange(new Control[]{
			this.imageComboBox
		});
		this.Name = "ComboBoxTest";
		this.Text = "ComboBoxTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void imageComboBox_SelectedIndexChanged(object? sender, EventArgs e)
	{
		Graphics myGraphics = base.CreateGraphics();

		Pen myPen = new Pen(Color.DarkRed);

		SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed);

		myGraphics.Clear(Color.White);

		switch (imageComboBox.SelectedIndex)
		{
			case 0: myGraphics.DrawEllipse(myPen, 50, 50, 150, 150); break;
			case 1: myGraphics.DrawRectangle(myPen, 50, 50, 150, 150); break;
			case 2: myGraphics.DrawEllipse(myPen, 50, 85, 150, 115); break;
			case 3: myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45); break;
			case 4: myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150); break;
			case 5: myGraphics.FillRectangle(mySolidBrush, 50, 50, 150, 150); break;
			case 6: myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115); break;
			case 7: myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45); break;
		}
	}
}

partial class ComboBoxTest
{
	private Container? components = null;

	public ComboBoxTest()
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
		Application.Run(new ComboBoxTest());
	}
}
