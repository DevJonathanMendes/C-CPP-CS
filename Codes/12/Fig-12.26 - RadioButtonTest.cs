// Fig. 12.26: RadioButtonTest.cs
// Usando RadioButton para configurar opções de janela de mensagem.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class RadioButtonTest : Form
{
	private Label displayLabel;
	private Button displayButton;

	private RadioButton questionButton;
	private RadioButton informationButton;
	private RadioButton exclamationButton;
	private RadioButton errorButton;
	private RadioButton retryCancelButton;
	private RadioButton yesNoButton;
	private RadioButton yesNoCancelButton;
	private RadioButton okCancelButton;
	private RadioButton okButton;
	private RadioButton abortRetryIgnoreButton;

	private GroupBox groupBox1;
	private GroupBox groupBox2;

	private MessageBoxIcon iconType = MessageBoxIcon.Error;
	private MessageBoxButtons buttonType = MessageBoxButtons.OK;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.displayLabel = new Label();
		this.displayButton = new Button();

		this.questionButton = new RadioButton();
		this.informationButton = new RadioButton();
		this.exclamationButton = new RadioButton();
		this.errorButton = new RadioButton();
		this.retryCancelButton = new RadioButton();
		this.yesNoButton = new RadioButton();
		this.yesNoCancelButton = new RadioButton();
		this.okCancelButton = new RadioButton();
		this.okButton = new RadioButton();
		this.abortRetryIgnoreButton = new RadioButton();

		this.groupBox1 = new GroupBox();
		this.groupBox2 = new GroupBox();

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "Choose the type of MessageBox you would like to display!";
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 10);

		// displayButton.
		this.displayButton.Name = "displayButton";
		this.displayButton.Text = "Display";
		this.displayButton.Location = new Point(220, 160);
		this.displayButton.Click += new EventHandler(displayButton_Click);

		// GroupBox1.
		this.groupBox1.Name = "ButtonType";
		this.groupBox1.Text = "Button Type";
		this.groupBox1.AutoSize = true;
		this.groupBox1.Location = new Point(10, 30);
		this.groupBox1.Controls.AddRange(new Control[] {
			this.okButton,
			this.okCancelButton,
			this.abortRetryIgnoreButton,
			this.yesNoCancelButton,
			this.yesNoButton,
			this.retryCancelButton
		});

		// okButton.
		this.okButton.Name = "okButton";
		this.okButton.Text = "OK";
		this.okButton.AutoSize = true;
		this.okButton.Location = new Point(10, 15);
		this.okButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// okCancelButton.
		this.okCancelButton.Name = "okCancelButton";
		this.okCancelButton.Text = "OKCancel";
		this.okCancelButton.AutoSize = true;
		this.okCancelButton.Location = new Point(10, 35);
		this.okCancelButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// AbortRetryIgnore.
		this.abortRetryIgnoreButton.Name = "AbortRetryIgnore";
		this.abortRetryIgnoreButton.Text = "AbortRetryIgnore";
		this.abortRetryIgnoreButton.AutoSize = true;
		this.abortRetryIgnoreButton.Location = new Point(10, 55);
		this.abortRetryIgnoreButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// okCancelButton.
		this.yesNoCancelButton.Name = "yesNoCancelButton";
		this.yesNoCancelButton.Text = "YesNoCancel";
		this.yesNoCancelButton.AutoSize = true;
		this.yesNoCancelButton.Location = new Point(10, 75);
		this.yesNoCancelButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// yesNoButton.
		this.yesNoButton.Name = "yesNoButton";
		this.yesNoButton.Text = "YesNo";
		this.yesNoButton.AutoSize = true;
		this.yesNoButton.Location = new Point(10, 95);
		this.yesNoButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// retryCancelButton.
		this.retryCancelButton.Name = "retryCancelButton";
		this.retryCancelButton.Text = "RetryCancel";
		this.retryCancelButton.AutoSize = true;
		this.retryCancelButton.Location = new Point(10, 115);
		this.retryCancelButton.CheckedChanged += new EventHandler(buttonType_CheckedChanged);

		// GroupBox2.
		this.groupBox2.Name = "Icon";
		this.groupBox2.Text = "Icon";
		this.groupBox2.AutoSize = true;
		this.groupBox2.Location = new Point(220, 30);
		this.groupBox2.Controls.AddRange(new Control[] {
			this.errorButton,
			this.questionButton,
			this.informationButton,
			this.exclamationButton,
		});

		// errorButton.
		this.errorButton.Name = "errorButton";
		this.errorButton.Text = "Error";
		this.errorButton.AutoSize = true;
		this.errorButton.Location = new Point(10, 15);
		this.errorButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);

		// exclamationButton.
		this.exclamationButton.Name = "exclamationButton";
		this.exclamationButton.Text = "Exclamation";
		this.exclamationButton.AutoSize = true;
		this.exclamationButton.Location = new Point(10, 35);
		this.exclamationButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);

		// informationButton.
		this.informationButton.Name = "informationButton";
		this.informationButton.Text = "Information";
		this.informationButton.AutoSize = true;
		this.informationButton.Location = new Point(10, 55);
		this.informationButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);

		// questionButton.
		this.questionButton.Name = "questionButton";
		this.questionButton.Text = "Question";
		this.questionButton.AutoSize = true;
		this.questionButton.Location = new Point(10, 75);
		this.questionButton.CheckedChanged += new EventHandler(iconType_CheckedChanged);

		// RadioButtonTest.
		this.AutoScaleMode = AutoScaleMode.Font;
		this.AutoSize = true;
		this.Controls.AddRange(new Control[]{
			this.displayLabel,
			this.displayButton,
			this.groupBox1,
			this.groupBox2
		});
		this.Name = "RadioButtonTest";
		this.Text = "RadioButtonTest";
		this.ResumeLayout(false);
	}
	#endregion

	private void buttonType_CheckedChanged(object sender, EventArgs e)
	{
		if (sender == okButton)
			buttonType = MessageBoxButtons.OK;
		else if (sender == okCancelButton)
			buttonType = MessageBoxButtons.OKCancel;
		else if (sender == abortRetryIgnoreButton)
			buttonType = MessageBoxButtons.AbortRetryIgnore;
		else if (sender == yesNoButton)
			buttonType = MessageBoxButtons.YesNoCancel;
		else if (sender == yesNoButton)
			buttonType = MessageBoxButtons.YesNo;
		else
			buttonType = MessageBoxButtons.RetryCancel;
	}

	private void iconType_CheckedChanged(object sender, EventArgs e)
	{
		if (sender == errorButton)
			iconType = MessageBoxIcon.Error;
		else if (sender == exclamationButton)
			iconType = MessageBoxIcon.Exclamation;
		else if (sender == informationButton)
			iconType = MessageBoxIcon.Information;
		else
			iconType = MessageBoxIcon.Question;
	}

	protected void displayButton_Click(object sender, EventArgs e)
	{
		DialogResult result =
			MessageBox.Show(
				"This is Your Custom MessageBox.",
				"Custom MessageBox",
				buttonType,
				iconType, 0, 0
		);

		switch (result)
		{
			case DialogResult.OK: displayLabel.Text = "Ok was pressed"; break;
			case DialogResult.Cancel: displayLabel.Text = "Cancel was pressed"; break;
			case DialogResult.Abort: displayLabel.Text = "Abort was pressed"; break;
			case DialogResult.Retry: displayLabel.Text = "Retry was pressed"; break;
			case DialogResult.Ignore: displayLabel.Text = "Ignore was pressed"; break;
			case DialogResult.Yes: displayLabel.Text = "Yes was pressed"; break;
			case DialogResult.No: displayLabel.Text = "No was pressed"; break;
		}
	}
}

partial class RadioButtonTest
{
	private Container components = null;

	public RadioButtonTest()
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
		Application.Run(new RadioButtonTest());
	}
}
