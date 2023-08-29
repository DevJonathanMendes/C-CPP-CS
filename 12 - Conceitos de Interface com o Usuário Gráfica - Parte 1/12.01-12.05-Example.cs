// 12.01 - 12.05: Example.

using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

public class Program : Form
{
	private Button displayPasswordButton;
	private Label displayPasswordLabel;
	private TextBox inputPasswordTextBox;

	public Program()
	{
		this.displayPasswordButton = new Button();
		this.inputPasswordTextBox = new TextBox();
		this.displayPasswordLabel = new Label();
		this.SuspendLayout();

		InitializeComponent();
	}

	private Container? components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		// displayPasswordButton.
		this.displayPasswordButton.Name = "displayPasswordButton";
		this.displayPasswordButton.Text = "Show Me";
		this.displayPasswordButton.TabIndex = 1;
		this.displayPasswordButton.Location = new Point(96, 96);
		this.displayPasswordButton.Click += new EventHandler(this.displayPasswordButton_Click);

		// inputPasswordTextBox
		this.inputPasswordTextBox.Name = "inputPasswordTextBox";
		this.inputPasswordTextBox.Text = "";
		this.inputPasswordTextBox.TabIndex = 0;
		this.inputPasswordTextBox.Location = new Point(16, 16);
		this.inputPasswordTextBox.PasswordChar = '*';
		this.inputPasswordTextBox.Size = new Size(264, 20);

		// displayPasswordLabel
		this.displayPasswordLabel.Name = "displayPasswordLabel";
		this.displayPasswordLabel.TabIndex = 2;
		this.displayPasswordLabel.BorderStyle = BorderStyle.Fixed3D;
		this.displayPasswordLabel.Location = new Point(16, 48);
		this.displayPasswordLabel.Size = new Size(264, 23);


		// Program
		this.AutoScaleBaseSize = new Size(5, 13);
		this.ClientSize = new Size(292, 133);
		this.Controls.AddRange(new Control[]{
						this.displayPasswordLabel,
						this.inputPasswordTextBox,
						this.displayPasswordButton
				});
		this.Name = "Program";
		this.Text = "Program";
		this.ResumeLayout(false);
	}
	#endregion

	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Program());
	}

	protected void displayPasswordButton_Click(object sender, EventArgs e)
	{ displayPasswordLabel.Text = inputPasswordTextBox.Text; }
}
