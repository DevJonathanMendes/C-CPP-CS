// Fig. 7.12: BinarySearchTest.cs
// Demonstrando uma pesquisa binária de um array.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class BinarySearchTest : Form
{
	private Label promptLabel;

	private TextBox inputTextBox;

	private Label resultLabel;
	private Label displayLabel;
	private Label outputLabel;

	private Button findButton;

	int[] a = { 0, 2, 4, 6, 8, 10, 12, 14,
						 16, 18, 20, 22, 24, 26, 28 };

	private void InitializeComponent()
	{
		this.promptLabel = new Label();

		this.inputTextBox = new TextBox();

		this.resultLabel = new Label();
		this.displayLabel = new Label();
		this.outputLabel = new Label();

		this.findButton = new Button();

		// promptLabel.
		this.promptLabel.Name = "promptLabel";
		this.promptLabel.Text = "Enter key";
		this.promptLabel.Location = new Point(10, 14);
		this.promptLabel.AutoSize = true;

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.Location = new Point(70, 11);

		// resultLabel.
		this.resultLabel.Name = "resultLabel";
		this.resultLabel.Text = "Result: ";
		this.resultLabel.Location = new Point(170, 14);
		this.resultLabel.AutoSize = true;

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "";
		this.displayLabel.Location = new Point(212, 14);
		this.displayLabel.AutoSize = true;

		// findButton.
		this.findButton.Name = "findButton";
		this.findButton.Text = "Find key";
		this.findButton.Location = new Point(10, 40);
		this.findButton.AutoSize = true;
		this.findButton.Click += new EventHandler(findButton_Click);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.Location = new Point(10, 80);
		this.outputLabel.AutoSize = true;

		// BinarySearchTest.
		this.Controls.AddRange(new Control[]{
		this.promptLabel, this.findButton, this.inputTextBox,
		this.outputLabel, this.resultLabel, this.displayLabel
});
		this.Name = "BinarySearchTest";
		this.Text = "BinarySearchTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void findButton_Click(object? sender, EventArgs e)
	{
		int searchKey = Int32.Parse(inputTextBox.Text);

		outputLabel.Text = "Portions of array searched\n";

		int element = BinarySearch(a, searchKey);

		if (element != -1)
			displayLabel.Text =
				"Found value in element " + element;
		else
			displayLabel.Text = "Value not found";
	}

	public int BinarySearch(int[] array, int key)
	{
		int low = 0;                  // Índice baixo.
		int high = array.Length - 1;  // Índice alto.
		int middle;                   // Índice do meio.

		while (low <= high)
		{
			middle = (low + high) / 2;

			BuildOutput(a, low, middle, high);

			if (key == array[middle])
				return middle;
			else if (key < array[middle])
				high = middle - 1; // Pesquisa a extremidade inferior do array.
			else
				low = middle + 1;
		}

		return -1;
	}

	public void BuildOutput(int[] array, int low, int mid, int high)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (i < low || i > high)
				outputLabel.Text += "    ";
			else if (i == mid)
				outputLabel.Text +=
					array[i].ToString("00") + "* ";
			else
				outputLabel.Text +=
					array[i].ToString("00") + "  ";
		}

		outputLabel.Text += "\n";
	}
}

partial class BinarySearchTest
{
	private Container? components = null;

	public BinarySearchTest()
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
		Application.Run(new BinarySearchTest());
	}
}
