// Fig. 8.6: Time3.cs
// A classe Time3 fornece acessores de propriedade get e set.

using System;

public class Time3
{
	private int hour;
	private int minute;
	private int second;

	public Time3()
	{ SetTime(0, 0, 0); }

	public Time3(int hour)
	{ SetTime(hour, 0, 0); }

	public Time3(int hour, int minute)
	{ SetTime(hour, minute, 0); }

	public Time3(int hour, int minute, int second)
	{ SetTime(hour, minute, second); }

	public Time3(Time3 time)
	{ SetTime(time.hour, time.minute, time.second); }

	public void SetTime(int hourValue, int minuteValue, int secondValue)
	{
		Hour = hourValue;     // Chama o conjunto de propriedades Hour.
		Minute = minuteValue; // Chama o conjunto de propriedades Minute.
		Second = secondValue; // Chama o conjunto de propriedades Second.
	}

	// Propriedade Hour.
	public int Hour
	{
		get { return hour; }
		set { hour = ((value >= 0 && value < 24) ? value : 0); }
	}

	// Propriedade Minute.
	public int Minute
	{
		get { return minute; }
		set { minute = ((value >= 0 && value < 60) ? value : 0); }
	}

	// Propriedade Second.
	public int Second
	{
		get { return second; }
		set { second = ((value >= 0 && value < 60) ? value : 0); }
	}

	public string ToUniversalString()
	{
		return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
	}

	public string ToStandardString()
	{
		return String.Format("{0}:{1:D2}:{2:D2} {3}",
			((Hour == 12 || Hour == 0) ? 12 : Hour % 12),
			Minute, Second, (Hour < 12 ? "AM" : "PM")
		);
	}
}
