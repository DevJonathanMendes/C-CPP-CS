// Fig. 15.22: Validate.cs
// Valida informações do usuário com expressões regulares

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

partial class ValidateForm : Form
{
	private Label lastLabel;
	private Label firstLabel;
	private Label addressLabel;
	private Label cityLabel;
	private Label stateLabel;
	private Label zipLabel;
	private Label phoneLabel;

	private Button okButton;

	private TextBox phoneTextBox;
	private TextBox zipTextBox;
	private TextBox stateTextBox;
	private TextBox cityTextBox;
	private TextBox addressTextBox;
	private TextBox firstTextBox;
	private TextBox lastTextBox;

	private void InitializeComponent()
	{
		this.lastLabel = new Label();
		this.firstLabel = new Label();
		this.addressLabel = new Label();
		this.cityLabel = new Label();
		this.stateLabel = new Label();
		this.zipLabel = new Label();
		this.phoneLabel = new Label();

		this.okButton = new Button();

		this.lastTextBox = new TextBox();
		this.firstTextBox = new TextBox();
		this.addressTextBox = new TextBox();
		this.cityTextBox = new TextBox();
		this.stateTextBox = new TextBox();
		this.zipTextBox = new TextBox();
		this.phoneTextBox = new TextBox();

		// lastLabel.
		this.lastLabel.Name = "lastLabel";
		this.lastLabel.Text = "LastName";
		this.lastLabel.AutoSize = true;
		this.lastLabel.Location = new Point(10, 10);

		// firstLabel.
		this.firstLabel.Name = "firstLabel";
		this.firstLabel.Text = "First Name";
		this.firstLabel.AutoSize = true;
		this.firstLabel.Location = new Point(10, 40);

		// addressLabel.
		this.addressLabel.Name = "addressLabel";
		this.addressLabel.Text = "Address";
		this.addressLabel.AutoSize = true;
		this.addressLabel.Location = new Point(10, 70);

		// cityLabel.
		this.cityLabel.Name = "cityLabel";
		this.cityLabel.Text = "City";
		this.cityLabel.AutoSize = true;
		this.cityLabel.Location = new Point(10, 100);

		// stateLabel.
		this.stateLabel.Name = "stateLabel";
		this.stateLabel.Text = "State";
		this.stateLabel.AutoSize = true;
		this.stateLabel.Location = new Point(10, 130);

		// zipLabel.
		this.zipLabel.Name = "zipLabel";
		this.zipLabel.Text = "Zip";
		this.zipLabel.AutoSize = true;
		this.zipLabel.Location = new Point(10, 160);

		// phoneLabel.
		this.phoneLabel.Name = "phoneLabel";
		this.phoneLabel.Text = "Phone";
		this.phoneLabel.AutoSize = true;
		this.phoneLabel.Location = new Point(10, 190);

		// lastTextBox.
		this.lastTextBox.Name = "lastTextBox";
		this.lastTextBox.Text = "";
		this.lastTextBox.Location = new Point(90, 10);

		// firstTextBox.
		this.firstTextBox.Name = "firstTextBox";
		this.firstTextBox.Text = "";
		this.firstTextBox.Location = new Point(90, 40);

		// addressTextBox.
		this.addressTextBox.Name = "addressTextBox";
		this.addressTextBox.Text = "";
		this.addressTextBox.Location = new Point(90, 70);

		// cityTextBox.
		this.cityTextBox.Name = "cityTextBox";
		this.cityTextBox.Text = "";
		this.cityTextBox.Location = new Point(90, 100);

		// stateTextBox.
		this.stateTextBox.Name = "stateTextBox";
		this.stateTextBox.Text = "";
		this.stateTextBox.Location = new Point(90, 130);

		// zipTextBox.
		this.zipTextBox.Name = "zipTextBox";
		this.zipTextBox.Text = "";
		this.zipTextBox.Location = new Point(90, 160);

		// phoneTextBox.
		this.phoneTextBox.Name = "phoneTextBox";
		this.phoneTextBox.Text = "";
		this.phoneTextBox.Location = new Point(90, 190);

		// okButton.
		this.okButton.Name = "okButton";
		this.okButton.Text = "Ok";
		this.okButton.AutoSize = true;
		this.okButton.Location = new Point(10, 220);
		this.okButton.Click += new EventHandler(okButton_Click);

		// ValidateForm.
		this.Controls.AddRange(new Control[]{
			this.phoneLabel, this.zipLabel,
			this.stateLabel, this.cityLabel,
			this.addressLabel, this.firstLabel,
			this.lastLabel, this.okButton,

			this.phoneTextBox, this.zipTextBox,
			this.stateTextBox, this.cityTextBox,
			this.addressTextBox, this.firstTextBox,
			this.lastTextBox
		});
		this.Name = "ValidateForm";
		this.Text = "ValidateForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void okButton_Click(object? sender, EventArgs e)
	{
		// Garante que nenhuma caixa de texto esteja vazia.
		if (lastTextBox.Text == "" || firstTextBox.Text == "" ||
				addressTextBox.Text == "" || cityTextBox.Text == "" ||
				stateTextBox.Text == "" || zipTextBox.Text == "" ||
				phoneTextBox.Text == ""
			)
		{
			MessageBox.Show("Please fill in all fields", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			lastTextBox.Focus();

			return;
		}

		if (!Regex.Match(lastTextBox.Text, @"^[A-Z][a-zA-Z]*$").Success)
		{
			MessageBox.Show("Invalid Last Name", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(firstTextBox.Text, @"^[A-Z][a-zA-Z]*$").Success)
		{
			MessageBox.Show("Invalid First Name", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(addressTextBox.Text, @"^[0-9]+\s+([a-zA-Z]+[a-zA-Z]+\s[a-zA-Z]+)$").Success)
		{
			MessageBox.Show("Invalid Address", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(cityTextBox.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
		{
			MessageBox.Show("Invalid city", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(stateTextBox.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
		{
			MessageBox.Show("Invalid state", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(zipTextBox.Text, @"^\d{5}$").Success)
		{
			MessageBox.Show("Invalid Zip", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		if (!Regex.Match(phoneTextBox.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
		{
			MessageBox.Show("Invalid Phone", "Message",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		// A informação é válida, sinaliza para o usuário e sai do aplicativo.
		this.Hide();

		MessageBox.Show("Thank You!", "Information Correct",
			MessageBoxButtons.OK, MessageBoxIcon.Information);

		Application.Exit();
	}
}

partial class ValidateForm
{
	private Container? components = null;

	public ValidateForm()
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
		Application.Run(new ValidateForm());
	}
}
