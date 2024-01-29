// Fig. 17.16: WriteRandomAccessFile.cs
// Grava dados em um arquivo de acesso aleatório.

using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;

// using BankLibrary;

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.

// Cole a classe RandomAccessRecord (Fig-17.14 - RandomAccessRecord) aqui.

partial class Form1 : Form
{
	private Button openButton;
	private Button enterButton;

	// Número de RandomAccessRecord a gravar no disco.
	private const int NUMBER_OF_RECORDS = 100;

	// Fluxo por meio do qual os dados são gravados no arquivo.
	private FIleStream fileOutput;

	// Fluxo para gravar bytes no arquivo.
	private BinaryWriter binaryOutput;

	private void InitializeComponent()
	{
		this.openButton = new Button();
		this.enterButton = new Button();

		// openButton.
		this.openButton.Name = "openButton";
		this.openButton.Text = "Open File";
		this.openButton.AutoSize = true;
		this.openButton.Location = new Point(10, 130);
		this.openButton.Click += new EventHandler(this.openButton_Click);

		// enterButton.
		this.enterButton.Name = "enterButton";
		this.enterButton.Text = "Enter";
		this.enterButton.AutoSize = true;
		this.enterButton.Location = new Point(90, 130);
		this.enterButton.Click += new EventHandler(this.enterButton_Click);

		// Form1.
		this.Controls.AddRange(new Control[]{
			this.openButton, this.enterButton
		});
		this.Name = "Form1";
		this.Text = "Form1";
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
			try
			{
				// Cria FileStream para conter registros.
				fileOutput = new FileStream(fileName, FileMode.Open, FileAccess.Write);

				//Cria objeto para gravar bytes no arquivos.
				binaryOutput = new BinaryWriter(fileOutput);

				// Desativa o botão Open FIle e ativa o botão Enter.
				openButton.Enabled = false;
				enterButton.Enabled = true;
			}
			catch (IOException)
			{
				MessageBox.Show("File Does Not Exits", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	// Chamado quando o usuário clica no botão Enter.
	private void enterButton_Click(object? sender, EventArgs e)
	{
		// Armazena array de string com valores de TextBox.
		string[] values = GetTextBoxValues();

		// Determina se o campo de conta TextBox está vazio.
		if (values[(int)TextBoxIndices.ACCOUNT] != "")
		{
			// Grava registro no arquivo, na posição apropriada.
			try
			{
				// Obtém o valor do número da conta de TextBox.
				int accountNumber = Int32.Parse(
					values[(int)TextBoxIndices.ACCOUNT]);

				// Determina se accountNumber é válido.
				if (accountNumber > 0 && accountNumber <= NUMBER_OF_RECORDS)
				{
					// Move o ponteiro de posição no arquivo.
					fileOutput.Seek((accountNumber - 1) *
						RandomAccessRecord.SIZE, SeekOrigin.Begin);

					// Grava dados no arquivo.
					binaryOutput.Write(accountNumber);
					binaryOutput.Write(values[(int)TextBoxIndices.FIRST]);
					binaryOutput.Write(values[(int)TextBoxIndices.LAST]);
					binaryOutput.Write(Double.Parse(values[(int)TextBoxIndices.BALANCE]));
				}
				else
				{
					// Notifica o usuário se o número da conta for inválido.
					MessageBox.Show("Invalid Account Number", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			// Manipula exceção de formato numérico.
			catch (FormatException)
			{
				// Notifica o usuário se ocorrer erro ao formatar números
				MessageBox.Show("Invalid Balance", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		ClearTextBoxes();
	}
}

partial class Form1
{
	private Container? components = null;

	public Form1()
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
		Application.Run(new Form1());
	}
}
