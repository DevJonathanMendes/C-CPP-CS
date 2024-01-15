// Fig. 17.11: ReadSequentialAccessFile.cs
// Lendo um arquivo de acesso sequencial.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// using BankLibrary;

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.

partial class ReadSequentialAccessFileForm : BankUIForm
{
	private Button openButton;
	private Button nextButton;

	// Fluxo por meio do qual os dados serializáveis são lidos do arquivo.
	private FileStream input;

	// Objeto para desserializar Record no formato binário.
	private BinaryFormatter reader = new BinaryFormatter();

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
		this.nextButton.Text = "Next Record";
		this.nextButton.AutoSize = true;
		this.nextButton.Location = new Point(100, 130);
		this.nextButton.Click += new EventHandler(this.nextButton_Click);

		// ReadSequentialAccessFileForm.
		this.Controls.AddRange(new Control[]{
			this.openButton, this.nextButton
		});
		this.Name = "ReadSequentialAccessFileForm";
		this.Text = "ReadSequentialAccessFileForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Chamado quando o usuário clica no botão Open File.
	private void openButton_Click(object? sender, System.EventArgs e)
	{
		// Cria uma caixa de diálogo permitindo que o usuário abra o arquivo.
		OpenFileDialog fileChooser = new OpenFileDialog();
		DialogResult result = fileChooser.ShowDialog();
		string fileName; // Nome de arquivo contendo dados.

		// Sai do manipulador de evento se o usuário clicou em Cancelar.
		if (result == DialogResult.Cancel)
			return;

		// Obtém nome do arquivo especificado.
		fileName = fileChooser.FileName;
		ClearTextBoxes();

		// Mostra erro se o usuário especificou um arquivo inválido.
		if (fileName == "" || fileName == null)
			MessageBox.Show("Invalid File Name", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		else
		{
			// Cria FileStream para obter acesso de leitura ao arquivo.
			input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

			// Ativa o botão de próximo registro (Next Record).
			nextButton.Enabled = true;
		}
	}

	// Chamado quando o usuário clica no botão Next Record.
	private void nextButton_Click(object? sender, EventArgs e)
	{
		// Desserializa Record e armazena dados em TextBox.
		try
		{
			// Obtém o próximo registro disponível no arquivo.
			Record record = (Record)reader.Deserialize(input);

			// Armazena valores de Record no array de string temporário.
			string[] values = new string[]{
				record.Account.ToString(),
				record.FirstName.ToString(),
				record.LastName.ToString(),
				record.Balance.ToString()
			};

			// Copia valores do array de string nos valores de TextBox.
			SetTextBoxValues(values);
		}
		catch (SerializationException)
		{
			// Fecha FileStream se não existem registros no arquivo.
			input.Close();

			// Ativa o botão Next Record.
			nextButton.Enabled = false;

			ClearTextBoxes();

			// Notifica o usuário se não houver registros no arquivo.
			MessageBox.Show("No more records in file", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

partial class ReadSequentialAccessFileForm
{
	private Container? components = null;

	public ReadSequentialAccessFileForm()
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
		Application.Run(new ReadSequentialAccessFileForm());
	}
}
