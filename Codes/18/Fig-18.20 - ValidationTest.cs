// Fig. 18.20: ValidationTest.cs
// Validando documentos XML em relação a esquemas.

using System;
using System.Xml;
using System.Drawing;
using System.Xml.Schema; // Contém classes de esquema.
using System.Windows.Forms;
using System.ComponentModel;

// Determina a validade do esquema do documento XML.
partial class ValidationTest : Form
{
	private ComboBox? filesComboBox;
	private Button? validateButton;
	private Label? consoleLabel;

	private XmlSchemaCollection schemas; // Esquemas.
	private bool valid; // Resultado da validação.

	private void InitializeComponent()
	{
		this.filesComboBox = new ComboBox();
		this.validateButton = new Button();
		this.consoleLabel = new Label();

		// filesComboBox.
		this.filesComboBox.Name = "filesComboBox";
		this.filesComboBox.Text = "filesComboBox";
		this.filesComboBox.Items.AddRange(new object[] { "book.xsd" });
		this.filesComboBox.Size = new Size(150, 150);
		this.filesComboBox.Location = new Point(10, 10);

		this.validateButton.Name = "validateButton";
		this.validateButton.Text = "Validate";
		this.validateButton.AutoSize = true;
		this.validateButton.Location = new Point(10, 40);
		this.validateButton.Click += new EventHandler(this.validateButton_Click);

		this.consoleLabel.Name = "consoleLabel";
		this.consoleLabel.Text = "consoleLabel";
		this.consoleLabel.Location = new Point(10, 70);
		this.consoleLabel.AutoSize = true;

		// ValidationTest.
		this.Controls.AddRange(new Control[] {
			this.filesComboBox, this.validateButton,
			this.consoleLabel
		});
		this.Name = "ValidationTest";
		this.Text = "ValidationTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Manipula o evento Click de validateButton.
	private void validateButton_Click(object? sender, EventArgs e)
	{
		// Obtém documento XML.
		XmlTextReader reader = new XmlTextReader(this.filesComboBox.Text);

		// Obtém validador.
		XmlValidatingReader validator = new XmlValidatingReader(reader);

		// Atribui o(s) esquemas(s).
		validator.Schemas.Add(schemas);

		// Configura tipo de validação.
		validator.ValidationType = ValidationType.Auto;

		// Registra manipulador de evento para erro(s) de validação.
		validator.ValidationEventHandler += new ValidationEventHandler(ValidationError);

		// Valida o documento nó por nó.
		while (validator.Read()) ; // Corpo vazio.

		// Verifica o resultado da validação.
		if (valid)
			consoleLabel.Text = "Document is valid";

		valid = true; // Reconfigura a variável.

		// Fecha o fluxo leitor.
		validator.Close();
	}

	// Manipulador para erro de validação.
	private void ValidationError(object sender, ValidationEventArgs arguments)
	{
		consoleLabel.Text = arguments.Message;
		valid = false; // A validação falhou.
	}
}

partial class ValidationTest
{
	private Container? components = null;

	public ValidationTest()
	{
		InitializeComponent();

		valid = true; // Pressupõe que o documento é válido

		// Obtém esquema(s) para validação.
		schemas = new XmlSchemaCollection();
		schemas.Add("book", "book.xdr");
		schemas.Add("http://deitel.com/booklist", "book.xsd");
	}

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
		Application.Run(new ValidationTest());
	}
}
