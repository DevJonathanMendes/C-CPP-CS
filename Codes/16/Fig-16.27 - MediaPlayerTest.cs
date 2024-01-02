// Fig. 16.27: MediaPlayerTest.cs
// Demonstra o controle Windows Media Player.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class MediaPlayer : Form
{
	private MenuStrip applicationMenu;
	private ToolStripMenuItem fileItem;
	private ToolStripMenuItem openItem;
	private ToolStripMenuItem exitItem;
	private ToolStripMenuItem aboutItem;
	private ToolStripMenuItem aboutMessageItem;
	private OpenFileDialog openMediaFileDialog;
	private AxMediaPlayer.AxMediaPlayer player;

	private void InitializeComponent()
	{
		this.applicationMenu = new MenuStrip();
		this.fileItem = new ToolStripMenuItem();
		this.openItem = new ToolStripMenuItem();
		this.exitItem = new ToolStripMenuItem();
		this.aboutItem = new ToolStripMenuItem();
		this.aboutMessageItem = new ToolStripMenuItem();
		this.openMediaFileDialog = new OpenFileDialog();

		// applicationMenu.
		this.applicationMenu.Name = "applicationMenu";
		this.applicationMenu.Items.AddRange(new ToolStripItem[] {
			this.fileItem, this.aboutItem
		});

		// fileItem.
		this.fileItem.Name = "fileItem";
		this.fileItem.Text = "File";
		this.fileItem.DropDownItems.AddRange(new ToolStripItem[] {
			this.openItem, this.exitItem
		});

		// openItem.
		this.openItem.Name = "openItem";
		this.openItem.Text = "Open";
		this.openItem.Click += new EventHandler(this.openItem_Click);

		// exitItem.
		this.exitItem.Name = "exitItem";
		this.exitItem.Text = "Exit";
		this.exitItem.Click += new EventHandler(this.exitItem_Click);

		// aboutItem.
		this.aboutItem.Name = "aboutItem";
		this.aboutItem.Text = "About";
		this.aboutItem.Click += new EventHandler(this.aboutMessageItem_Click);

		// MediaPlayer.
		this.Controls.Add(this.applicationMenu);
		this.Name = "MediaPlayer";
		this.Text = "MediaPlayer";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	// Abre novo arquivo de mídia no Windows Media Player.
	private void openItem_Click(object? sender, EventArgs e)
	{
		openMediaFileDialog.ShowDialog();
		player.FileName = openMediaFileDialog.FileName;

		// Ajusta o tamanho do controle Media Player e o formulário de acordo com o tamanho da imagem.
		player.Size = new Size(player.ImageSourceWidth, player.ImageSourceHeight);

		this.Size = new Size(player.Size.Width + 20, player.Size.Height + 60);
	}

	private void exitItem_Click(object? sender, EventArgs e)
	{
		Application.Exit();
	}

	private void aboutMessageItem_Click(object? sender, EventArgs e)
	{
		player.AboutBox();
	}
}

partial class MediaPlayer
{
	private Container? components = null;

	public MediaPlayer()
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
		Application.Run(new MediaPlayer());
	}
}
