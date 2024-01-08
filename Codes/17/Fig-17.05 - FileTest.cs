// Fig. 17.5: FileTest.cs
// Usando as classes File e Directory.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

partial class FileTestForm : Form
{
	private Label directionsLabel;

	private TextBox inputTextBox;
	private RichTextBox outputTextBox;

	private void InitializeComponent()
	{
		this.directionsLabel = new Label();
		this.inputTextBox = new TextBox();
		this.outputTextBox = new RichTextBox();

		// directionsLabel.
		this.directionsLabel.Name = "directionsLabel";
		this.directionsLabel.Text = "Enter file or directory";
		this.directionsLabel.AutoSize = true;
		this.directionsLabel.Location = new Point(10, 10);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.TabIndex = 1;
		this.inputTextBox.KeyDown += new KeyEventHandler(this.inputTextBox_KeyDown);
		this.inputTextBox.Location = new Point(10, 40);

		// outputTextBox.
		this.outputTextBox.Name = "outputTextBox";
		this.outputTextBox.Text = "";
		this.outputTextBox.TabIndex = 2;
		this.outputTextBox.ReadOnly = true;
		this.outputTextBox.Size = new Size(200, 400);
		this.outputTextBox.Location = new Point(10, 80);

		// FileTestForm.
		this.Controls.AddRange(new Control[]{
			this.directionsLabel, this.outputTextBox,
			this.inputTextBox
		});
		this.Name = "FileTestForm";
		this.Text = "FileTestForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Chamado quando o usuário pressiona uma tecla.
	private void inputTextBox_KeyDown(object? sender, KeyEventArgs e)
	{
		// Determina se o usuário pressionou a tecla Enter.
		if (e.KeyCode == Keys.Enter)
		{
			string fileName; // Nome de arquivo ou diretório.

			// Obtém arquivo ou diretório especificado pelo usuário.
			fileName = inputTextBox.Text;

			// Determina se fileName é um arquivo.
			if (File.Exists(fileName))
			{
				// Obtém data de criação do arquivo, a data de modificação etc.
				outputTextBox.Text = GetInformation(fileName);

				// Exibe o conteúdo do arquivo por meio de StreamReader
				try
				{
					// Obtém o leitor e o conteúdo do arquivo.
					StreamReader stream = new StreamReader(fileName);
					outputTextBox.Text += stream.ReadToEnd();
				}
				// Trata a exceção se StreamReader estiver indisponível.
				catch (IOException)
				{
					MessageBox.Show("File Error", "File Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// Determina se fileName é um diretório.
			else if (Directory.Exists(fileName))
			{
				// Array de diretórios.
				string[] directoryList;

				outputTextBox.Text = GetInformation(fileName);

				// Obtém lista de arquivos/diretório do diretório especificado.
				directoryList = Directory.GetDirectories(fileName);

				outputTextBox.Text += "\r\n\r\nDirectory contents:\r\n";

				// Produz o conteúdo de directoryList na saída.
				for (int i = 0; i < directoryList.Length; i++)
					outputTextBox.Text += directoryList[i] + "\r\n";
			}
			else
			{
				// Notifica que não existe nenhum arquivo ou diretório com o nome dado.
				MessageBox.Show(inputTextBox.Text + " does not exist", "File Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	private string GetInformation(string fileName)
	{
		// Saída dizendo que o arquivo ou diretório existe.
		string information = fileName + " exists\r\n\r\n";

		// Saída dizendo quando o arquivo ou diretório foi criado.
		information += "Created: " + File.GetCreationTime(fileName) + "\r\n";

		// Saída dizendo quando o arquivo ou diretório foi acessado pela última vez.
		information += "Last accessed: " +
			File.GetLastAccessTime(fileName) + "\r\n\r\n";

		return information;
	}
}

partial class FileTestForm
{
	private Container? components = null;

	public FileTestForm()
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
		Application.Run(new FileTestForm());
	}
}
