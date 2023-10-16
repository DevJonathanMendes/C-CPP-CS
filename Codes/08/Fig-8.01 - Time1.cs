// Fig. 8.1: Time1.cs
// A classe Time1 mantém o tempo no formato de 23 horas.

using System;

public class Time1 : Object
{
	private int hour;   // 0 a 23.
	private int minute; // 0 a 59.
	private int second; // 0 a 59.

	// O constructor de Time1 inicializa variáveis de instância como
	// zero para configurar a hora padrão como meia-noite.
	public Time1()
	{ SetTime(0, 0, 0); }

	// Configura o novo valor de hora no formato de 24 horas. Realiza verificações
	// de validade nos dados. Configura os valores inválidos como zero.
	public void SetTime(int hourValue, int minuteValue, int secondValue)
	{
		hour = (hourValue >= 0 && hourValue < 24) ? hourValue : 0;
		minute = (minuteValue >= 0 && minuteValue < 60) ? minuteValue : 0;
		second = (secondValue >= 0 && secondValue < 60) ? secondValue : 0;
	}

	// Converte a hora para a string de formato de hora universal (24 horas).
	public string ToUniversalString()
	{
		return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
	}

	// Converte a hora para a string de formato de hora padrão (12 horas).
	public string ToStandardString()
	{
		return String.Format("{0}:{1:D2}:{2:D2} {3}",
			((hour == 12 || hour == 0) ? 12 : hour % 12),
			minute, second, (hour < 12 ? "AM" : "PM")
		);
	}
}
