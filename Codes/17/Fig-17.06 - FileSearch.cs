// Fig. 17.6: FileSearch.cs
// Usando expressões regulares para determinar tipos de arquivos.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

partial class FileSearchForm : Form
{
	private Label directionsLabel;
	private Label directoryLabel;
	private Button searchButton;
	private TextBox inputTextBox;
	private RichTextBox outputTextBox;

	string currentDirectory = Directory.GetCurrentDirectory();
	string[] directoryList;
	string[] fileArray;

	// Armazena as extensões encontradas e o número encontrado.
	NameValueCollection found = new NameValueCollection();

	private void InitializeComponent()
	{
		this.directionsLabel = new Label();
		this.directoryLabel = new Label();
		this.searchButton = new Button();
		this.inputTextBox = new TextBox();
		this.outputTextBox = new RichTextBox();

		// directionsLabel.
		this.directionsLabel.Name = "directionsLabel";
		this.directionsLabel.Text = "";
		this.directionsLabel.AutoSize = true;
		this.directionsLabel.Location = new Point(10, 10);

		// directoryLabel.
		this.directoryLabel.Name = "directoryLabel";
		this.directoryLabel.Text = "Enter a Path to Search";
		this.directoryLabel.AutoSize = true;
		this.directoryLabel.Location = new Point(10, 60);

		// inputTextBox.
		this.inputTextBox.Name = "inputTextBox";
		this.inputTextBox.Text = "";
		this.inputTextBox.TabIndex = 1;
		this.inputTextBox.KeyDown += new KeyEventHandler(this.inputTextBox_KeyDown);
		this.inputTextBox.Location = new Point(10, 80);

		// searchButton.
		this.searchButton.Name = "searchButton";
		this.searchButton.Text = "Search Directory";
		this.searchButton.AutoSize = true;
		this.searchButton.Location = new Point(10, 110);
		this.searchButton.Click += new EventHandler(this.searchButton_Click);

		// outputTextBox.
		this.outputTextBox.Name = "outputTextBox";
		this.outputTextBox.Text = "";
		this.outputTextBox.TabIndex = 2;
		this.outputTextBox.ReadOnly = true;
		this.outputTextBox.Size = new Size(200, 400);
		this.outputTextBox.Location = new Point(10, 140);

		// FileSearchForm.
		this.Controls.AddRange(new Control[]{
			this.directionsLabel, this.outputTextBox,
			this.inputTextBox, this.searchButton,
			this.directoryLabel
});
		this.Name = "FileSearchForm";
		this.Text = "FileSearchForm";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Chamado quando o usuário digita na caixa de texto.
	private void inputTextBox_KeyDown(object? sender, KeyEventArgs e)
	{
		// Determina se o usuário pressionou a tecla Enter.
		if (e.KeyCode == Keys.Enter)
			this.searchButton_Click(sender, e);
	}

	// Chamado quando o usuário clica no botão "Search Directory".
	private void searchButton_Click(object? sender, EventArgs e)
	{
		// Determina se fileName é um arquivo.
		if (inputTextBox.Text != "")
		{
			// Verifica se a entrada do usuário é um nome de diretório válido.
			if (Directory.Exists(inputTextBox.Text))
			{
				currentDirectory = inputTextBox.Text;

				// Reconfigura a caixa de texto de entrada e atualiza a tela.
				directionsLabel.Text = "Current Directory:" + "\r\n" + currentDirectory;
			}
			else
			{
				// Mostra a caixa de texto de entrada e atualiza a tela.
				MessageBox.Show("Invalid Directory", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Limpa as caixas de texto.
		inputTextBox.Clear();
		outputTextBox.Clear();

		// Pesquisa o diretório.
		this.SearchDirectory(currentDirectory);

		// Pesquisa e imprime os resultados.
		foreach (string current in found)
		{
			outputTextBox.Text += " Found " +
				found[current] + " " + current + " files.\r\n";
		}

		// Limpa saída para nova pesquisa.
		found.Clear();
	}

	private void SearchDirectory(string currentDirectory)
	{
		// Pesquisa diretório.
		try
		{
			string fileName = "";

			// Expressão regular para extensões correspondentes ao padrão.
			Regex regularExpression = new Regex(
				"[a-zA-Z0-0]+\\.(?<extension>\\w+)");

			// Armazena o resultado da correspondência da expressão regular.
			Match matchResult;

			string fileExtension; // Contém extensões de arquivo.

			// Número de arquivos no diretório com extensão dada.
			int extensionCount;

			// Obtém diretórios.
			directoryList = Directory.GetDirectories(currentDirectory);

			// Obtém lista de arquivos no diretório atual.
			fileArray = Directory.GetFiles(currentDirectory);

			// Faz iterações na lista de arquivos.
			foreach (string myFile in fileArray)
			{
				// Remove caminho de diretório do nome de arquivo.
				fileName = myFile.Substring(myFile.LastIndexOf("\\") + 1);

				// Obtém resultado da pesquisa da expressão regular.
				matchResult = regularExpression.Match(fileName);

				// Verifica a correspondência.
				if (matchResult.Success)
					fileExtension = matchResult.Result("${extension}");
				else
					fileExtension = "[no extension]";

				// Armazena valor do container.
				if (found[fileExtension] == null)
					found.Add(fileExtension, "1");
				else
				{
					extensionCount = Int32.Parse(found[fileExtension]) + 1;

					found[fileExtension] = extensionCount.ToString();
				}

				// Procura arquivos de backup(.bak).
				if (fileExtension == "bak")
				{
					// Avisa o usuário para excluir arquivo (.bak).
					DialogResult result =
						MessageBox.Show("Found backup file " +
						fileName + ". Delete?", "Delete Backup",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);

					// Exclui arquivo se o usuário clicou em "yes".
					if (result == DialogResult.Yes)
					{
						File.Delete(myFile);

						extensionCount = Int32.Parse(found["bak"]) - 1;

						found["bak"] = extensionCount.ToString();
					}
				}
			}

			// Chama recursiva para procurar arquivo no subdiretório.
			foreach (string myDirectory in directoryList)
				SearchDirectory(myDirectory);
		}

		// Trata a exceção se os arquivos não tiverem acesso autorizado.
		catch (UnauthorizedAccessException)
		{
			MessageBox.Show("Some file may not be visible" +
				" due to permission settings", "Warning",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

partial class FileSearchForm
{
	private Container? components = null;

	public FileSearchForm()
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
		Application.Run(new FileSearchForm());
	}
}
