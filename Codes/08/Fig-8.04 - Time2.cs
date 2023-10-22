// Fig. 8.4: Time2.cs
// A classe Time2 fornece construtores sobrecarregados.

using System;

public class Time2
{
	private int hour;
	private int minute;
	private int second;

	public Time2()
	{ SetTime(0, 0, 0); }

	public Time2(int hour)
	{ SetTime(hour, 0, 0); }

	public Time2(int hour, int minute)
	{ SetTime(hour, minute, 0); }

	public Time2(int hour, int minute, int second)
	{ SetTime(hour, minute, second); }

	// Construtor de Time2: Inicializa usando outro objeto Time2.
	public Time2(Time2 time)
	{ SetTime(time.hour, time.minute, time.second); }

	public void SetTime(int hourValue, int minuteValue, int secondValue)
	{
		hour = (hourValue >= 0 && hourValue < 24) ? hourValue : 0;
		minute = (minuteValue >= 0 && minuteValue < 60) ? minuteValue : 0;
		second = (secondValue >= 0 && secondValue < 60) ? secondValue : 0;
	}

	public string ToUniversalString()
	{
		return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
	}

	public string ToStandardString()
	{
		return String.Format("{0}:{1:D2}:{2:D2} {3}",
			((hour == 12 || hour == 0) ? 12 : hour % 12),
			minute, second, (hour < 12 ? "AM" : "PM")
		);
	}
}
