// Fig. 7.9: ArrayReferenceTest.cs
// Testando os efeitos da passagem de referência de array por valor e por referência.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ArrayReferenceTest : Form
{
	private Label outputLabel;
	private Button showOutputButton;

	private void InitializeComponent()
	{
		this.outputLabel = new Label();
		this.showOutputButton = new Button();

		// outputLabel.
		this.outputLabel.Name = "outputLabel";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 40);

		// showOutputButton.
		this.showOutputButton.Name = "showOutputButton";
		this.showOutputButton.Text = "Show Output";
		this.showOutputButton.AutoSize = true;
		this.showOutputButton.Location = new Point(10, 10);
		this.showOutputButton.Click += new EventHandler(showOutputButton_Click);

		// ArrayReferenceTest.
		this.Controls.AddRange(new Control[]{
			this.outputLabel, this.showOutputButton
		});
		this.Name = "ArrayReferenceTest";
		this.Text = "ArrayReferenceTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void showOutputButton_Click(object? sender, EventArgs e)
	{
		int[] firstArray = { 1, 2, 3 };

		int[] firstArrayCopy = firstArray;

		outputLabel.Text = "Test passing firstArray reference by value";

		outputLabel.Text += "\n\nContents of firstArray " +
			"before calling FirstDouble:\n\t";

		for (int i = 0; i < firstArray.Length; i++)
			outputLabel.Text += firstArray[i] + " ";

		FirstDouble(firstArray);

		outputLabel.Text +=
			"\n\nContents of firstArray after " +
			"calling FirstDouble\n\t";

		for (int i = 0; i < firstArray.Length; i++)
			outputLabel.Text += firstArray[i] + " ";

		if (firstArray == firstArrayCopy)
			outputLabel.Text +=
				"\n\nThe reference refer to the same array\n";
		else
			outputLabel.Text +=
				"\n\nThe reference refer to different arrays\n";

		int[] secondArray = { 1, 2, 3 };

		int[] secondArrayCopy = secondArray;

		outputLabel.Text += "\nTest passing secondArray " +
			"reference by reference";

		outputLabel.Text += "\n\nContents of secondArray " +
			"before calling SecondDouble: \n\t";

		for (int i = 0; i < secondArray.Length; i++)
			outputLabel.Text += secondArray[i] + " ";

		SecondDouble(ref secondArray);

		outputLabel.Text += "\n\nContents of secondArray" +
			"after calling SecondDouble: \n\t";

		for (int i = 0; i < secondArray.Length; i++)
			outputLabel.Text += secondArray[i] + " ";

		if (secondArray == secondArrayCopy)
			outputLabel.Text += "\n\nThe references refer to the same array\n";
		else
			outputLabel.Text += "\n\nThe references refer to different arrays\n";
	}

	void FirstDouble(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
			array[i] *= 2;

		array = new int[] { 11, 12, 13 };
	}

	void SecondDouble(ref int[] array)
	{
		for (int i = 0; i < array.Length; i++)
			array[i] *= 2;

		array = new int[] { 11, 12, 13 };
	}
}

partial class ArrayReferenceTest
{
	private Container? components = null;

	public ArrayReferenceTest()
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
		Application.Run(new ArrayReferenceTest());
	}
}
