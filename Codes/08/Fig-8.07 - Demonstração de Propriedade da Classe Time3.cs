// Fig. 8.7: TimeTest3
// Demonstração.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

partial class Form1
{
	private Time3? time;
	private Label? hourLabel, minuteLabel, secondLabel, displayLabel;
	private TextBox? hourTextBox, minuteTextBox, secondTextBox;
	private Button? hourButton, minuteButton, secondButton;

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		this.time = new Time3(18, 18, 20);
		this.hourLabel = new Label();
		this.hourTextBox = new TextBox();
		this.hourButton = new Button();
		this.minuteLabel = new Label();
		this.minuteTextBox = new TextBox();
		this.minuteButton = new Button();
		this.secondLabel = new Label();
		this.secondTextBox = new TextBox();
		this.secondButton = new Button();
		this.displayLabel = new Label();
		this.SuspendLayout();

		this.hourLabel.Text = "Hour:";
		this.hourLabel.AutoSize = true;
		this.hourLabel.Location = new Point(0, 00);
		this.hourTextBox.Text = "16";
		this.hourTextBox.Size = new Size(30, 30);
		this.hourTextBox.Location = new Point(60, 00);
		this.hourButton.Text = "Set";
		this.hourButton.Location = new Point(90, 00);
		this.hourButton.Click += new EventHandler(this.HourButton_Click);

		this.minuteLabel.Text = "Minute:";
		this.minuteLabel.AutoSize = true;
		this.minuteLabel.Location = new Point(0, 30);
		this.minuteTextBox.Text = "28";
		this.minuteTextBox.Size = new Size(30, 0);
		this.minuteTextBox.Location = new Point(60, 30);
		this.minuteButton.Text = "Set";
		this.minuteButton.Location = new Point(90, 30);
		this.minuteButton.Click += new EventHandler(this.MinuteButton_Click);

		this.secondLabel.Text = "Second:";
		this.secondLabel.AutoSize = true;
		this.secondLabel.Location = new Point(0, 60);
		this.secondTextBox.Text = "18";
		this.secondTextBox.Size = new Size(30, 0);
		this.secondTextBox.Location = new Point(60, 60);
		this.secondButton.Text = "Set";
		this.secondButton.Location = new Point(90, 60);
		this.secondButton.Click += new EventHandler(this.SecondButton_Click);

		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(0, 90);
		UpdateDisplay();

		this.Controls.AddRange(new Control[]{
			this.hourLabel, this.hourTextBox, this.hourButton,
			this.minuteLabel, this.minuteTextBox, this.minuteButton,
			this.secondLabel, this.secondTextBox, this.secondButton,
			this.displayLabel
		});

		// Program.
		this.components = new Container();
		this.AutoSize = true;
		this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		this.ResumeLayout(false);
	}
	#endregion

	private void UpdateDisplay()
	{
		if (time != null && displayLabel != null)
		{
			string standardTime = $"Standard time: {time.ToStandardString()}";
			string universalTime = $"Universal time: {time.ToUniversalString()}";

			displayLabel.Text = $"{standardTime}\n{universalTime}";
		}
	}

	private void HourButton_Click(object? sender, EventArgs e)
	{
		try
		{
			if (time != null && this.hourTextBox != null)
			{
				time.Hour = int.Parse(this.hourTextBox.Text);
				this.hourTextBox.Text = "";
				UpdateDisplay();
			}
		}
		catch (System.Exception)
		{
			if (this.hourTextBox != null)
				this.hourTextBox.Text = "";

			UpdateDisplay();
		}
	}

	private void MinuteButton_Click(object? sender, EventArgs e)
	{
		try
		{
			if (time != null && minuteTextBox != null)
			{
				time.Minute = Int32.Parse(minuteTextBox.Text);
				minuteTextBox.Text = "";
			}
			UpdateDisplay();
		}
		catch (System.Exception)
		{
			if (minuteTextBox != null)
				minuteTextBox.Text = "";
			UpdateDisplay();
		}
	}

	private void SecondButton_Click(object? sender, EventArgs e)
	{
		try
		{
			if (time != null && secondTextBox != null)
			{
				time.Second = Int32.Parse(secondTextBox.Text);
				secondTextBox.Text = "";
			}
			UpdateDisplay();
		}
		catch (System.Exception)
		{
			if (secondTextBox != null)
				secondTextBox.Text = "";
			UpdateDisplay();
		}
	}
}

public partial class Form1 : Form
{
	private IContainer? components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}

	public Form1()
	{
		InitializeComponent();
	}
}

public class Time3
{
	private int hour;   // 0 a 23.
	private int minute; // 0 a 59.
	private int second; // 0 a 59.

	public int Hour
	{
		get => hour;
		set => hour = (value >= 0 && value < 24) ? value : 0;
	}

	public int Minute
	{
		get => minute;
		set => minute = (value >= 0 && value < 60) ? value : 0;
	}

	public int Second
	{
		get => second;
		set => second = (value >= 0 && value < 60) ? value : 0;
	}

	public Time3() : this(0) { }

	public Time3(int hour) : this(hour, 0) { }

	public Time3(int hour, int minute) : this(hour, minute, 0) { }

	public Time3(int hour, int minute, int second)
	{
		Hour = hour;
		Minute = minute;
		Second = second;
	}

	public Time3(Time3 time) : this(time.hour, time.minute, time.second) { }

	public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

	public string ToStandardString() =>
			$"{((Hour == 12 || Hour == 0) ? 12 : Hour % 12):D2}:{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
}

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
	}
}
