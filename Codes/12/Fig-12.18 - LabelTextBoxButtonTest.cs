// Fig. 12.18: LabelTextBoxButtonTest.
// Usando TextBox, Label e Button para exibir o texto oculto em uma caixa de senha.

using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

partial class LabelTextBoxButtonTest : Form
{
	private Button displayPasswordButton;
	private Label displayPasswordLabel;
	private TextBox inputPasswordTextBox;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.displayPasswordButton = new Button();
		this.inputPasswordTextBox = new TextBox();
		this.displayPasswordLabel = new Label();
		this.SuspendLayout();

		// displayPasswordButton.
		this.displayPasswordButton.Location = new Point(96, 96);
		this.displayPasswordButton.Name = "displayPasswordButton";
		this.displayPasswordButton.TabIndex = 1;
		this.displayPasswordButton.Text = "Show Me";
		this.displayPasswordButton.Click += new EventHandler(this.displayPasswordButton_Click);

		// inputPasswordTextBox
		this.inputPasswordTextBox.Location = new Point(16, 16);
		this.inputPasswordTextBox.Name = "inputPasswordTextBox";
		this.inputPasswordTextBox.PasswordChar = '*';
		this.inputPasswordTextBox.Size = new Size(264, 20);
		this.inputPasswordTextBox.TabIndex = 0;
		this.inputPasswordTextBox.Text = "";

		// displayPasswordLabel
		this.displayPasswordLabel.BorderStyle = BorderStyle.Fixed3D;
		this.displayPasswordLabel.Location = new Point(16, 48);
		this.displayPasswordLabel.Name = "displayPasswordLabel";
		this.displayPasswordLabel.Size = new Size(264, 23);
		this.displayPasswordLabel.TabIndex = 2;

		// LabelTextBoxButtonTest
		this.AutoScaleBaseSize = new Size(5, 13);
		this.ClientSize = new Size(292, 133);
		this.Controls.AddRange(new Control[]{
			this.displayPasswordLabel,
			this.inputPasswordTextBox,
			this.displayPasswordButton});
		this.Name = "LabelTextBoxButtonTest";
		this.Text = "LabelTextBoxButtonTest";
		this.ResumeLayout(false);
	}
	#endregion
	protected void displayPasswordButton_Click(object? sender, EventArgs e)
	{ displayPasswordLabel.Text = inputPasswordTextBox.Text; }
}

public partial class LabelTextBoxButtonTest
{
	private Container components = null;

	public LabelTextBoxButtonTest()
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
		Application.Run(new LabelTextBoxButtonTest());
	}
}
