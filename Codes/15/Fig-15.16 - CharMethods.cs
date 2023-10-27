// Fig. 15.16: CharMethods.cs
// Demonstra métodos estáticos de teste de caracteres da estrutura Char.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class CharMethods : Form
{
	private Label enterLabel;
	private TextBox inputTextBox;
	private Button analyzeButton;
	private Label outputLabel;

	private void InitializeComponent()
	{
		this.enterLabel = new Label();
		this.inputTextBox = new TextBox();
		this.analyzeButton = new Button();
		this.outputLabel = new Label();

		// enterLabel.
		this.enterLabel.Name = "enterLabel";
		this.enterLabel.Text = "Enter a character:";
		this.enterLabel.AutoSize = true;
		this.enterLabel.Location = new Point(10, 10);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.Location = new Point(110, 10);

		// analyzeButton.
		this.analyzeButton.Name = "analyzeButton";
		this.analyzeButton.Text = "Analyze Character";
		this.analyzeButton.AutoSize = true;
		this.analyzeButton.Location = new Point(10, 60);
		this.analyzeButton.Click += new EventHandler(analyzeButton_Click);

		// outputTextBox.
		this.outputLabel.Name = "outputTextBox";
		this.outputLabel.Text = "";
		this.outputLabel.AutoSize = true;
		this.outputLabel.Location = new Point(10, 90);

		// CharMethods.
		this.Controls.AddRange(new Control[]{
			this.enterLabel, this.inputTextBox,
			this.analyzeButton, this.outputLabel
		});
		this.Name = "CharMethods";
		this.Text = "CharMethods";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void analyzeButton_Click(object? sender, EventArgs a)
	{
		char character = Convert.ToChar(inputTextBox.Text);
		BuildOutput(character);
	}

	private void BuildOutput(char inputCharacter)
	{
		string output;

		output = "is digit: " +
			Char.IsDigit(inputCharacter) + "\r\n";

		output += "is letter: " +
			Char.IsLetter(inputCharacter) + "\r\n";

		output += "is letter or digit: " +
			Char.IsLetterOrDigit(inputCharacter) + "\r\n";

		output += "is lower case: " +
					Char.IsLower(inputCharacter) + "\r\n";

		output += "is upper case: " +
					Char.IsUpper(inputCharacter) + "\r\n";

		output += "is upper case: " +
				Char.ToUpper(inputCharacter) + "\r\n";

		output += "to lowe case: " +
				Char.ToLower(inputCharacter) + "\r\n";

		output += "is punctuation: " +
				Char.IsPunctuation(inputCharacter) + "\r\n";

		output += "is symbol: " +
				Char.IsSymbol(inputCharacter);

		outputLabel.Text = output;
	}
}

partial class CharMethods
{
	private Container? components = null;

	public CharMethods()
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
		Application.Run(new CharMethods());
	}
}
