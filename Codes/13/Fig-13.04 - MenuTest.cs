// Fig. 13.4: MenuTest.cs
// Usando menus para alterar cores e estilos de fonte.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class MenuTest : Form
{
	private Label displayLabel;

	private MenuStrip mainMenu;

	private ToolStripMenuItem fileMenuItem;
	private ToolStripMenuItem aboutMenuItem;
	private ToolStripMenuItem exitMenuItem;

	private ToolStripMenuItem formatMenuItem;

	private ToolStripMenuItem colorMenuItem;
	private ToolStripMenuItem blackMenuItem;
	private ToolStripMenuItem blueMenuItem;
	private ToolStripMenuItem redMenuItem;
	private ToolStripMenuItem greenMenuItem;

	private ToolStripMenuItem fontMenuItem;
	private ToolStripMenuItem timesMenuItem;
	private ToolStripMenuItem courierMenuItem;
	private ToolStripMenuItem boldMenuItem;
	private ToolStripMenuItem italicMenuItem;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.displayLabel = new Label();

		this.mainMenu = new MenuStrip();

		this.fileMenuItem = new ToolStripMenuItem();
		this.aboutMenuItem = new ToolStripMenuItem();
		this.exitMenuItem = new ToolStripMenuItem();

		this.formatMenuItem = new ToolStripMenuItem();
		this.colorMenuItem = new ToolStripMenuItem();
		this.fontMenuItem = new ToolStripMenuItem();

		this.blackMenuItem = new ToolStripMenuItem();
		this.blueMenuItem = new ToolStripMenuItem();
		this.redMenuItem = new ToolStripMenuItem();
		this.greenMenuItem = new ToolStripMenuItem();

		this.timesMenuItem = new ToolStripMenuItem();
		this.courierMenuItem = new ToolStripMenuItem();
		this.boldMenuItem = new ToolStripMenuItem();
		this.italicMenuItem = new ToolStripMenuItem();

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "Use the Format menus to change\nthe appearance of this text";
		this.displayLabel.Location = new Point(10, 30);
		this.displayLabel.AutoSize = true;

		// mainMenu.
		this.mainMenu.Name = "mainMenu";
		this.mainMenu.Text = "Menu";
		this.mainMenu.AutoSize = true;
		this.mainMenu.Items.AddRange(new ToolStripDropDownItem[] {
			this.fileMenuItem, this.formatMenuItem
		});

		// fileMenuItem.
		this.fileMenuItem.Name = "fileMenu";
		this.fileMenuItem.Text = "File";
		this.fileMenuItem.AutoSize = true;
		this.fileMenuItem.DropDownItems.AddRange(new ToolStripDropDownItem[] {
			this.aboutMenuItem, this.exitMenuItem
		});

		// aboutMenuItem.
		this.aboutMenuItem.Name = "aboutMenuItem";
		this.aboutMenuItem.Text = "About";
		this.aboutMenuItem.AutoSize = true;
		this.aboutMenuItem.Click += new EventHandler(this.aboutMenuItem_Click);

		// exitMenuItem.
		this.exitMenuItem.Name = "exitMenuItem";
		this.exitMenuItem.Text = "Exit";
		this.exitMenuItem.AutoSize = true;
		this.exitMenuItem.Click += new EventHandler(this.exitMenuItem_Click);

		// formatMenuItem.
		this.formatMenuItem.Name = "formatMenuItem";
		this.formatMenuItem.Text = "Format";
		this.formatMenuItem.AutoSize = true;
		this.formatMenuItem.DropDownItems.AddRange(new ToolStripDropDownItem[] {
			this.colorMenuItem, this.fontMenuItem
		});

		// colorMenuItem.
		this.colorMenuItem.Name = "colorMenuItem";
		this.colorMenuItem.Text = "Color";
		this.colorMenuItem.AutoSize = true;
		this.colorMenuItem.DropDownItems.AddRange(new ToolStripDropDownItem[] {
			this.blackMenuItem, this.blueMenuItem,
			this.redMenuItem, this.greenMenuItem
		});

		// blackMenuItem.
		this.blackMenuItem.Name = "blackMenuItem";
		this.blackMenuItem.Text = "Black";
		this.blackMenuItem.AutoSize = true;
		this.blackMenuItem.Click += new EventHandler(this.blackMenuItem_Click);

		// blueMenuItem.
		this.blueMenuItem.Name = "blueMenuItem";
		this.blueMenuItem.Text = "Blue";
		this.blueMenuItem.AutoSize = true;
		this.blueMenuItem.Click += new EventHandler(this.blueMenuItem_Click);

		// redMenuItem.
		this.redMenuItem.Name = "redMenuItem";
		this.redMenuItem.Text = "Red";
		this.redMenuItem.AutoSize = true;
		this.redMenuItem.Click += new EventHandler(this.redMenuItem_Click);

		// greenMenuItem.
		this.greenMenuItem.Name = "greenMenuItem";
		this.greenMenuItem.Text = "Green";
		this.greenMenuItem.AutoSize = true;
		this.greenMenuItem.Click += new EventHandler(this.greenMenuItem_Click);

		// fontMenuItem
		this.fontMenuItem.Name = "fontMenuItem";
		this.fontMenuItem.Text = "Font";
		this.fontMenuItem.AutoSize = true;
		this.fontMenuItem.DropDownItems.AddRange(new ToolStripDropDownItem[] {
			this.timesMenuItem, this.courierMenuItem,
			this.boldMenuItem, this.italicMenuItem
		});

		// timesMenuItem.
		this.timesMenuItem.Name = "timesMenuItem";
		this.timesMenuItem.Text = "Times New Roman";
		this.timesMenuItem.AutoSize = true;
		this.timesMenuItem.Click += new EventHandler(this.timesMenuItem_Click);

		// courierMenuItem.
		this.courierMenuItem.Name = "courierMenuItem";
		this.courierMenuItem.Text = "Courier";
		this.courierMenuItem.AutoSize = true;
		this.courierMenuItem.Click += new EventHandler(this.courierMenuItem_Click);

		// boldMenuItem.
		this.boldMenuItem.Name = "boldMenuItem";
		this.boldMenuItem.Text = "Bold";
		this.boldMenuItem.AutoSize = true;
		this.boldMenuItem.Click += new EventHandler(this.boldMenuItem_Click);

		// italicMenuItem.
		this.italicMenuItem.Name = "italicMenuItem";
		this.italicMenuItem.Text = "Italic";
		this.italicMenuItem.AutoSize = true;
		this.italicMenuItem.Click += new EventHandler(this.italicMenuItem_Click);

		// MenuTest.
		this.Controls.AddRange(new Control[]{
			this.displayLabel, this.mainMenu
		});
		this.AutoScaleMode = AutoScaleMode.Font;
		this.AutoSize = true;
		this.Name = "MenuTest";
		this.Text = "MenuTest";
		this.ResumeLayout(false);
	}
	#endregion

	private void aboutMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		MessageBox.Show(
			"This is an example\nof using menus.",
			"About",
			MessageBoxButtons.OK,
			MessageBoxIcon.Information
		);
	}

	private void exitMenuItem_Click(object? sender, EventArgs eventArgs)
	{ Application.Exit(); }

	private void ClearColor()
	{
		blackMenuItem.Checked = false;
		blueMenuItem.Checked = false;
		redMenuItem.Checked = false;
		greenMenuItem.Checked = false;
	}

	private void blackMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearColor();

		displayLabel.ForeColor = Color.Black;
		blackMenuItem.Checked = true;
	}

	private void blueMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearColor();

		displayLabel.ForeColor = Color.Blue;
		blueMenuItem.Checked = true;
	}

	private void redMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearColor();

		displayLabel.ForeColor = Color.Red;
		redMenuItem.Checked = true;
	}

	private void greenMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearColor();

		displayLabel.ForeColor = Color.Green;
		greenMenuItem.Checked = true;
	}

	private void ClearFont()
	{
		timesMenuItem.Checked = false;
		courierMenuItem.Checked = false;
	}

	private void timesMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearFont();

		timesMenuItem.Checked = true;
		displayLabel.Font = new Font("Times New Roman", 9, displayLabel.Font.Style);
	}

	private void courierMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearFont();

		courierMenuItem.Checked = true;
		displayLabel.Font = new Font("Courier New", 9, displayLabel.Font.Style);
	}

	private void boldMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearFont();

		boldMenuItem.Checked = true;
		displayLabel.Font = new Font(
			displayLabel.Font.FontFamily, 9,
			displayLabel.Font.Style ^ FontStyle.Bold
		);
	}

	private void italicMenuItem_Click(object? sender, EventArgs eventArgs)
	{
		ClearFont();

		italicMenuItem.Checked = true;
		displayLabel.Font = new Font(
			displayLabel.Font.FontFamily, 9,
			displayLabel.Font.Style ^ FontStyle.Italic
		);
	}
}

partial class MenuTest
{
	private Container? components = null;

	public MenuTest()
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
		Application.Run(new MenuTest());
	}
}
