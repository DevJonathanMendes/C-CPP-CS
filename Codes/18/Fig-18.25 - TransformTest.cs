// Fig. 18.25: TransformTest.cs
// Aplicando uma folha de estilos em um documento XML.

using System;
using System.IO; // Contém classes de fluxo.
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

using System.Xml;
using System.Xml.Xsl; // Contém classes de folhas de estilos.
using System.Xml.XPath; // Contém classes de XPath.

partial class TransformTest : Form
{
	private RichTextBox consoleRichTextBox;
	private Button transformButton;

	private XmlDocument document; // Raiz do documento Xml.
	private XPathNavigator navigator; // Navega pelo documento.
	private XslTransform transformer; // Transforma o documento.
	private StringWriter output; // Exibe o documento.

	private void InitializeComponent()
	{
		this.transformButton = new Button();
		this.consoleRichTextBox = new RichTextBox();

		// transformButton.
		this.transformButton.Name = "transformButton";
		this.transformButton.Text = "Transform XML";
		this.transformButton.Location = new Point(10, 10);
		this.transformButton.Size = new Size(200, this.transformButton.Size.Height);
		this.transformButton.Click += new EventHandler(this.transformButton_Click);

		// consoleRichTextBox.
		this.consoleRichTextBox.Name = "consoleRichTextBox";
		this.consoleRichTextBox.Text = "";
		this.consoleRichTextBox.Location = new Point(10, 40);
		this.consoleRichTextBox.Size = new Size(200, 300);

		// Carrega dados XML.
		// document = new XmlDocument();
		// document.Load("..\\..\\file.xml");

		// Cria navegador.
		// navigator = document.CreateNavigator();

		// Carrega a folha de estilos.
		// transformer = new XslTransform();
		// transformer.Load("..\\..\\file.xsl");

		// TransformTest.
		this.Controls.AddRange(new Control[]{
			this.transformButton, this.consoleRichTextBox
		});
		this.Name = "TransformTest";
		this.Text = "TransformTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void transformButton_Click(object? sender, EventArgs e)
	{
		// Transforma dados XML.
		output = new StringWriter();
		transformer.Transform(navigator, null, output);

		// Exibe a transformação na caixa de texto.
		consoleRichTextBox.Text = output.ToString();

		// Grava o resultado da transformação no disco.
		FileStream stream = new FileStream("..\\..\\file.html", FileMode.Create);
		StreamWriter write = new StreamWriter(stream);
		write.Write(output.ToString());

		// Fecha os fluxos.
		write.Close();
		output.Close();
	}
}

partial class TransformTest
{
	private Container? components = null;

	public TransformTest()
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
		Application.Run(new TransformTest());
	}
}
