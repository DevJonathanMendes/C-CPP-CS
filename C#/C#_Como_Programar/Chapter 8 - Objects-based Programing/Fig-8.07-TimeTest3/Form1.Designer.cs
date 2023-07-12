namespace winforms;

using System;
using System.Windows.Forms;
// using System.Data;
// using System.Drawing;
// using System.Collections;
// using System.ComponentModel;

partial class Form1
{
	private Time3 time;

	private Label HourLabel, minuteLabel, secondLabel;
	private TextBox hourTextBox, minuteTextBox, secondTextBox;
	private Button hourButton, minuteButton, secondButton;
	private Label displayLabel1, displayLabel2;

	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
			components.Dispose();

		base.Dispose(disposing);
	}

	private void InitElements()
	{
		HourLabel = new Label("Hour:");
		hourTextBox = new TextBox("18");
		hourButton = new Button("Set Hour");

		minuteLabel = new Label("Minute:");
		minuteTextBox = new TextBox("01");
		minuteButton = new Button("Set Minute");

		secondLabel = new Label("Minute:");
		secondTextBox = new TextBox("20");
		secondButton = new Button("Set Minute");

		displayLabel1 = new Label("");
		displayLabel2 = new Label("");
	}

	private void AddElements()
	{
		Controls.Add(HourLabel);
		Controls.Add(hourTextBox);
		Controls.Add(hourButton);

		Controls.Add(minuteLabel);
		Controls.Add(minuteTextBox);
		Controls.Add(minuteButton);

		Controls.Add(secondLabel);
		Controls.Add(secondTextBox);
		Controls.Add(secondButton);

		Controls.Add(displayLabel1);
		Controls.Add(displayLabel2);
	}

	private void DefineLocation()
	{
		HourLabel.SetLocation(0, 8);
		hourTextBox.SetLocation(HourLabel.Width + 11, 6);
		hourButton.SetLocation(HourLabel.Width + hourTextBox.Width + 11, 5);

		minuteLabel.SetLocation(0, 38);
		minuteTextBox.SetLocation(minuteLabel.Width, 36);
		minuteButton.SetLocation(minuteLabel.Width + minuteTextBox.Width, 35);

		secondLabel.SetLocation(0, 68);
		secondTextBox.SetLocation(secondLabel.Width, 66);
		secondButton.SetLocation(secondLabel.Width + secondTextBox.Width, 65);

		displayLabel1.SetLocation(180, 6);
		displayLabel2.SetLocation(180, 26);
	}

	private void DefineClick()
	{
		hourButton.Click += HourButton_Click;
		minuteButton.Click += MinuteButton_Click;
		secondButton.Click += SecondButton_Click;
	}

	private void HourButton_Click(object sender, System.EventArgs e)
	{
		try
		{
			time.Hour = Int32.Parse(hourTextBox.Text);
			hourTextBox.Text = "";
			UpdateDisplay();
		}
		catch (System.Exception)
		{
			hourTextBox.Text = "10";
			UpdateDisplay();
		}
	}

	private void MinuteButton_Click(object sender, System.EventArgs e)
	{
		try
		{
			time.Minute = Int32.Parse(minuteTextBox.Text);
			minuteTextBox.Text = "";
			UpdateDisplay();
		}
		catch (System.Exception)
		{
			minuteTextBox.Text = "10";
			UpdateDisplay();
		}
	}

	private void SecondButton_Click(object sender, System.EventArgs e)
	{
		try
		{
			time.Second = Int32.Parse(secondTextBox.Text);
			secondTextBox.Text = "";
			UpdateDisplay();
		}
		catch (System.Exception)
		{
			secondTextBox.Text = "10";
			UpdateDisplay();
		}
	}

	private void UpdateDisplay()
	{
		displayLabel1.Text = String.Format($"Hour: {time.Hour:D2}; Minute: {time.Minute:D2}; Second: {time.Second:D2}");
		displayLabel2.Text = $"Standard time: {time.ToStandardString()}\nUniversal time: {time.ToUniversalString()}";
	}

	#region Windows Form Designer generated code
	private void InitializeComponent()
	{
		time = new Time3(18, 38, 14);

		InitElements();
		AddElements();
		DefineLocation();
		DefineClick();
		UpdateDisplay();

		// INITIALIZE.
		this.components = new System.ComponentModel.Container();
		this.AutoScaleMode = AutoScaleMode.Font;
		this.AutoSize = true;
		this.Text = "Form1";
		// this.ClientSize = new Size(500, 400);
		// this.AutoScaleDimensions = new SizeF(8f, 20f);
	}
	#endregion
}
