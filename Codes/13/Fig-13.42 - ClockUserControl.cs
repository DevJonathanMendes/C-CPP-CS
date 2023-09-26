// Fig. 13.42: ClockUserControl.cs
// Controle definido pelo usuário com um temporizador e um rótulo.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

public class ClockUserControl : UserControl
{
	private Timer clockTimer;
	private Label displayLabel;

	private Container? components = null;

	private void InitializeComponent()
	{
		this.clockTimer = new Timer();
		this.displayLabel = new Label();

		// clockTimer.
		this.clockTimer.Enabled = true;
		this.clockTimer.Interval = 100;
		this.clockTimer.Tick += new EventHandler(clockTimer_Tick);

		// displayLabel.
		this.displayLabel.Name = "displayLabel";
		this.displayLabel.Text = "";
		this.displayLabel.AutoSize = true;
		this.displayLabel.Location = new Point(10, 10);

		// ClockUserControl.
		this.Controls.Add(this.displayLabel);
		this.Name = "ClockUserControl";
		this.Text = "ClockUserControl";
		this.AutoSize = true;
	}

	private void clockTimer_Tick(object? sender, EventArgs e)
	{ displayLabel.Text = DateTime.Now.ToLongTimeString(); }

	public ClockUserControl()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}
