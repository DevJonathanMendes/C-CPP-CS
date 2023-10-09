// Fig. 7.15: DoubleArray.cs
// Manipulando um array bidimensional.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class TwoDimensionalArrays : Form
{
	private Button showOutputButton;
	private Label outputLabel;

	int[][] grades;
	int students, exams;

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
		grades = new int[3][];
		grades[0] = new int[] { 77, 68, 86, 73 };
		grades[1] = new int[] { 96, 87, 89, 81 };
		grades[2] = new int[] { 70, 90, 86, 81 };

		students = grades.Length;
		exams = grades[0].Length;

		outputLabel.Text = "                   ";

		for (int i = 0; i < exams; i++)
			outputLabel.Text += "[" + i + "]  ";

		for (int i = 0; i < students; i++)
		{
			outputLabel.Text += "\ngrades[" + i + "]   ";
			for (int j = 0; j < exams; j++)
				outputLabel.Text += grades[i][j] + "   ";
		}

		outputLabel.Text += "\n\nLowest grades: " + Minimum() +
			"\nHighest grade: " + Maximum() + "\n";

		for (int i = 0; i < students; i++)
		{
			outputLabel.Text += "\nAverage for student " + i + " is " +
			Average(grades[i]);
		}
	}

	public int Minimum()
	{
		int lowGrade = 100;

		for (int i = 0; i < students; i++)
			for (int j = 0; j < exams; j++)
				if (grades[i][j] < lowGrade)
					lowGrade = grades[i][j];

		return lowGrade;
	}

	public int Maximum()
	{
		int highGrade = 0;

		for (int i = 0; i < students; i++)
			for (int j = 0; j < exams; j++)
				if (grades[i][j] > highGrade)
					highGrade = grades[i][j];

		return highGrade;
	}

	public double Average(int[] setOfGrades)
	{
		int total = 0;

		for (int i = 0; i < setOfGrades.Length; i++)
			total += setOfGrades[i];

		return (double)total / setOfGrades.Length;
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
