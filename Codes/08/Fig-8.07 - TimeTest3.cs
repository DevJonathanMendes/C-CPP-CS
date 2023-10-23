// Fig. 8.7: TimeTest3.cs
// Demonstrando as propriedades Hour, Minute e Second de Time3.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe Time3 (Fig-8.06 - Time3.cs) aqui.

partial class TimeTest3 : Form
{
	private Time3 time;

	private Label hourLabel;
	private TextBox hourTextBox;
	private Button hourButton;

	private Label minuteLabel;
	private TextBox minuteTextBox;
	private Button minuteButton;

	private Label secondLabel;
	private TextBox secondTextBox;
	private Button secondButton;

	private Button addButton;

	private Label displayLabel1;
	private Label displayLabel2;

	private void InitializeComponent()
	{
		this.time = new Time3();

		this.hourLabel = new Label();
		this.hourTextBox = new TextBox();
		this.hourButton = new();

		this.minuteLabel = new Label();
		this.minuteTextBox = new TextBox();
		this.minuteButton = new Button();

		this.secondLabel = new Label();
		this.secondTextBox = new TextBox();
		this.secondButton = new Button();

		this.addButton = new Button();

		this.displayLabel1 = new Label();
		this.displayLabel2 = new Label();

		// hourLabel.
		this.hourLabel.Name = "hourLabel";
		this.hourLabel.Text = "Hour:";
		this.hourLabel.AutoSize = true;
		this.hourLabel.Location = new Point(10, 10);

		// hourTextBox.
		this.hourTextBox.Name = "hourTextBox";
		this.hourTextBox.Text = "18";
		this.hourTextBox.Size = new Size(30, 20);
		this.hourTextBox.Location = new Point(60, 5);

		// hourButton.
		this.hourButton.Name = "hourButton";
		this.hourButton.Text = "Set Hour";
		this.hourButton.Location = new Point(100, 5);
		this.hourButton.Click += new EventHandler(hourButton_Click);

		// minuteLabel.
		this.minuteLabel.Name = "minuteLabel";
		this.minuteLabel.Text = "Minute:";
		this.minuteLabel.AutoSize = true;
		this.minuteLabel.Location = new Point(10, 40);

		// minuteTextBox.
		this.minuteTextBox.Name = "minuteTextBox";
		this.minuteTextBox.Text = "01";
		this.minuteTextBox.Size = new Size(30, 20);
		this.minuteTextBox.Location = new Point(60, 35);

		// minuteButton.
		this.minuteButton.Name = "minuteButton";
		this.minuteButton.Text = "Set Minute";
		this.minuteButton.Location = new Point(100, 35);
		this.minuteButton.Click += new EventHandler(minuteButton_Click);

		// secondLabel.
		this.secondLabel.Name = "secondLabel";
		this.secondLabel.Text = "Second:";
		this.secondLabel.AutoSize = true;
		this.secondLabel.Location = new Point(10, 70);

		// secondTextBox.
		this.secondTextBox.Name = "secondTextBox";
		this.secondTextBox.Text = "20";
		this.secondTextBox.Size = new Size(30, 20);
		this.secondTextBox.Location = new Point(60, 65);

		// secondButton.
		this.secondButton.Name = "secondButton";
		this.secondButton.Text = "Set Second";
		this.secondButton.Location = new Point(100, 65);
		this.secondButton.Click += new EventHandler(secondButton_Click);

		// addButton.
		this.addButton.Name = "addButton";
		this.addButton.Text = "Add 1 to Second";
		this.addButton.AutoSize = true;
		this.addButton.Location = new Point(100, 95);
		this.addButton.Click += new EventHandler(addButton_Click);

		// displayLabel1.
		this.displayLabel1.Name = "displayLabel1";
		this.displayLabel1.Text = "";
		this.displayLabel1.AutoSize = true;
		this.displayLabel1.Location = new Point(190, 10);

		// displayLabel2.
		this.displayLabel2.Name = "displayLabel2";
		this.displayLabel2.Text = "";
		this.displayLabel2.AutoSize = true;
		this.displayLabel2.Location = new Point(190, 30);

		// TimeTest3.
		this.Controls.AddRange(new Control[]{
			this.hourLabel, this.hourTextBox, this.hourButton,
			this.minuteLabel, this.minuteTextBox, this.minuteButton,
			this.secondLabel, this.secondTextBox, this.secondButton,
			this.addButton, this.displayLabel1, this.displayLabel2,
		});
		this.Name = "TimeTest3";
		this.Text = "TimeTest3";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	public void UpdateDisplay()
	{
		displayLabel1.Text = "Hour: " + time.Hour +
			"; Minute: " + time.Minute +
			"; Second: " + time.Second;

		displayLabel2.Text = "Standard time: " +
			time.ToStandardString() + "\nUniversal time: " +
			time.ToUniversalString();
	}

	private void hourButton_Click(object? sender, EventArgs e)
	{
		time.Hour = Int32.Parse(hourTextBox.Text);
		hourTextBox.Text = "";
		UpdateDisplay();
	}

	private void minuteButton_Click(object? sender, EventArgs e)
	{
		time.Minute = Int32.Parse(minuteTextBox.Text);
		minuteTextBox.Text = "";
		UpdateDisplay();
	}

	private void secondButton_Click(object? sender, EventArgs e)
	{
		time.Second = Int32.Parse(secondTextBox.Text);
		secondTextBox.Text = "";
		UpdateDisplay();
	}

	private void addButton_Click(object? sender, EventArgs e)
	{
		time.Second = (time.Second + 1) % 60;

		if (time.Second == 0)
		{
			time.Minute = (time.Minute + 1) % 60;

			if (time.Minute == 0)
				time.Hour = (time.Hour + 1) % 24;
		}

		UpdateDisplay();
	}
}

partial class TimeTest3
{
	private Container? components = null;

	public TimeTest3()
	{
		InitializeComponent();

		UpdateDisplay();
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
		Application.Run(new TimeTest3());
	}
}
