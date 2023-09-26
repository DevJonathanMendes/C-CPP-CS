// Fig. 13.36: UsingMDI.cs
// Demonstrando o uso de janelas progenitoras e filhas MDI.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class UsingMDI : Form
{
	private MenuStrip mainMenu1;
	private ToolStripMenuItem fileMenuItem;
	private ToolStripMenuItem newMenuItem;
	private ToolStripMenuItem child1MenuItem;
	private ToolStripMenuItem child2MenuItem;
	private ToolStripMenuItem child3MenuItem;
	private ToolStripMenuItem exitMenuItem;
	private ToolStripMenuItem formatMenuItem;
	private ToolStripMenuItem cascadeMenuItem;
	private ToolStripMenuItem tileHorizontalMenuItem;
	private ToolStripMenuItem tileVerticalMenuItem;

	private void InitializeComponent()
	{
		this.mainMenu1 = new MenuStrip();
		this.fileMenuItem = new ToolStripMenuItem();
		this.newMenuItem = new ToolStripMenuItem();
		this.child1MenuItem = new ToolStripMenuItem();
		this.child2MenuItem = new ToolStripMenuItem();
		this.child3MenuItem = new ToolStripMenuItem();
		this.exitMenuItem = new ToolStripMenuItem();
		this.formatMenuItem = new ToolStripMenuItem();
		this.cascadeMenuItem = new ToolStripMenuItem();
		this.tileHorizontalMenuItem = new ToolStripMenuItem();
		this.tileVerticalMenuItem = new ToolStripMenuItem();

		// mainMenu1.
		this.mainMenu1.Name = "mainMenu1";
		this.mainMenu1.Text = "mainMenu1";
		this.mainMenu1.Items.AddRange(new ToolStripItem[] {
			this.fileMenuItem, this.formatMenuItem
		});

		// fileMenuItem.
		this.fileMenuItem.Name = "fileMenuItem";
		this.fileMenuItem.Text = "fileMenuItem";
		this.fileMenuItem.AutoSize = true;
		this.fileMenuItem.DropDownItems.AddRange(new ToolStripItem[]{
			this.newMenuItem, this.exitMenuItem
		});

		// newMenuItem.
		this.newMenuItem.Name = "newMenuItem";
		this.newMenuItem.Text = "New";
		this.newMenuItem.AutoSize = true;
		this.newMenuItem.DropDownItems.AddRange(new ToolStripItem[]{
			this.child1MenuItem, this.child2MenuItem, this.child3MenuItem
		});

		// exitMenuItem.
		this.exitMenuItem.Name = "exitMenuItem";
		this.exitMenuItem.Text = "Exit";
		this.exitMenuItem.AutoSize = true;
		this.exitMenuItem.Click += new EventHandler(exitMenuItem_Click);

		// child1MenuItem.
		this.child1MenuItem.Name = "child1MenuItem";
		this.child1MenuItem.Text = "Child1";
		this.child1MenuItem.AutoSize = true;
		this.child1MenuItem.Click += new EventHandler(child1MenuItem_Click);

		// child2MenuItem.
		this.child2MenuItem.Name = "child2MenuItem";
		this.child2MenuItem.Text = "Child2";
		this.child2MenuItem.AutoSize = true;
		this.child2MenuItem.Click += new EventHandler(child2MenuItem_Click);

		// child3MenuItem.
		this.child3MenuItem.Name = "child3MenuItem";
		this.child3MenuItem.Text = "Child3";
		this.child3MenuItem.AutoSize = true;
		this.child3MenuItem.Click += new EventHandler(child3MenuItem_Click);

		// formatMenuItem.
		this.formatMenuItem.Name = "formatMenuItem";
		this.formatMenuItem.Text = "Format";
		this.formatMenuItem.AutoSize = true;
		this.formatMenuItem.DropDownItems.AddRange(new ToolStripItem[]{
			this.cascadeMenuItem, this.tileHorizontalMenuItem,
			this.tileVerticalMenuItem
		});

		// cascadeMenuItem.
		this.cascadeMenuItem.Name = "cascadeMenuItem";
		this.cascadeMenuItem.Text = "Cascade";
		this.cascadeMenuItem.AutoSize = true;
		this.cascadeMenuItem.Click += new EventHandler(cascadeMenuItemMenuItem_Click);

		// tileHorizontalMenuItem.
		this.tileHorizontalMenuItem.Name = "tileHorizontalMenuItem";
		this.tileHorizontalMenuItem.Text = "Horizontal";
		this.tileHorizontalMenuItem.AutoSize = true;
		this.tileHorizontalMenuItem.Click += new EventHandler(tileHorizontalMenuItem_Click);

		// tileVerticalMenuItem.
		this.tileVerticalMenuItem.Name = "tileVerticalMenuItem";
		this.tileVerticalMenuItem.Text = "Vertical";
		this.tileVerticalMenuItem.AutoSize = true;
		this.tileVerticalMenuItem.Click += new EventHandler(tileVerticalMenuItem_Click);

		// UsingMDI.
		this.Controls.Add(this.mainMenu1);
		this.Name = "UsingMDI";
		this.Text = "UsingMDI";
		this.AutoSize = true;
		this.IsMdiContainer = true;
		this.WindowState = FormWindowState.Maximized;
		this.ResumeLayout(false);
	}

	private void child1MenuItem_Click(object? sender, EventArgs e)
	{
		Form newMDIChild1 = new Form();
		newMDIChild1.MdiParent = this;
		newMDIChild1.Name = "Child1";
		newMDIChild1.Text = "Child 1";
		newMDIChild1.Show();
	}

	private void child2MenuItem_Click(object? sender, EventArgs e)
	{
		Form newMDIChild2 = new Form();
		newMDIChild2.MdiParent = this;
		newMDIChild2.Name = "Child2";
		newMDIChild2.Text = "Child 2";
		newMDIChild2.Show();
	}

	private void child3MenuItem_Click(object? sender, EventArgs e)
	{
		Form newMDIChild3 = new Form();
		newMDIChild3.MdiParent = this;
		newMDIChild3.Name = "Child3";
		newMDIChild3.Text = "Child 3";
		newMDIChild3.Show();
	}

	private void exitMenuItem_Click(object? sender, EventArgs e)
	{
		Application.Exit();
	}

	private void cascadeMenuItemMenuItem_Click(object? sender, EventArgs e)
	{
		this.LayoutMdi(MdiLayout.Cascade);
	}

	private void tileHorizontalMenuItem_Click(object? sender, EventArgs e)
	{
		this.LayoutMdi(MdiLayout.TileHorizontal);
	}

	private void tileVerticalMenuItem_Click(object? sender, EventArgs e)
	{
		this.LayoutMdi(MdiLayout.TileVertical);
	}
}

partial class UsingMDI
{
	private Container? components = null;

	public UsingMDI()
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
		Application.Run(new UsingMDI());
	}
}
