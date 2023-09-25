// Fig. 13.29: UsingTabs.cs
// Usando TabControl para exibir várias configurações de fonte.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class UsingTabs : Form
{
	private Label displayLabel;

	private TabControl optionsTabControl;

	private TabPage colorTabPage;
	private RadioButton blackRadioButton;
	private RadioButton redRadioButton;
	private RadioButton greenRadioButton;

	private TabPage sizeTabPage;
	private RadioButton size12RadioButton;
	private RadioButton size16RadioButton;
	private RadioButton size20RadioButton;

	private TabPage messageTabPage;
	private RadioButton goodByeRadioButton;
	private RadioButton helloRadioButton;

	private TabPage aboutTabPage;
	private Label messageLabel;

	private void InitializeComponent()
	{
		this.displayLabel = new Label();

		this.optionsTabControl = new TabControl();

		this.colorTabPage = new TabPage();
		this.blackRadioButton = new RadioButton();
		this.redRadioButton = new RadioButton();
		this.greenRadioButton = new RadioButton();

		this.sizeTabPage = new TabPage();
		this.size12RadioButton = new RadioButton();
		this.size16RadioButton = new RadioButton();
		this.size20RadioButton = new RadioButton();

		this.messageTabPage = new TabPage();
		this.helloRadioButton = new RadioButton();
		this.goodByeRadioButton = new RadioButton();

		this.aboutTabPage = new TabPage();
		this.messageLabel = new Label();

		// optionsTabControl.
		this.optionsTabControl.Name = "optionsTabControl";
		this.optionsTabControl.TabPages.AddRange(new TabPage[] {
			this.colorTabPage, this.sizeTabPage,
			this.aboutTabPage
		});

		// colorTabPage.
		this.colorTabPage.Name = "colorTabPage";
		this.colorTabPage.Text = "Color";
		this.colorTabPage.Controls.AddRange(new Control[] {
			this.redRadioButton, this.blackRadioButton,
			this.greenRadioButton
		});

		// blackRadioButton.
		this.blackRadioButton.Name = "blackRadioButton";
		this.blackRadioButton.Text = "Black";
		this.blackRadioButton.AutoSize = true;
		this.blackRadioButton.Checked = true;
		this.blackRadioButton.Location = new Point(10, 10);
		this.blackRadioButton.CheckedChanged += new EventHandler(blackRadioButton_CheckedChange);

		// redRadioButton.
		this.redRadioButton.Name = "redRadioButton";
		this.redRadioButton.Text = "Red";
		this.redRadioButton.AutoSize = true;
		this.redRadioButton.Location = new Point(10, 30);
		this.redRadioButton.CheckedChanged += new EventHandler(redRadioButton_CheckedChange);

		// greenRadioButton.
		this.greenRadioButton.Name = "greenRadioButton";
		this.greenRadioButton.Text = "Green";
		this.greenRadioButton.AutoSize = true;
		this.greenRadioButton.Location = new Point(10, 50);
		this.greenRadioButton.CheckedChanged += new EventHandler(greenRadioButton_CheckedChange);

		// sizeTabPage.
		this.sizeTabPage.Name = "sizeTabPage";
		this.sizeTabPage.Text = "Size";
		this.sizeTabPage.Controls.AddRange(new Control[] {
			this.size12RadioButton, this.size16RadioButton,
			this.size20RadioButton
		});

		// size12RadioButton.
		this.size12RadioButton.Name = "size12RadioButton";
		this.size12RadioButton.Text = "12 point";
		this.size12RadioButton.AutoSize = true;
		this.size12RadioButton.Checked = true;
		this.size12RadioButton.Location = new Point(10, 10);
		this.size12RadioButton.CheckedChanged += new EventHandler(size12RadioButton_CheckedChange);

		// size16RadioButton.
		this.size16RadioButton.Name = "size16RadioButton";
		this.size16RadioButton.Text = "16 point";
		this.size16RadioButton.AutoSize = true;
		this.size16RadioButton.Location = new Point(10, 30);
		this.size16RadioButton.CheckedChanged += new EventHandler(size16RadioButton_CheckedChange);

		// size20RadioButton.
		this.size20RadioButton.Name = "size20RadioButton";
		this.size20RadioButton.Text = "20 point";
		this.size20RadioButton.AutoSize = true;
		this.size20RadioButton.Location = new Point(10, 50);
		this.size20RadioButton.CheckedChanged += new EventHandler(size20RadioButton_CheckedChange);

		// messageTabPage.
		this.messageTabPage.Name = "messageTabPage";
		this.messageTabPage.Text = "Message";
		this.messageTabPage.Controls.AddRange(new Control[] {
			this.helloRadioButton, this.goodByeRadioButton,
		});

		// helloRadioButton.
		this.helloRadioButton.Name = "helloRadioButton";
		this.helloRadioButton.Text = "Hello!";
		this.helloRadioButton.AutoSize = true;
		this.helloRadioButton.Checked = true;
		this.helloRadioButton.Location = new Point(10, 10);
		this.helloRadioButton.CheckedChanged += new EventHandler(helloRadioButton_CheckedChange);

		// goodByeRadioButton.
		this.goodByeRadioButton.Name = "goodByeRadioButton";
		this.goodByeRadioButton.Text = "Goodbye!";
		this.goodByeRadioButton.AutoSize = true;
		this.goodByeRadioButton.Location = new Point(10, 30);
		this.goodByeRadioButton.CheckedChanged += new EventHandler(goodByeRadioButton_CheckedChange);

		// aboutTabPage.
		this.aboutTabPage.Name = "aboutTabPage";
		this.aboutTabPage.Text = "About";
		this.aboutTabPage.Controls.Add(this.messageLabel);

		// messageLabel.
		this.messageLabel.Name = "messageLabel";
		this.messageLabel.Text = "Tabs are used to organize\ncontrols and conserve\nscreen space.";
		this.messageLabel.AutoSize = true;
		this.messageLabel.Location = new Point(10, 10);

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "Hello!";
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 110);

		// UsingTabs.
		this.Controls.AddRange(new Control[] {
			this.optionsTabControl, this.displayLabel
		});
		this.Name = "UsingTabs";
		this.Text = "UsingTabs";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void redRadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.ForeColor = Color.Red;
	}

	private void blackRadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.ForeColor = Color.Black;
	}

	private void greenRadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.ForeColor = Color.Green;
	}

	private void size12RadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.Font = new Font(displayLabel.Font.Name, 12);
	}

	private void size16RadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.Font = new Font(displayLabel.Font.Name, 16);
	}

	private void size20RadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.Font = new Font(displayLabel.Font.Name, 20);
	}

	private void helloRadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.Text = "Hello!";
	}

	private void goodByeRadioButton_CheckedChange(object? sender, EventArgs e)
	{
		displayLabel.Text = "Goodbye!";
	}
}

partial class UsingTabs
{
	private Container? components = null;

	public UsingTabs()
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
		Application.Run(new UsingTabs());
	}
}
