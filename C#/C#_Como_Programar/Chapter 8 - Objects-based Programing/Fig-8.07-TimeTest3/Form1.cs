namespace winforms;

using System;
using System.Drawing;
using System.Windows.Forms;
// using System.Data;
// using System.Collections;
// using System.ComponentModel;

public class Time3 : Object
{
	private int hour;   // 0 a 23.
	private int minute; // 0 a 59.
	private int second; // 0 a 59.

	// GET E SET.
	public int Hour
	{
		get { return hour; }
		set { hour = ((value >= 0 && value < 24) ? value : 0); }
	}

	public int Minute
	{
		get { return minute; }
		set { minute = ((value >= 0 && value < 60) ? value : 0); }
	}

	public int Second
	{
		get { return second; }
		set { second = ((value >= 0 && value < 60) ? value : 0); }
	}

	// Inicializa como zero, padrão meia-noite.
	public Time3()
	{ SetTime(0, 0, 0); }

	// Inicializa hora.
	public Time3(int hour)
	{ SetTime(hour, 0, 0); }

	// Inicializa hora, minuto.
	public Time3(int hour, int minute)
	{ SetTime(hour, minute, 0); }

	// Inicializa hora, minuto e segundo.
	public Time3(int hour, int minute, int second)
	{ SetTime(hour, minute, second); }

	// Inicializa usando outro objeto Time3.
	public Time3(Time3 time)
	{ SetTime(time.hour, time.minute, time.second); }

	// Verifica os valores e os configura. Se inválidos, seta como 0.
	public void SetTime(int h, int m, int s)
	{
		hour = (h >= 0 && h < 24) ? h : 0;
		minute = (m >= 0 && m < 60) ? m : 0;
		second = (s >= 0 && s < 60) ? s : 0;
	}

	// Converte a hora para a string de formato de hora universal (24h).
	public string ToUniversalString()
	{
		return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
	}

	// Converte a hora para a string de formato de hora padrão (12h).
	public string ToStandardString()
	{
		return String.Format("{0:D2}:{1:D2}:{2:D2} {3}",
			((hour == 12 || hour == 0) ? 12 : hour % 12),
			minute, second, (hour < 12 ? "AM" : "PM")
		);
	}
}

public class Label : System.Windows.Forms.Label
{
	public Label(string content)
	{
		this.Name = content;
		this.Text = content;
		this.AutoSize = true;
		// this.Size = new System.Drawing.Size(200, 200);
		// this.TabIndex = 0;
	}

	public void SetLocation(int x, int y)
	{
		this.Location = new Point(x, y);
	}
}

public class TextBox : System.Windows.Forms.TextBox
{
	public TextBox(string text)
	{
		this.Name = "TextBox";
		this.Text = text;
		this.Size = new Size(35, 0);
		// this.TabIndex = 0;
	}

	public void SetLocation(int x, int y)
	{
		this.Location = new Point(x, y);
	}
}

public class Button : System.Windows.Forms.Button
{
	public Button(string content)
	{
		this.Name = content;
		this.Text = content;
		this.AutoSize = true;
		this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		// this.Padding = new Padding(0, 0, 0, 0);
		// this.TextAlign = ContentAlignment.MiddleLeft;
		// this.Size = new Size(100, 50);
		// this.TabIndex = 0;
	}

	public void SetLocation(int x, int y)
	{
		this.Location = new Point(x, y);
	}
}

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}
}
