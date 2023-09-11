// Fig. 12.22: GroupBoxPanelExample.cs
// Usando GroupBox e Panel para conter botões.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class GroupBoxPanelExample : Form
{
	private Button hiButton;
	private Button byeButton;
	private Button leftButton;
	private Button rightButton;

	private GroupBox mainGroupBox;
	private Label messageLabel;
	private Panel mainPanel;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.hiButton = new Button();
		this.byeButton = new Button();
		this.leftButton = new Button();
		this.rightButton = new Button();
		this.mainGroupBox = new GroupBox();
		this.messageLabel = new Label();
		this.mainPanel = new Panel();
		this.SuspendLayout();

		// GroupBox.
		this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
		this.mainGroupBox.Name = "mainGroupBox";
		this.mainGroupBox.Size = new System.Drawing.Size(200, 100);
		this.mainGroupBox.Text = "Main GroupBox";
		this.mainGroupBox.Controls.Add(this.hiButton);
		this.mainGroupBox.Controls.Add(this.byeButton);

		// hiButton.
		this.hiButton.Location = new System.Drawing.Point(10, 30);
		this.hiButton.Name = "hiButton";
		this.hiButton.Size = new System.Drawing.Size(80, 30);
		this.hiButton.Text = "Hi";
		this.hiButton.Click += new System.EventHandler(this.hiButton_Click);

		// byeButton.
		this.byeButton.Location = new System.Drawing.Point(100, 30);
		this.byeButton.Name = "byeButton";
		this.byeButton.Size = new System.Drawing.Size(80, 30);
		this.byeButton.Text = "Bye";
		this.byeButton.Click += new System.EventHandler(this.byeButton_Click);

		// messagePanel.
		this.mainPanel.Location = new System.Drawing.Point(12, 120);
		this.mainPanel.Name = "panel";
		this.mainPanel.Size = new System.Drawing.Size(200, 100);
		this.mainPanel.AutoScroll = true;
		this.mainPanel.BorderStyle = BorderStyle.FixedSingle;
		this.mainPanel.Controls.Add(this.leftButton);
		this.mainPanel.Controls.Add(this.rightButton);

		// leftButton.
		this.leftButton.Location = new System.Drawing.Point(10, 30);
		this.leftButton.Name = "leftButton";
		this.leftButton.Size = new System.Drawing.Size(80, 30);
		this.leftButton.Text = "Far Left";
		this.leftButton.Click += new System.EventHandler(this.leftButton_Click);

		// rightButton.
		this.rightButton.Location = new System.Drawing.Point(200, 30);
		this.rightButton.Name = "rightButton";
		this.rightButton.Size = new System.Drawing.Size(80, 30);
		this.rightButton.Text = "Far Right";
		this.rightButton.Click += new System.EventHandler(this.rightButton_Click);

		// messageLabel.
		this.messageLabel.Location = new System.Drawing.Point(12, 230);
		this.messageLabel.Name = "messageLabel";
		this.messageLabel.Size = new System.Drawing.Size(200, 20);
		this.messageLabel.TextAlign = ContentAlignment.MiddleCenter;

		// GroupBoxPanelExample.
		this.AutoScaleMode = AutoScaleMode.Font;
		this.FormBorderStyle = FormBorderStyle.FixedDialog;
		this.ClientSize = new System.Drawing.Size(224, 262);
		this.Controls.AddRange(new Control[]{
			this.mainGroupBox,
			this.mainPanel,
			this.messageLabel});
		this.Name = "GroupBoxPanelExample";
		this.Text = "GroupBoxPanelExample";
		this.ResumeLayout(false);
	}
	#endregion

	private void hiButton_Click(object sender, EventArgs e)
	{ messageLabel.Text = "Hi pressed"; }

	private void byeButton_Click(object sender, EventArgs e)
	{ messageLabel.Text = "Bye pressed"; }

	private void leftButton_Click(object sender, EventArgs e)
	{ messageLabel.Text = "Far left pressed"; }

	private void rightButton_Click(object sender, EventArgs e)
	{ messageLabel.Text = "Far right pressed"; }
}

partial class GroupBoxPanelExample
{
	private Container components = null;

	public GroupBoxPanelExample()
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
		Application.Run(new GroupBoxPanelExample());
	}
}
