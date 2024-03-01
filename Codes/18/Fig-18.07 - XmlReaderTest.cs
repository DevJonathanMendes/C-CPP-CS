// Fig. 18.07: XmlReaderTest.cs
// Lendo um documento XML.

using System;
using System.Xml;
using System.Windows.Forms;
using System.ComponentModel;

partial class XmlReaderTest : Form
{
	private RichTextBox outputTextBox;

	private void InitializeComponent()
	{
		this.outputTextBox = new RichTextBox();

		this.outputTextBox.Name = "outputTextBox";

		// XmlReaderTest.
		this.Controls.AddRange(new Control[]{
			this.outputTextBox
		});
		this.Name = "XmlReaderTest";
		this.Text = "XmlReaderTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public XmlReaderTest()
	{
		InitializeComponent();

		// Referência para "documento XML"
		XmlDocument document = new XmlDocument();
		document.Load("..\\example\\file.xml"); // Coloque um arquivo XML aqui.

		// Cria XmlNodeReader para o documento.
		XmlNodeReader reader = new XmlNodeReader(document);

		// Mostra o formulário antes que outputTextBox seja preenchida.
		this.Show();

		// A profundidade da árvore é -1, sem endentação.
		int depth = -1;

		// Exibe o conteúdo de cada nó.
		while (reader.Read())
		{
			switch (reader.NodeType)
			{
				case XmlNodeType.Element:
					depth++;
					TabOutput(depth);
					outputTextBox.Text += "<" + reader.Name + ">" + "\r\n";
					if (reader.IsEmptyElement)
						depth--;
					break;

				case XmlNodeType.Comment:
					TabOutput(depth);
					outputTextBox.Text += "<!--" + reader.Value + "-->\r\n";
					break;

				case XmlNodeType.Text:
					TabOutput(depth);
					outputTextBox.Text += "\t" + reader.Value + "\r\n";
					break;

				case XmlNodeType.XmlDeclaration:
					TabOutput(depth);
					outputTextBox.Text += "<?" + reader.Name + " " + reader.Value + " ?>\r\n";
					break;

				case XmlNodeType.EndElement:
					TabOutput(depth);
					outputTextBox.Text += "</" + reader.Name + ">\r\n";
					depth--;
					break;
			}
		}
	}

	private void TabOutput(int number)
	{
		for (int i = 0; i < number; i++)
			outputTextBox.Text += "\t";
	}
}

partial class XmlReaderTest
{
	private Container? components = null;

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
		Application.Run(new XmlReaderTest());
	}
}
