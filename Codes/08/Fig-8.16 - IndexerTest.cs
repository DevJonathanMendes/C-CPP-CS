// Fig. 8.16: IndexerTest.cs
// Os indexadores fornecem acesso aos membros de um objeto por meio de um operador de índice.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// A definição da classe Box representa uma caixa com dimensões de comprimento, largura e altura.
public class Box
{
	private string[] names = { "length", "width", "height" };
	private double[] dimensions = new double[3];

	public Box(double length, double width, double height)
	{
		dimensions[0] = length;
		dimensions[1] = width;
		dimensions[2] = height;
	}

	// Acessa dimensões pelo número de índice inteiro.
	public double this[int index]
	{
		get
		{
			return (index < 0 || index >= dimensions.Length) ?
				-1 : dimensions[index];
		}
		set
		{
			if (index >= 0 && index < dimensions.Length)
				dimensions[index] = value;
		}
	}

	public double this[string name]
	{
		get
		{
			int i = 0;

			while (i < names.Length && name.ToLower() != names[i])
				i++;

			return (i == name.Length) ? -1 : dimensions[i];
		}
		set
		{
			int i = 0;

			while (i < names.Length && name.ToLower() != names[i])
				i++;

			if (i != name.Length)
				dimensions[i] = value;
		}
	}
}

partial class IndexerTest : Form
{
	private Label indexLabel;
	private Label nameLabel;

	private TextBox indexTextBox;
	private TextBox valueTextBox;

	private Button nameSetButton;
	private Button nameGetButton;

	private Button intSetButton;
	private Button intGetButton;

	private TextBox resultTextBox;

	private Box box;

	private void InitializeComponent()
	{
		box = new Box(0.0, 0.0, 0.0);

		this.indexLabel = new Label();
		this.nameLabel = new Label();

		this.indexTextBox = new TextBox();
		this.valueTextBox = new TextBox();

		this.nameSetButton = new Button();
		this.nameGetButton = new Button();

		this.intSetButton = new Button();
		this.intGetButton = new Button();

		this.resultTextBox = new TextBox();

		// indexLabel.
		this.indexLabel.Name = "indexLabel";
		this.indexLabel.Text = "Index to set/get";
		this.indexLabel.AutoSize = true;
		this.indexLabel.Location = new Point(10, 10);

		// indexTextBox.
		this.indexTextBox.Name = "indexTextBox";
		this.indexTextBox.Text = "";
		this.indexTextBox.Location = new Point(110, 10);

		// intGetButton.
		this.intGetButton.Name = "intGetButton";
		this.intGetButton.Text = "Get Value by Index";
		this.intGetButton.AutoSize = true;
		this.intGetButton.Location = new Point(220, 10);
		this.intGetButton.Click += new EventHandler(intGetButton_Click);

		// intSetButton.
		this.intSetButton.Name = "intSetButton";
		this.intSetButton.Text = "Set Value by Index";
		this.intSetButton.AutoSize = true;
		this.intSetButton.Location = new Point(340, 10);
		this.intSetButton.Click += new EventHandler(intSetButton_Click);

		// nameLabel.
		this.nameLabel.Name = "nameLabel";
		this.nameLabel.Text = "Value to set";
		this.nameLabel.AutoSize = true;
		this.nameLabel.Location = new Point(10, 40);

		// valueTextBox.
		this.valueTextBox.Name = "valueTextBox";
		this.valueTextBox.Text = "";
		this.valueTextBox.Location = new Point(110, 40);

		// nameGetButton.
		this.nameGetButton.Name = "nameGetButton";
		this.nameGetButton.Text = "Get Value by Name";
		this.nameGetButton.AutoSize = true;
		this.nameGetButton.Location = new Point(220, 40);
		this.nameGetButton.Click += new EventHandler(intGetButton_Click);

		// nameSetButton.
		this.nameSetButton.Name = "nameSetButton";
		this.nameSetButton.Text = "Set Value by Name";
		this.nameSetButton.AutoSize = true;
		this.nameSetButton.Location = new Point(340, 40);
		this.nameSetButton.Click += new EventHandler(nameSetButton_Click);

		// resultTextBox.
		this.resultTextBox.Name = "resultTextBox";
		this.resultTextBox.Text = "";
		this.resultTextBox.Size = new Size(400, 1);
		this.resultTextBox.Location = new Point(10, 70);

		// IndexerTest.
		this.Controls.AddRange(new Control[]{
			this.indexLabel, this.nameLabel,
			this.indexTextBox, this.valueTextBox,
			this.nameSetButton, this.nameGetButton,
			this.intSetButton, this.intGetButton,
			this.resultTextBox,
		});
		this.Name = "IndexerTest";
		this.Text = "IndexerTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void ShowValueAtIndex(string prefix, int index)
	{
		resultTextBox.Text = prefix + "box[ " + index + " ] = " + box[index];
	}

	private void ShowValueAtIndex(string prefix, string name)
	{
		resultTextBox.Text = prefix + "box[ " + name + " ] = " + box[name];
	}

	private void ClearTextBoxes()
	{
		indexTextBox.Text = "";
		valueTextBox.Text = "";
	}

	private void intGetButton_Click(object? sender, EventArgs e)
	{
		ShowValueAtIndex("get: ", Int32.Parse(indexTextBox.Text));
		ClearTextBoxes();
	}

	private void intSetButton_Click(object? sender, EventArgs e)
	{
		int index = Int32.Parse(indexTextBox.Text);
		box[index] = Double.Parse(valueTextBox.Text);

		ShowValueAtIndex("set: ", index);
		ClearTextBoxes();
	}

	private void nameGetButton_Click(object? sender, EventArgs e)
	{
		ShowValueAtIndex("get: ", indexTextBox.Text);
		ClearTextBoxes();
	}

	private void nameSetButton_Click(object? sender, EventArgs e)
	{
		box[indexTextBox.Text] = Double.Parse(valueTextBox.Text);

		ShowValueAtIndex("set: ", indexTextBox.Text);
		ClearTextBoxes();
	}
}

partial class IndexerTest
{
	private Container? components = null;

	public IndexerTest()
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
		Application.Run(new IndexerTest());
	}
}
