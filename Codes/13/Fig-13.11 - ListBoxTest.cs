// Fig 13.11: ListBoxTest.cs
// Programa para adicionar, remover e limpar itens de caixa de lista.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ListBoxTest : Form
{
	private ListBox displayListBox;

	private TextBox inputTextBox;

	private Button addButton;
	private Button removeButton;
	private Button clearButton;
	private Button exitButton;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.displayListBox = new ListBox();

		this.inputTextBox = new TextBox();

		this.addButton = new Button();
		this.removeButton = new Button();
		this.clearButton = new Button();
		this.exitButton = new Button();

		// displayListBox.
		this.displayListBox.Name = "displayListBox";
		this.displayListBox.Location = new Point(10, 10);
		this.displayListBox.Size = new Size(100, 150);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.Location = new Point(120, 10);
		this.inputTextBox.Size = new Size(100, 30);

		// addButton.
		this.addButton.Name = "addButton";
		this.addButton.Text = "Add";
		this.addButton.Location = new Point(120, 40);
		this.addButton.Size = new Size(100, 30);
		this.addButton.Click += new EventHandler(this.addButton_Click);

		// removeButton.
		this.removeButton.Name = "removeButton";
		this.removeButton.Text = "Remove";
		this.removeButton.Location = new Point(120, 80);
		this.removeButton.Size = new Size(100, 30);
		this.removeButton.Click += new EventHandler(this.removeButton_Click);

		// clearButton.
		this.clearButton.Name = "clearButton";
		this.clearButton.Text = "Clear";
		this.clearButton.Location = new Point(120, 120);
		this.clearButton.Size = new Size(100, 30);
		this.clearButton.Click += new EventHandler(this.clearButton_Click);

		// exitButton.
		this.exitButton.Name = "exitButton";
		this.exitButton.Text = "Exit";
		this.exitButton.Location = new Point(120, 160);
		this.exitButton.Size = new Size(100, 30);
		this.exitButton.Click += new EventHandler(this.exitButton_Click);

		// ListBoxTest.
		this.Controls.AddRange(new Control[]{
			this.displayListBox, this.inputTextBox,
			this.addButton, this.removeButton,
			this.clearButton, this.exitButton
		});
		this.Name = "ListBoxTest";
		this.Text = "ListBoxTest";
		this.AutoScaleMode = AutoScaleMode.Font;
		this.AutoSize = true;
		this.ResumeLayout(false);
	}
	#endregion

	private void addButton_Click(object sender, EventArgs e)
	{
		if (inputTextBox.Text.Length > 0)
		{
			displayListBox.Items.Add(inputTextBox.Text);
			inputTextBox.Clear();
			inputTextBox.Focus();
		}
	}

	private void removeButton_Click(object sender, EventArgs e)
	{
		if (displayListBox.SelectedIndex != -1)
			displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
	}

	private void clearButton_Click(object sender, EventArgs e)
	{ displayListBox.Items.Clear(); }

	private void exitButton_Click(object sender, EventArgs e)
	{ Application.Exit(); }
}

partial class ListBoxTest
{
	private Container? components = null;

	public ListBoxTest()
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
		Application.Run(new ListBoxTest());
	}
}
