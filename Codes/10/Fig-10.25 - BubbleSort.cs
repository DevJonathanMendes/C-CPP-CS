// Fig. 10.25: BubbleSort.cs
// Demonstra a ordenação "bolha" usando delegados para determinar a ordem de ordenação.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe DelegateBubbleSort (Fig-10.24 - DelegateBubbleSort.cs) aqui.

partial class BubbleSortForm : Form
{
	private RichTextBox originalRichTextBox;
	private RichTextBox sortedRichTextBox;
	private Button createButton;
	private Button ascendingButton;
	private Button descendingButton;
	private Label originalLabel;
	private Label sortedLabel;

	private int[] elementArray = new int[10];

	private void InitializeComponent()
	{
		this.originalLabel = new Label();
		this.sortedLabel = new Label();
		this.originalRichTextBox = new RichTextBox();
		this.sortedRichTextBox = new RichTextBox();
		this.createButton = new Button();
		this.ascendingButton = new Button();
		this.descendingButton = new Button();

		// originalLabel.
		this.originalLabel.Name = "originalLabel";
		this.originalLabel.Text = "Original Order";
		this.originalLabel.AutoSize = true;
		this.originalLabel.Location = new Point(10, 10);

		// sortedLabel.
		this.sortedLabel.Name = "sortedLabel";
		this.sortedLabel.Text = "Sorted Label";
		this.sortedLabel.AutoSize = true;
		this.sortedLabel.Location = new Point(140, 10);

		// originalRichTextBox.
		this.originalRichTextBox.Name = "originalRichTextBox";
		this.originalRichTextBox.Text = "";
		this.originalRichTextBox.Location = new Point(10, 40);
		this.originalRichTextBox.Size = new Size(60, 160);

		// sortedRichTextBox.
		this.sortedRichTextBox.Name = "sortedRichTextBox";
		this.sortedRichTextBox.Text = "";
		this.sortedRichTextBox.Location = new Point(140, 40);
		this.sortedRichTextBox.Size = new Size(60, 160);

		// ascendingButton.
		this.ascendingButton.Name = "ascendingButton";
		this.ascendingButton.Text = "Sort Ascending";
		this.ascendingButton.AutoSize = true;
		this.ascendingButton.Location = new Point(140, 200);
		this.ascendingButton.Click += new EventHandler(ascendingButton_Click);

		// descendingButton.
		this.descendingButton.Name = "descendingButton";
		this.descendingButton.Text = "Sort Descending";
		this.descendingButton.AutoSize = true;
		this.descendingButton.Location = new Point(140, 230);
		this.descendingButton.Click += new EventHandler(descendingButton_Click);

		// createButton.
		this.createButton.Name = "createButton";
		this.createButton.Text = "Create Data";
		this.createButton.AutoSize = true;
		this.createButton.Location = new Point(10, 200);
		this.createButton.Click += new EventHandler(createButton_Click);

		// BubbleSortForm.
		this.Controls.AddRange(new Control[]{
			this.sortedLabel, this.originalLabel,
			this.originalRichTextBox, this.sortedRichTextBox,
			this.ascendingButton, this.descendingButton,
			this.createButton
		});
		this.Name = "BubbleSortForm";
		this.Text = "BubbleSortForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void createButton_Click(object? sender, EventArgs e)
	{
		originalRichTextBox.Clear();
		sortedRichTextBox.Clear();

		Random randomNumber = new Random();

		for (int i = 0; i < elementArray.Length; i++)
		{
			elementArray[i] = randomNumber.Next(100);
			originalRichTextBox.Text += elementArray[i] + "\r\n";
		}
	}

	private bool SortAscending(int element1, int element2)
	{ return element1 > element2; }

	private void ascendingButton_Click(object? sender, EventArgs e)
	{
		DelegateBubbleSort.SortArray(elementArray, new DelegateBubbleSort.Comparator(SortAscending));
		DisplayResults();
	}

	private bool SortDescending(int element1, int element2)
	{ return element1 < element2; }

	private void descendingButton_Click(object? sender, EventArgs e)
	{
		DelegateBubbleSort.SortArray(elementArray, new DelegateBubbleSort.Comparator(SortDescending));
		DisplayResults();
	}

	private void DisplayResults()
	{
		sortedRichTextBox.Clear();

		foreach (int element in elementArray)
		{
			sortedRichTextBox.Text += element + "\r\n";
		}
	}
}

partial class BubbleSortForm
{
	private Container? components = null;

	public BubbleSortForm()
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
		Application.Run(new BubbleSortForm());
	}
}
