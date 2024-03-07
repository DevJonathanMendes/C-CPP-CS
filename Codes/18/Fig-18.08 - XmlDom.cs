// Fig. 18.08: XmlDom.cs
// Demonstra manipulação de árvores DOM.

using System;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.CodeDom.Compiler;

partial class XmlDom : Form
{
	private Button buildButton;
	private Button printButton;

	private TreeView xmlTreeView;
	private RichTextBox consoleTextBox;
	private Button resetButton;

	private XmlDocument source;
	private XmlDocument? copy;

	private TreeNode? tree;

	public XmlDom()
	{
		InitializeComponent();

		source = new XmlDocument();
		source.Load("..\\Codes\\18\\Fig-18.03 - letter.xml");

		copy = null;
		tree = null;
	}

	private void InitializeComponent()
	{
		this.buildButton = new Button();
		this.printButton = new Button();
		this.resetButton = new Button();
		this.xmlTreeView = new TreeView();
		this.consoleTextBox = new RichTextBox();

		// buildButton.
		this.buildButton.Name = "buildButton";
		this.buildButton.Text = "Build";
		this.buildButton.Location = new Point(10, 10);
		this.buildButton.Click += new EventHandler(this.buildButton_Click);

		// printButton.
		this.printButton.Name = "printButton";
		this.printButton.Text = "Print";
		this.printButton.Location = new Point(90, 10);
		this.printButton.Click += new EventHandler(this.printButton_Click);

		// resetButton.
		this.resetButton.Name = "resetButton";
		this.resetButton.Text = "Reset";
		this.resetButton.Location = new Point(170, 10);
		this.resetButton.Click += new EventHandler(this.resetButton_Click);

		// xmlTreeView.
		this.xmlTreeView.Name = "xmlTreeView";
		this.xmlTreeView.Text = "HELLO";
		this.xmlTreeView.Location = new Point(10, 40);
		this.xmlTreeView.Size = new Size(300, 400);

		// consoleTextBox.
		this.consoleTextBox.Name = "consoleTextBox";
		this.consoleTextBox.Location = new Point(10, 450);
		this.consoleTextBox.Size = new Size(200, 300);

		// XmlDom.
		this.Controls.AddRange(new Control[]{
			this.buildButton, this.printButton,
			this.xmlTreeView, this.consoleTextBox,
			this.resetButton
		});
		this.Name = "XmlDom";
		this.Text = "XmlDom";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void buildButton_Click(object? sender, EventArgs e)
	{
		// Determina se copu já foi construído.
		if (copy != null)
			return; // Documento já existe.

		copy = new XmlDocument();
		tree = new TreeNode();

		tree.Text = source.Name;
		xmlTreeView.Nodes.Add(tree);

		BuildTree(source, copy, tree);

		printButton.Enabled = true;
		resetButton.Enabled = true;
	}

	private void printButton_Click(object? sender, EventArgs e)
	{
		if (copy == null)
			return;

		// Cria arquivo XML temporário.
		TempFileCollection file = new TempFileCollection();

		file.AddExtension("xml", false);
		string[] filename = new string[10];
		file.CopyTo(filename, 0);

		// Obsoleto, descontinuado.
		// XmlTextWrite writer = new XmlTextWrite(filename[0], Text.Encoding.UTF8);
		XmlWriter writer = XmlWriter.Create(filename[0]);

		copy.WriteTo(writer);
		writer.Close();

		XmlTextReader reader = new XmlTextReader(filename[0]);

		while (reader.Read())
		{
			if (reader.NodeType == XmlNodeType.EndElement)
				consoleTextBox.Text += "/";
			if (reader.Name != String.Empty)
				consoleTextBox.Text += reader.Name + "\r\n";
			if (reader.Value != String.Empty)
				consoleTextBox.Text += "\t" + reader.Value + "\r\n";
		}

		reader.Close();
	}

	private void resetButton_Click(object? sender, EventArgs e)
	{
		if (tree == null)
			xmlTreeView.Nodes.Remove(tree);

		xmlTreeView.Refresh();

		copy = null;
		tree = null;

		consoleTextBox.Text = "";

		printButton.Enabled = false;
		resetButton.Enabled = false;
	}

	private void BuildTree(XmlNode xmlSourceNode, XmlNode document, TreeNode treeNode)
	{
		XmlNodeReader nodeReader = new XmlNodeReader(xmlSourceNode);
		XmlNode? currentNode = null;
		TreeNode newNode = new TreeNode();
		XmlNodeType modifiedNodeType;

		while (nodeReader.Read())
		{
			modifiedNodeType = nodeReader.NodeType;

			if (modifiedNodeType == XmlNodeType.EndElement)
				modifiedNodeType = XmlNodeType.Element;

			currentNode = copy.CreateNode(modifiedNodeType,
				nodeReader.Name, nodeReader.NamespaceURI);

			switch (nodeReader.NodeType)
			{
				case XmlNodeType.Text:
					newNode.Text = nodeReader.Value;
					treeNode.Nodes.Add(newNode);

					((XmlText)currentNode).AppendData(nodeReader.Value);
					document.AppendChild(currentNode);
					break;

				case XmlNodeType.EndElement:
					document = document.ParentNode;
					treeNode = treeNode.Parent;
					break;

				case XmlNodeType.Element:
					if (!nodeReader.IsEmptyElement)
					{
						newNode.Text = nodeReader.Name;
						treeNode.Nodes.Add(newNode);

						treeNode = newNode;

						document.AppendChild(currentNode);
						document = document.LastChild;
					}
					else
					{
						newNode.Text = nodeReader.NodeType.ToString();

						treeNode.Nodes.Add(newNode);
						document.AppendChild(currentNode);
					}

					break;

				default:
					newNode.Text = nodeReader.NodeType.ToString();
					treeNode.Nodes.Add(newNode);
					document.AppendChild(currentNode);
					break;
			}

			newNode = new TreeNode();
		}
		xmlTreeView.ExpandAll();
		xmlTreeView.Refresh();
	}
}

partial class XmlDom
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
		Application.Run(new XmlDom());
	}
}
