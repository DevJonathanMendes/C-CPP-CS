// Fig. 13.38: VisualInheritance.cs
// Formulário base para uso com herança visual;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

public class VisualInheritance : Form
{
	private Label bugsLabel;
	private Button learnMoreButton;
	private Label Label1;

	private Container? components = null;

	private void InitializeComponent()
	{
		this.bugsLabel = new Label();
		this.learnMoreButton = new Button();
		this.Label1 = new Label();

		// bugsLabel.
		this.bugsLabel.Name = "bugsLabel";
		this.bugsLabel.Text = "Bugs, Bugs, Bugs";
		this.bugsLabel.AutoSize = true;
		this.bugsLabel.Location = new Point(10, 10);

		// learnMoreButton.
		this.learnMoreButton.Name = "learnMoreButton";
		this.learnMoreButton.Text = "Learn\nMore";
		this.learnMoreButton.AutoSize = true;
		this.learnMoreButton.Location = new Point(10, 40);
		this.learnMoreButton.Click += new EventHandler(learnMoreButton_Click);

		// Label1.
		this.Label1.Name = "Label1";
		this.Label1.Text = "Copyright 2002, Bug2Bug.com";
		this.Label1.AutoSize = true;
		this.Label1.Location = new Point(10, 90);

		// VisualInheritance.
		this.Controls.AddRange(new Control[]{
			this.bugsLabel, this.learnMoreButton,
			this.Label1
		});
		this.Name = "VisualInheritance";
		this.Text = "VisualInheritance";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void learnMoreButton_Click(object? sender, EventArgs e)
	{
		MessageBox.Show(
			"Bugs, Bugs, Bug is a product of Bug2Bug.com",
			"Learn More", MessageBoxButtons.OK,
			MessageBoxIcon.Information
		);
	}

	public VisualInheritance()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}
