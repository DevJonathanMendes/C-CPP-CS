// Fig. 13.13: CheckedListBoxTest.cs
// Usando as caixas de lista marcadas para adicionar itens em uma caixa de lista.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class CheckedListBoxTest : Form
{
	private CheckedListBox inputCheckedListBox;
	private ListBox displayListBox;

	private void InitializeComponent()
	{
		this.inputCheckedListBox = new CheckedListBox();
		this.displayListBox = new ListBox();

		// inputCheckedListBox.
		this.inputCheckedListBox.Name = "inputCheckedListBox";
		this.inputCheckedListBox.Text = "T1";
		this.inputCheckedListBox.Items.AddRange(new object[]{
			"Cobol", "C", "C++", "C#", "Java", "JavaScript"
		});
		this.inputCheckedListBox.Location = new Point(10, 10);
		this.inputCheckedListBox.ItemCheck += new ItemCheckEventHandler(inputCheckedListBox_Click);

		// displayListBox.
		this.displayListBox.Name = "displayListBox";
		this.displayListBox.Text = "T2";
		this.displayListBox.Location = new Point(150, 10);

		// CheckedListBoxTest.
		this.Controls.AddRange(new Control[]{
			this.inputCheckedListBox, this.displayListBox
		});
		this.Name = "CheckedListBoxTest";
		this.Text = "CheckedListBoxTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void inputCheckedListBox_Click(object? sender, ItemCheckEventArgs e)
	{
		string item = inputCheckedListBox.SelectedItem.ToString();

		if (e.NewValue == CheckState.Checked)
			displayListBox.Items.Add(item);
		else
			displayListBox.Items.Remove(item);
	}
}

partial class CheckedListBoxTest
{
	private Container? components = null;

	public CheckedListBoxTest()
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
		Application.Run(new CheckedListBoxTest());
	}
}
