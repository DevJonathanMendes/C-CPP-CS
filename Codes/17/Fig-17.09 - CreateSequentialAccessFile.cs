// Fig. 17.09: CreateSequentialAccessFile.cs
// Criando um arquivo de acesso sequencial.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; // Perigoso/Obsoleto, foi descontinuado.

// using BankLibrary;

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.

// Cole a classe Record (Fig-17.08 - Record) aqui.

partial class CreateLibraryForm : BankUIForm
{
	private Button saveButton;
	private Button enterButton;
	private Button exitButton;

	// O tipo BinaryFormatter é perigoso e não é recomendado para processamento de dados.Os aplicativos devem parar de usar BinaryFormatter o mais rápido possível,
	// mesmo que acreditem que os dados que estão processando são confiáveis.BinaryFormatter não é seguro e não pode ser tornado seguro.
	// Serializa Record em formato binário.
	private BinaryFormatter formatter = new BinaryFormatter();

	// Fluxo por meio do qual os dados serializáveis são gravados no arquivo.
	private FileStream output;

	private void InitializeComponent()
	{
		this.saveButton = new Button();
		this.enterButton = new Button();
		this.exitButton = new Button();

		// saveButton.
		this.saveButton.Name = "saveButton";
		this.saveButton.Text = "Save As";
		this.saveButton.AutoSize = true;
		this.saveButton.Location = new Point(10, 130);
		this.saveButton.Click += new EventHandler(this.saveButton_Click);

		// enterButton.
		this.enterButton.Name = "enterButton";
		this.enterButton.Text = "Enter";
		this.enterButton.AutoSize = true;
		this.enterButton.Location = new Point(90, 130);
		this.enterButton.Click += new EventHandler(this.enterButton_Click);

		// exitButton.
		this.exitButton.Name = "exitButton";
		this.exitButton.Text = "Exit";
		this.exitButton.AutoSize = true;
		this.exitButton.Location = new Point(170, 130);
		this.exitButton.Click += new EventHandler(this.exitButton_Click);

		// CreateLibraryForm.
		this.Controls.AddRange(new Control[]{
			this.saveButton, this.enterButton,
			this.exitButton
		});
		this.Name = "CreateLibraryForm";
		this.Text = "CreateLibraryForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void saveButton_Click(object? sender, EventArgs e)
	{
		// Cria caixa de diálogo permitindo que o usuário salve o arquivo.
		SaveFileDialog fileChooser = new SaveFileDialog();
		DialogResult result = fileChooser.ShowDialog();
		string fileName; // Nome do arquivo para salvar dados.

		// Permite que o usuário crie um arquivo.
		fileChooser.CheckFileExists = false;

		// Sai do manipulador de evento se o usuário clicou em "Cancelar".
		if (result == DialogResult.Cancel)
			return;

		// Obtém nome do arquivo especificado.
		fileName = fileChooser.FileName;

		// Mostra erro se o usuário especificou um arquivo inválido.
		if (fileName == "" || fileName == null)
			MessageBox.Show("Invalid File Name", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		else
		{
			// Salva o arquivo por meio de FileStream, se o usuário especificou um arquivo válido.
			try
			{
				// Abre o arquivo com acesso a gravação.
				output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

				// Desativa o botão Save As e ativa o botão Enter.
				saveButton.Enabled = false;
				enterButton.Enabled = true;
			}
			catch (FileNotFoundException)
			{
				// Notifica o usuário se o arquivo não existir.
				MessageBox.Show("File Does Not Exist", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	private void enterButton_Click(object? sender, EventArgs e)
	{
		// Armazena array de string com valores de TextBox.
		string[] values = GetTextBoxValues();

		// Registro contendo valores de TextBox para serializar.
		Record record = new Record();

		// Determina se o campo de conta TextBox está vazio.
		if (values[(int)TextBoxIndices.ACCOUNT] != "")
		{
			// Armazena valores de TextBox em Record e serializa Record.
			try
			{
				// Obtém o valor do número da conta de TextBox.
				int accountNumber = Int32.Parse(
					values[(int)TextBoxIndices.ACCOUNT]);

				// Determina se accountNumber é válido.
				if (accountNumber > 0)
				{
					// Armazena campos de TextBox em Record.
					record.Account = accountNumber;
					record.FirstName = values[(int)TextBoxIndices.FIRST];
					record.LastName = values[(int)TextBoxIndices.LAST];
					record.Balance = Double.Parse(values[(int)TextBoxIndices.BALANCE]);

					// Grava Record em FileStream (objeto serialize)
					formatter.Serialize(output, record);
				}
				else
				{
					// Notifica o usuário se o número da conta for inválido.
					MessageBox.Show("Invalid Account Number", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (SerializationException)
			{
				MessageBox.Show("Error Writing to File", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (FormatException)
			{
				MessageBox.Show("Invalid Format", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		ClearTextBoxes();
	}

	private void exitButton_Click(object? sender, EventArgs e)
	{
		// Determina se o arquivo existe.
		if (output != null)
		{
			// Fecha o arquivo.
			try
			{
				output.Close();
			}
			catch (IOException)
			{
				MessageBox.Show("Cannot close file", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		Application.Exit();
	}
}

partial class CreateLibraryForm
{
	private Container? components = null;

	public CreateLibraryForm()
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
		Application.Run(new CreateLibraryForm());
	}
}
