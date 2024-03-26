// Fig. 18.09: PathNavigator.cs
// Demonstra a classe XPathNavigator.

using System;
using System.Drawing;
using System.Xml.XPath;
using System.Windows.Forms;
using System.ComponentModel;

partial class PathNavigator : Form
{
	private GroupBox navigatorBox;
	private Button previousButton;
	private Button parentButton;
	private Button firstChildButton;
	private Button nextButton;

	private GroupBox locateBox;
	private Button selectButton;
	private TextBox selectTreeViewer;
	private ComboBox selectComboBox;

	private TreeView pathTreeViewer;

	// Navegador para percorrer o documento.
	private XPathNavigator xpath;

	// Referência documento para uso por XPathNavigator.
	private XPathDocument document;

	// Referência a lista TreeNode usada por TreeView.
	private TreeNode tree;

	private void InitializeComponent()
	{
		this.locateBox = new GroupBox();
		this.selectButton = new Button();
		this.selectTreeViewer = new TextBox();
		this.selectComboBox = new ComboBox();

		this.navigatorBox = new GroupBox();
		this.previousButton = new Button();
		this.parentButton = new Button();
		this.firstChildButton = new Button();
		this.nextButton = new Button();

		this.pathTreeViewer = new TreeView();

		// locateBox.
		this.locateBox.Name = "locateBox";
		this.locateBox.Text = "Locate Element";
		this.locateBox.AutoSize = true;
		this.locateBox.Location = new Point(10, 10);
		this.locateBox.Controls.AddRange(new Control[]{
			this.selectButton, this.selectTreeViewer,
			this.selectComboBox
		});

		// selectButton.
		this.selectButton.Name = "selectButton";
		this.selectButton.Text = "Select";
		this.selectButton.Location = new Point(10, 20);
		this.selectButton.Click += new EventHandler(selectButton_Click);

		// selectComboBox.
		this.selectComboBox.Name = "selectComboBox";
		this.selectComboBox.Text = "Select";
		this.selectComboBox.Location = new Point(90, 20);

		// selectTreeViewer.
		this.selectTreeViewer.Name = "selectTreeViewer";
		this.selectTreeViewer.Text = "selectTreeViewer";
		this.selectTreeViewer.Location = new Point(10, 50);

		// navigatorBox.
		this.navigatorBox.Name = "navigatorBox";
		this.navigatorBox.Location = new Point(10, 110);
		this.navigatorBox.Controls.AddRange(new Control[]{
			this.previousButton, this.parentButton,
			this.firstChildButton, this.nextButton
		});

		// previousButton.
		this.previousButton.Name = "previousButton";
		this.previousButton.Text = "Previous";
		this.previousButton.Location = new Point(60, 21);
		this.previousButton.Click += new EventHandler(previousButton_Click);

		// parentButton.
		this.parentButton.Name = "parentButton";
		this.parentButton.Text = "Parent";
		this.parentButton.Location = new Point(22, 43);
		this.parentButton.Click += new EventHandler(parentButton_Click);

		// firstChildButton.
		this.firstChildButton.Name = "firstChildButton";
		this.firstChildButton.Text = "First Child";
		this.firstChildButton.Location = new Point(96, 43);
		this.firstChildButton.Click += new EventHandler(firstChildButton_Click);

		// nextButton.
		this.nextButton.Name = "nextButton";
		this.nextButton.Text = "Next";
		this.nextButton.Location = new Point(60, 65);
		this.nextButton.Click += new EventHandler(nextButton_Click);

		// pathTreeViewer.
		this.pathTreeViewer.Name = "pathTreeViewer";
		this.pathTreeViewer.Size = new Size(200, 300);
		this.pathTreeViewer.Location = new Point(10, 210);

		// PathNavigator.
		this.Controls.AddRange(new Control[]{
			this.locateBox, this.navigatorBox,
			this.pathTreeViewer
		 });
		this.Name = "PathNavigator";
		this.Text = "PathNavigator";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Percorre o primeiro filho.
	private void firstChildButton_Click(object? sender, EventArgs e)
	{
		TreeNode newTreeNode;

		// Move para o primeiro filho.
		if (xpath.MoveToFirstChild())
		{
			newTreeNode = new TreeNode(); // Cria o novo nó.

			DetermineType(newTreeNode, xpath);

			tree.Nodes.Add(newTreeNode);
			tree = newTreeNode;

			pathTreeViewer.ExpandAll();
			pathTreeViewer.Refresh();
			pathTreeViewer.SelectedNode = tree;
		}
		else
		{
			MessageBox.Show("Current Node has no children.", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Percorre o progenitor do nó no evento Click parentButton.
	private void parentButton_Click(object? sender, EventArgs e)
	{
		// Mode para o progenitor.
		if (xpath.MoveToParent())
		{
			tree = tree.Parent;

			// Obtém o número de nós filhos, não incluindo subárvores.
			int count = tree.GetNodeCount(false);

			// Remove todos os filhos.
			tree.Nodes.Clear();

			// Atualiza TreeView.
			pathTreeViewer.ExpandAll();
			pathTreeViewer.Refresh();
			pathTreeViewer.SelectedNode = tree;
		}
		else
		{
			MessageBox.Show("Current Node has no parent.", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Encontra o próximo irmão no evento Click nextButton.
	private void nextButton_Click(object? sender, EventArgs e)
	{
		TreeNode newTreeNode = null, newNode = null;

		// Mode para o próximo irmão.
		if (xpath.MoveToNext())
		{
			newTreeNode = tree.Parent;

			newNode = new TreeNode(); // Cria novo nó.
			DetermineType(newNode, xpath);
			newTreeNode.Nodes.Add(newNode);

			// Configura a posição atual para exibição.
			tree = newNode;

			// Atualiza TreeView.
			pathTreeViewer.ExpandAll();
			pathTreeViewer.Refresh();
			pathTreeViewer.SelectedNode = tree;
		}
		else // O nó não tem mais irmão.
		{
			MessageBox.Show("Current Node is last sibling.", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Obtém irmão anterior no evento Click previousButton.
	private void previousButton_Click(object? sender, EventArgs e)
	{
		TreeNode parentTreeNode = null;

		// Mode para o próximo irmão.
		if (xpath.MoveToPrevious())
		{
			parentTreeNode = tree.Parent;

			// Exclui o nó atual.
			parentTreeNode.Nodes.Remove(tree);

			// Move para o nó anterior.
			tree = parentTreeNode.LastNode;

			// Atualiza TreeView.
			pathTreeViewer.ExpandAll();
			pathTreeViewer.Refresh();
			pathTreeViewer.SelectedNode = tree;
		}
		else // O nó não tem mais irmão.
		{
			MessageBox.Show("Current Node is first sibling.", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Processa o evento CLick selectButton.
	private void selectButton_Click(object? sender, EventArgs e)
	{
		XPathNodeIterator iterator; // Permite percorrer os nós.

		try
		{
			iterator = xpath.Select(selectComboBox.Text);
			DisplayIterator(iterator); // Imprime a seleção.
		}
		catch (ArgumentException argumentException) // Captura expressões inválidas.
		{
			MessageBox.Show(argumentException.Message, "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	// Imprime valores de XpathNodeIterator.
	private void DisplayIterator(XPathNodeIterator iterator)
	{
		selectTreeViewer.Text = "";

		// Imprime os valores do nó selecionado.
		while (iterator.MoveNext())
		{
			selectTreeViewer.Text += iterator.Current.Value.Trim() + "\r\n";
		}
	}

	// Determina se TreeNode deve exibir o nome ou valor do nó atual.
	private void DetermineType(TreeNode node, XPathNavigator xPath)
	{
		switch (xPath.NodeType)
		{
			// Se for Element, obtém seu nome.
			case XPathNodeType.Element:

				// Obtém o nome do nó atual e remove espaços em branco.
				node.Text = xPath.Name.Trim();
				break;

			// Obtém valores de nó.
			default:
				// Obtém valor do nó atual e remove espaços em branco.
				node.Text = xPath.Value.Trim();
				break;
		}
	}
}

partial class PathNavigator
{
	private Container? components = null;

	public PathNavigator()
	{
		InitializeComponent();

		// Carrega o documento XML.
		document = new XPathDocument("..\\Codes\\18\\Fig-18.05 - defaultnamespace.xml");

		// Cria o navegador.
		xpath = document.CreateNavigator();

		// Cria nó raiz para TreeNodes.
		tree = new TreeNode();

		tree.Text = xpath.NodeType.ToString();  // #root.
		pathTreeViewer.Nodes.Add(tree);         // Adiciona árvore.

		// Atualiza a TreeView.
		pathTreeViewer.ExpandAll();
		pathTreeViewer.Refresh();
		pathTreeViewer.SelectedNode = tree;     // Realça a raiz.
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
		Application.Run(new PathNavigator());
	}
}
