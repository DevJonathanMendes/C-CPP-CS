// Fig. 13.21: TreeViewDirectoryStructureTest.cs
// Usando TreeView para exibir estruturas de diretórios

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class TreeViewDirectoryStructureTest : Form
{
	private TreeView directoryTreeView;

	private void InitializeComponent()
	{
		this.directoryTreeView = new TreeView();

		// directoryTreeView.
		this.directoryTreeView.Name = "directoryTreeView";
		this.directoryTreeView.Size = new Size(450, 250);
		this.directoryTreeView.Location = new Point(10, 10);

		// TreeViewDirectoryStructureTest.
		this.Controls.Add(this.directoryTreeView);
		this.Name = "TreeViewDirectoryStructureTest";
		this.Text = "TreeViewDirectoryStructureTest";
		this.AutoSize = true;
		this.Load += new EventHandler(TreeViewDirectoryStructureTest_Load);
		this.ResumeLayout(false);
	}

	public void PopulateTreeView(string directoryValue, TreeNode parentNode)
	{
		string[] directoryArray = Directory.GetDirectories(directoryValue);

		try
		{
			if (directoryArray.Length != 0)
			{
				foreach (string directory in directoryArray)
				{
					TreeNode myNode = new TreeNode(directory);

					parentNode.Nodes.Add(myNode);

					PopulateTreeView(directory, myNode);
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
			parentNode.Nodes.Add("Access denied");
		}
	}

	private void TreeViewDirectoryStructureTest_Load(object? sender, EventArgs e)
	{
		directoryTreeView.Nodes.Add("C:\\");
		PopulateTreeView("C:\\", directoryTreeView.Nodes[0]);
	}
}

partial class TreeViewDirectoryStructureTest
{
	private Container? components = null;

	public TreeViewDirectoryStructureTest()
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
		Application.Run(new TreeViewDirectoryStructureTest());
	}
}
