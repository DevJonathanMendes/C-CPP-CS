// Fig. 7.14: TwoDimensionalArrays.cs
// Inicializando arrays bidimensionais.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class TwoDimensionalArrays : Form
{
	private Button showOutputButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.showOutputButton = new Button();
		this.outputLabel = new Label();

		// showOutputButton.
		this.showOutputButton.Name = "showOutputButton";
		this.showOutputButton.Text = "Show Output";
		this.showOutputButton.AutoSize = true;
		this.showOutputButton.Location = new Point(10, 10);
		this.showOutputButton.Click += new EventHandler(showOutputButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// TwoDimensionalArrays.
		this.Controls.AddRange(new Control[]{
			this.showOutputButton, this.outputLabel
		});
		this.Name = "TwoDimensionalArrays";
		this.Text = "TwoDimensionalArrays";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		// Declaração e inicialização de array retangular.
		int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

		// Declaração e inicialização de array irregular.
		int[][] array2 = new int[3][];
		array2[0] = new int[] { 1, 2 };
		array2[1] = new int[] { 3 };
		array2[2] = new int[] { 4, 5, 6 };

		outputLabel.Text = "Values in array1 by row are\n";

		for (int i = 0; i < array1.GetLength(0); i++)
		{
			for (int j = 0; j < array1.GetLength(1); j++)
				outputLabel.Text += array1[i, j] + "  ";

			outputLabel.Text += "\n";
		}

		outputLabel.Text += "\nValues in array2 by row are \n";

		for (int i = 0; i < array2.Length; i++)
		{
			for (int j = 0; j < array2[i].Length; j++)
				outputLabel.Text += array2[i][j] + "  ";

			outputLabel.Text += "\n";
		}
	}
}

partial class TwoDimensionalArrays
{
	private Container? components = null;

	public TwoDimensionalArrays()
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
		Application.Run(new TwoDimensionalArrays());
	}
}
