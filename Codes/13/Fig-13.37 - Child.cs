// Fig. 13.37: Child.cs
// Janela filha de progenitor MDI.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

public class Child : Form
{
	private PictureBox pictureBox;

	private Container? components = null;

	public Child(string title, string fileName)
	{
		InitializeComponent();

		this.Text = title;

		pictureBox.Image = Image.FromFile(
		 Directory.GetCurrentDirectory() + fileName
	 	);
	}

	private void InitializeComponent()
	{
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}
