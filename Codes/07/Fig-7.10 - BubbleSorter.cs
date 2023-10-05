// Fig. 7.10: BubbleSorter.cs
// Ordenando os valores de um array em ordem crescente.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class BubbleSorter : Form
{
	private Button sortButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.sortButton = new Button();
		this.outputLabel = new Label();

		// sortButton.
		this.sortButton.Name = "sortButton";
		this.sortButton.Text = "Sort";
		this.sortButton.AutoSize = true;
		this.sortButton.Location = new Point(10, 10);
		this.sortButton.Click += new EventHandler(sortButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// BubbleSorter.
		this.Controls.AddRange(new Control[]{
			this.sortButton, this.outputLabel
		});
		this.Name = "BubbleSorter";
		this.Text = "BubbleSorter";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void sortButton_Click(object? sender, EventArgs e)
	{
		int[] a = { 2, 6, 4, 8, 10, 12, 89, 68, 45, 37 };

		outputLabel.Text = "Data items in original order\n";

		for (int i = 0; i < a.Length; i++)
			outputLabel.Text += "   " + a[i];

		BubbleSort(a);

		outputLabel.Text += "\n\nData items in ascending order\n";

		for (int i = 0; i < a.Length; i++)
			outputLabel.Text += "   " + a[i];
	}

	public void BubbleSort(int[] b)
	{
		for (int pass = 1; pass < b.Length; pass++) // Passagem.
			for (int i = 0; i < b.Length - 1; i++) // Um passagem.
				if (b[i] > b[i + 1]) // Uma comparação.
					Swap(b, i); // Uma troca.
	}

	public void Swap(int[] c, int first)
	{
		int hold; // Armazenamento temporário.

		hold = c[first];
		c[first] = c[first + 1];
		c[first + 1] = hold;
	}
}

partial class BubbleSorter
{
	private Container? components = null;

	public BubbleSorter()
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
		Application.Run(new BubbleSorter());
	}
}
