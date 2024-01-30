// Fig. 17.17: ReadRandomAccessFile.cs
// Lê e exibe o conteúdo do arquivo de acesso aleatório.

using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;

// using BankLibrary;

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.
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

	private Container? components = null;

	public BankUIForm()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
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

// // Cole a classe RandomAccessRecord (Fig-17.14 - RandomAccessRecord) aqui.
public class RandomAccessRecord
{
	// Tamanho de firstName e lastName.
	private const int CHAR_ARRAY_LENGTH = 15;

	private const int SIZE_OF_CHAR = 2;
	private const int SIZE_OF_INT32 = 4;
	private const int SIZE_OF_DOUBLE = 8;

	// Tamanho do registro.
	public const int SIZE = SIZE_OF_INT32 +
		2 * (SIZE_OF_CHAR * CHAR_ARRAY_LENGTH) + SIZE_OF_DOUBLE;

	// Grava dados.
	private int account;
	private char[] firstName = new char[CHAR_ARRAY_LENGTH];
	private char[] lastName = new char[CHAR_ARRAY_LENGTH];
	private double balance;

	// Construtor padrão configura os membros com valores padrão.
	public RandomAccessRecord() : this(0, "", "", 0.0) { }

	// O construtor sobrecarregado configura os membros com valores do parâmetro.
	public RandomAccessRecord(int accountValue, string firstNameValue,
		string lastNameValue, double balanceValue)
	{
		Account = accountValue;
		FirstName = firstNameValue;
		LastName = lastNameValue;
		Balance = balanceValue;
	}

	public int Account
	{
		get { return account; }
		set { account = value; }
	}

	public string FirstName
	{
		get { return new string(firstName); }
		set
		{
			// Determina o tamanho do parâmetro string.
			int stringSize = value.Length;

			// Representação de string de firstName.
			string firstNameString = value;

			// Inclui espaços no final do parâmetro string se for curto demais.
			if (CHAR_ARRAY_LENGTH >= stringSize)
			{
				firstNameString = value + new string(' ', CHAR_ARRAY_LENGTH - stringSize);
			}
			else
			{
				// Remove caracteres do parâmetro string se for longo demais.
				firstNameString = value.Substring(0, CHAR_ARRAY_LENGTH);
			}

			// Converte o parâmetro string em array de char.
			firstName = firstNameString.ToCharArray();
		}
	}

	public string LastName
	{
		get { return new string(lastName); }
		set
		{
			// Determina o tamanho do parâmetro string.
			int stringSize = value.Length;

			// Representação de string de lastName.
			string lastNameString = value;

			// Inclui espaços no final do parâmetro string se for curto demais.
			if (CHAR_ARRAY_LENGTH >= stringSize)
			{
				lastNameString = value +
					new string(' ', CHAR_ARRAY_LENGTH - stringSize);
			}
			else
			{
				// Remove caracteres do parâmetro string se for longo demais.
				lastNameString =
					value.Substring(0, CHAR_ARRAY_LENGTH);
			}

			// Converte o parâmetro string em array char.
			lastName = lastNameString.ToCharArray();
		}
	}

	public double Balance
	{
		get { return balance; }
		set { balance = value; }
	}
}

partial class ReadRandomAccessFile : Form
{
	private Button openButton;
	private Button nextButton;

	private FileStream fileInput;

	private BinaryReader binaryInput;

	private int currentRecordIndex;

	private void InitializeComponent()
	{
		this.openButton = new Button();
		this.nextButton = new Button();

		// openButton.
		this.openButton.Name = "openButton";
		this.openButton.Text = "Open File";
		this.openButton.AutoSize = true;
		this.openButton.Location = new Point(10, 130);
		this.openButton.Click += new EventHandler(this.openButton_Click);

		// nextButton.
		this.nextButton.Name = "nextButton";
		this.nextButton.Text = "Next";
		this.nextButton.AutoSize = true;
		this.nextButton.Location = new Point(100, 130);
		this.nextButton.Click += new EventHandler(this.nextButton_Click);

		// ReadRandomAccessFile.
		this.Controls.AddRange(new Control[]{
			this.openButton, this.nextButton
		});
		this.Name = "ReadRandomAccessFile";
		this.Text = "ReadRandomAccessFile";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Chamado quando o usuário clica no botão Open File.
	private void openButton_Click(object? sender, EventArgs e)
	{
		// Cria uma caixa de diálogo permitindo que o usuário abra arquivo.
		OpenFileDialog fileChooser = new OpenFileDialog();
		DialogResult result = fileChooser.ShowDialog();

		// Obtém o nome de arquivo do usuário.
		string fileName = fileChooser.FileName;

		// Sai do manipulador de evento se o usuário clicou em Cancelar.
		if (result == DialogResult.Cancel)
			return;

		// Mostra erro se o usuário especificou um arquivo inválido.
		if (fileName == "" || fileName == null)
			MessageBox.Show("Invalid File Name", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		else
		{
			// Cria FileStream para obter acesso de leitura para o arquivo.
			fileOutput = new FileStream(fileName, FileMode.Open, FileAccess.Read);

			// Cria FileStream para obter acesso de leitura para o arquivos.
			binaryOutput = new BinaryReader(fileOutput);

			openButton.Enabled = false;
			nextButton.Enabled = true;

			currentRecordIndex = 0;
			ClearTextBoxes();
		}
	}


	// Chamado quando o usuário clica no botão Next Record.
	private void nextButton_Click(object? sender, EventArgs e)
	{
		// Obtém o próximo registro disponível no arquivo.
		Record record = RandomAccessRecord();

		// Lê o registro e armazena dados em TextBox.
		try
		{
			string[] values; // Para armazenar valores de TextBox.

			// Obtém próximo registro disponível no arquivo.
			while (record.Account == 0)
			{
				fileInput.Seek(currentRecordIndex * RandomAccessRecord.SIZE, 0);

				currentRecordIndex += 1;

				// Lê dados do registro.
				record.Account = binaryInput.ReadInt32();
				record.FirstName = binaryInput.ReadInt32();
				record.LastName = binaryInput.ReadInt32();
				record.Balance = binaryInput.ReadInt32();
			}

			// Armazena valores de Record no array de string temporário.
			values = new string[]{
				record.Account.ToString(),
				record.FirstName.ToString(),
				record.LastName.ToString(),
				record.Balance.ToString()
			};

			// Copia valores do array de string nos valores de TextBox.
			SetTextBoxValues(values);
		}
		catch (IOException)
		{
			// Fecha FileStream se não existem registros no arquivo.
			fileInput.Close();
			binaryOutput.Close();

			openButton.Enabled = true;
			nextButton.Enabled = false;
			ClearTextBoxes();

			// Notifica o usuário se não houver registros no arquivo.
			MessageBox.Show("No more records in file", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

partial class ReadRandomAccessFile
{
	private Container? components = null;

	public ReadRandomAccessFile()
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
		Application.Run(new ReadRandomAccessFile());
	}
}
