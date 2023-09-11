// Fig. 12.32: KeyDemo.cs
// Exibindo informações sobre a tecla pressionada pelo usuário.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class KeyDemo : Form
{
	private Label charLabel;
	private Label keyInfoLabel;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.charLabel = new Label();
		this.keyInfoLabel = new Label();

		// charLabel.
		this.charLabel.Name = "charLabel";
		this.charLabel.AutoSize = true;
		this.charLabel.Location = new Point(5, 5);

		// keyInfoLabel.
		this.keyInfoLabel.Name = "keyInfoLabel";
		this.keyInfoLabel.AutoSize = true;
		this.keyInfoLabel.Location = new Point(5, 25);

		// KeyDemo.
		this.KeyPress += new KeyPressEventHandler(KeyDemo_KeyPress);
		this.KeyDown += new KeyEventHandler(KeyDemo_KeyDown);
		this.KeyUp += new KeyEventHandler(KeyDemo_KeyUp);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(150, 200);
		this.Controls.AddRange(new Control[]{
			this.charLabel, this.keyInfoLabel
		});
		this.Name = "KeyDemo";
		this.Text = "KeyDemo";
		this.ResumeLayout(false);
	}
	#endregion

	protected void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
	{
		charLabel.Text = "Key pressed: " + e.KeyChar;
	}

	private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
	{
		keyInfoLabel.Text =
			"Alt: " + (e.Alt ? "Yes" : "No") + "\n" +
			"Shift: " + (e.Shift ? "Yes" : "No") + "\n" +
			"Ctrl: " + (e.Control ? "Yes" : "No") + "\n" +
			"KeyCode: " + e.KeyCode + "\n" +
			"KeyData: " + e.KeyData + "\n" +
			"KeyValue: " + e.KeyValue;
	}

	private void KeyDemo_KeyUp(object sender, KeyEventArgs e)
	{
		keyInfoLabel.Text = "";
		charLabel.Text = "";
	}
}

partial class KeyDemo
{
	private Container components = null;

	public KeyDemo()
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
		Application.Run(new KeyDemo());
	}
}
