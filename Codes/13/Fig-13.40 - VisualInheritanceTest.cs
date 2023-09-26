// Fig. 13.40: VisualInheritanceTest.cs
// Formulário derivado usando herança visual.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole o programa da figura 13.38 (VisualInheritance.cs) aqui.
// Ainda não está sendo usado namespaces.

partial class VisualInheritanceTest : VisualInheritance
{
	private Button learnProgramButton;

	private void InitializeComponent()
	{
		this.learnProgramButton = new Button();

		// learnProgramButton.
		this.learnProgramButton.Name = "learnProgramButton";
		this.learnProgramButton.Text = "Learn the\nProgram";
		this.learnProgramButton.AutoSize = true;
		this.learnProgramButton.Location = new Point(100, 40);
		this.learnProgramButton.Click += new EventHandler(learnProgramButton_Click);

		// VisualInheritanceTest.
		this.Controls.Add(this.learnProgramButton);
		this.Name = "VisualInheritanceTest";
		this.Text = "VisualInheritanceTest";
	}

	private void learnProgramButton_Click(object? sender, EventArgs e)
	{
		MessageBox.Show(
			"This program was created by Deitel & Associates",
			"Learn the Program", MessageBoxButtons.OK,
			MessageBoxIcon.Information
		);
	}
}

partial class VisualInheritanceTest
{
	private Container? components = null;

	public VisualInheritanceTest()
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
		Application.Run(new VisualInheritanceTest());
	}
}
