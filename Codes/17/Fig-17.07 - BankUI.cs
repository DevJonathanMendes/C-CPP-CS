// Fig. 17.07: BankUI
// Um formulário Windows reutilizável para os exemplos deste capítulo.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class BankUIForm : Form
{
	public Label accountLabel;
	public TextBox accountTextBox;

	public Label firstNameLabel;
	public TextBox firstNameTextBox;

	public Label lastNameLabel;
	public TextBox lastNameTextBox;

	public Label balanceLabel;
	public TextBox balanceTextBox;

	// Número de TextBoxes no formulário.
	protected int TextBoxCount = 4;

	// As constantes da enumeração especificam índices de TextBox.
	public enum TextBoxIndices
	{
		ACCOUNT,
		FIRST,
		LAST,
		BALANCE
	}

	private void InitializeComponent()
	{
		this.accountLabel = new Label();
		this.accountTextBox = new TextBox();
		this.firstNameLabel = new Label();
		this.firstNameTextBox = new TextBox();
		this.lastNameLabel = new Label();
		this.lastNameTextBox = new TextBox();
		this.balanceLabel = new Label();
		this.balanceTextBox = new TextBox();

		// accountLabel.
		this.accountLabel.Name = "accountLabel";
		this.accountLabel.Text = "Account";
		this.accountLabel.AutoSize = true;
		this.accountLabel.Location = new Point(10, 12);

		// accountTextBox.
		this.accountTextBox.Name = "accountTextBox";
		this.accountTextBox.Text = "";
		this.accountTextBox.Location = new Point(100, 10);

		// firstNameLabel.
		this.firstNameLabel.Name = "firstNameLabel";
		this.firstNameLabel.Text = "FirstName";
		this.firstNameLabel.AutoSize = true;
		this.firstNameLabel.Location = new Point(10, 42);

		// firstNameTextBox.
		this.firstNameTextBox.Name = "firstNameTextBox";
		this.firstNameTextBox.Text = "";
		this.firstNameTextBox.Location = new Point(100, 40);

		// lastNameLabel.
		this.lastNameLabel.Name = "lastNameLabel";
		this.lastNameLabel.Text = "LastName";
		this.lastNameLabel.AutoSize = true;
		this.lastNameLabel.Location = new Point(10, 72);

		// lastNameTextBox.
		this.lastNameTextBox.Name = "lastNameTextBox";
		this.lastNameTextBox.Text = "";
		this.lastNameTextBox.Location = new Point(100, 70);

		// balanceLabel.
		this.balanceLabel.Name = "balanceLabel";
		this.balanceLabel.Text = "Balance";
		this.balanceLabel.AutoSize = true;
		this.balanceLabel.Location = new Point(12, 100);

		// balanceTextBox.
		this.balanceTextBox.Name = "balanceTextBox";
		this.balanceTextBox.Text = "";
		this.balanceTextBox.Location = new Point(100, 100);

		// BankUIForm.
		this.Controls.AddRange(new Control[]{
			this.accountLabel, this.accountTextBox,
			this.firstNameLabel, this.firstNameTextBox,
			this.lastNameLabel, this.lastNameTextBox,
			this.balanceLabel, this.balanceTextBox
		});
		this.Name = "BankUIForm";
		this.Text = "BankUIForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Limpa todas as TextBoxes.
	public void ClearTextBoxes()
	{
		// Percorre todos os controles do formulário.
		for (int i = 0; i < Controls.Count; i++)
		{
			Control myControl = Controls[i];

			if (myControl is TextBox)
			{
				// Limpa a propriedade Text (configura como string vazia)
				myControl.Text = "";
			}
		}
	}

	public void SetTextBoxValues(string[] values)
	{
		// Determina se o array de strings tem o tamanho correto.
		if (values.Length != TextBoxCount)
		{
			throw (new ArgumentException("There must be " +
			(TextBoxCount + 1) + " strings in the array"));
		}
		else
		{
			// Configura os valores do array com os valores da caixa de texto.
			accountTextBox.Text = values[(int)TextBoxIndices.ACCOUNT];
			firstNameTextBox.Text = values[(int)TextBoxIndices.FIRST];
			lastNameTextBox.Text = values[(int)TextBoxIndices.LAST];
			balanceTextBox.Text = values[(int)TextBoxIndices.BALANCE];
		}
	}

	public string[] GetTextBoxValues()
	{
		string[] values = new string[TextBoxCount];

		// Copia os campos da caixa de texto no array de strings.
		values[(int)TextBoxIndices.ACCOUNT] = accountTextBox.Text;
		values[(int)TextBoxIndices.FIRST] = firstNameTextBox.Text;
		values[(int)TextBoxIndices.LAST] = lastNameTextBox.Text;
		values[(int)TextBoxIndices.BALANCE] = balanceLabel.Text;

		return values;
	}
}

partial class BankUIForm
{
	private Container? components = null;

	public BankUIForm()
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
		Application.Run(new BankUIForm());
	}
}
