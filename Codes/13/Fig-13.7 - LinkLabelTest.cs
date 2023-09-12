// Fig. 13.7: LinkLabelTest.cs
// Usando LinkLabels para criar links.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class LinkLabelTest : Form
{
	private LinkLabel driveLinkLabel;
	private LinkLabel deitelLinkLabel;
	private LinkLabel notepadLinkLabel;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.driveLinkLabel = new LinkLabel();
		this.deitelLinkLabel = new LinkLabel();
		this.notepadLinkLabel = new LinkLabel();

		// driveLinkLabel.
		this.driveLinkLabel.Name = "driveLinkLabel";
		this.driveLinkLabel.Text = "Click to browse C:\\";
		this.driveLinkLabel.AutoSize = true;
		this.driveLinkLabel.Location = new Point(10, 10);
		this.driveLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.driveLinkLabel_LinkClicked);

		// deitelLinkLabel.
		this.deitelLinkLabel.Name = "deitelLinkLabel";
		this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
		this.deitelLinkLabel.AutoSize = true;
		this.deitelLinkLabel.Location = new Point(10, 30);
		this.driveLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);

		// notepadLinkLabel.
		this.notepadLinkLabel.Name = "notepadLinkLabel";
		this.notepadLinkLabel.Text = "Click to run notepad";
		this.notepadLinkLabel.AutoSize = true;
		this.notepadLinkLabel.Location = new Point(10, 50);
		this.driveLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.notepadLinkLabel_LinkClicked);

		// LinkLabelTest.
		this.Controls.AddRange(new Control[]{
			this.driveLinkLabel, this.deitelLinkLabel,
			this.notepadLinkLabel
		});
		this.AutoScaleMode = AutoScaleMode.Font;
		this.AutoSize = true;
		this.Name = "LinkLabelTest";
		this.Text = "LinkLabelTest";
		this.ResumeLayout(false);
	}
	#endregion

	private void driveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		driveLinkLabel.LinkVisited = true;
		System.Diagnostics.Process.Start("C:\\");
	}

	private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		deitelLinkLabel.LinkVisited = true;
		System.Diagnostics.Process.Start("IExplorer", "http://www.deitel.com");
	}

	private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		notepadLinkLabel.LinkVisited = true;
		System.Diagnostics.Process.Start("notepad");
	}
}

partial class LinkLabelTest
{
	private Container? components = null;

	public LinkLabelTest()
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
		Application.Run(new LinkLabelTest());
	}
}
