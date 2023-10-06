// Fig. 7.11: LinearSearcher.cs
// Demonstrando a pesquisa linear de um array.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class LinearSearcher : Form
{
	private Button searchButton;
	private TextBox inputTextBox;
	private Label outputLabel;

	int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26,
							28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 };

	private void InitializeComponent()
	{
		this.searchButton = new Button();
		this.inputTextBox = new TextBox();
		this.outputLabel = new Label();

		// searchButton.
		this.searchButton.Name = "searchButton";
		this.searchButton.Text = "Search";
		this.searchButton.Location = new Point(10, 10);
		this.searchButton.AutoSize = true;
		this.searchButton.Click += new EventHandler(searchButton_Click);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.Location = new Point(90, 11);

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.Location = new Point(10, 40);
		this.outputLabel.AutoSize = true;

		// LinearSearcher.
		this.Controls.AddRange(new Control[]{
			this.searchButton, this.inputTextBox,
			this.outputLabel
		});
		this.Name = "LinearSearcher";
		this.Text = "LinearSearcher";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void searchButton_Click(object? sender, EventArgs e)
	{
		int searchKey = Int32.Parse(inputTextBox.Text);
		int elementIndex = LinearSearch(a, searchKey);

		if (elementIndex != -1)
			outputLabel.Text =
				"Found value in element " + elementIndex;
		else
			outputLabel.Text = "Value not found";
	}

	public int LinearSearch(int[] array, int key)
	{
		for (int n = 0; n < array.Length; n++)
			if (array[n] == key)
				return n;

		return -1;
	}
}

partial class LinearSearcher
{
	private Container? components = null;

	public LinearSearcher()
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
		Application.Run(new LinearSearcher());
	}
}
