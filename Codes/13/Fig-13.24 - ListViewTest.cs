// Fig. 13.24: ListViewTest.cs
// Exibindo diretórios e seus conteúdos na ListView.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class ListViewTest : Form
{
	private Label currentLabel;
	private Label displayLabel;

	private ListView browserListView;

	private ImageList fileFolder;

	string currentDirectory = Directory.GetCurrentDirectory();

	private void InitializeComponent()
	{
		this.currentLabel = new Label();
		this.displayLabel = new Label();
		this.browserListView = new ListView();
		this.fileFolder = new ImageList();

		// currentLabel.
		this.currentLabel.Name = "currentLabel";
		this.currentLabel.Text = "";
		this.currentLabel.AutoSize = true;
		this.currentLabel.Location = new Point(10, 40);

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "";
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 10);

		// browserListView.
		this.browserListView.Name = "browserListView";
		this.browserListView.View = View.List;
		this.browserListView.Size = new Size(450, 250);
		this.browserListView.Location = new Point(10, 80);
		this.browserListView.Click += new EventHandler(browserListView_Click);

		// ListViewTest.
		this.Load += new EventHandler(ListViewTest_Load);
		this.Controls.AddRange(new Control[]{
			this.currentLabel, this.displayLabel,
			this.browserListView
		});
		this.Name = "ListViewTest";
		this.Text = "ListViewTest";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void browserListView_Click(object? sender, EventArgs e)
	{
		if (browserListView.SelectedItems.Count != 0)
		{
			if (browserListView.Items[0].Selected)
			{
				DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);

				if (directoryObject.Parent != null)
					LoadFilesInDirectory(directoryObject.Parent.FullName);
			}
		}
		else
		{
			string chosen = browserListView.SelectedItems[0].Text;

			if (Directory.Exists(currentDirectory + "\\" + chosen))
			{
				if (currentDirectory == "C:\\")
					LoadFilesInDirectory(currentDirectory + chosen);
				else
					LoadFilesInDirectory(currentDirectory + "\\" + chosen);
			}
		}

		displayLabel.Text = currentDirectory;
	}

	public void LoadFilesInDirectory(string currentDirectoryValue)
	{
		try
		{
			browserListView.Items.Clear();
			browserListView.Items.Add("Go UP One Level");

			currentDirectory = currentDirectoryValue;
			DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);

			DirectoryInfo[] directoryArray = newCurrentDirectory.GetDirectories();

			FileInfo[] fileArray = newCurrentDirectory.GetFiles();

			foreach (DirectoryInfo dir in directoryArray)
			{
				ListViewItem newDirectoryItem = browserListView.Items.Add(dir.Name);

				newDirectoryItem.ImageIndex = 0;
			}

			foreach (FileInfo file in fileArray)
			{
				ListViewItem newFileItem = browserListView.Items.Add(file.Name);

				newFileItem.ImageIndex = 1;
			}
		}
		catch (UnauthorizedAccessException exception)
		{
			MessageBox.Show(
			"Warning: Some fields may not bet" +
			"visible due to permission settings",
			"Attention", 0, MessageBoxIcon.Warning);
		}
	}

	private void ListViewTest_Load(object? sender, EventArgs e)
	{
		/*
		Image folderImage = Image.FromFile(currentDirectory + "\\images\\folder.bmp");

		Image fileImage = Image.FromFile(currentDirectory + "\\images\\file.bmp");

		fileFolder.Images.Add(folderImage);
		fileFolder.Images.Add(fileImage);
		*/

		LoadFilesInDirectory(currentDirectory);
		displayLabel.Text = currentDirectory;
	}
}

partial class ListViewTest
{
	private Container? components = null;

	public ListViewTest()
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
		Application.Run(new ListViewTest());
	}
}
