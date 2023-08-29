// 8.6: Usando Construtores Sobrecarregados.
// Assim como os métodos, os construtores também podem ser sobrecarregados.
// Quando o método/construtor contém outra definição com parâmetros diferentes
// se caracteriza uma sobrecarga.

using System;

public class Time2 : Object
{
	private int hour;   // 0 a 23.
	private int minute; // 0 a 59.
	private int second; // 0 a 59.

	// Inicializa como zero, padrão meia-noite.
	public Time2()
	{ SetTime(0, 0, 0); }

	// Inicializa hora.
	public Time2(int hour)
	{ SetTime(hour, 0, 0); }

	// Inicializa hora, minuto.
	public Time2(int hour, int minute)
	{ SetTime(hour, minute, 0); }

	// Inicializa hora, minuto e segundo.
	public Time2(int hour, int minute, int second)
	{ SetTime(hour, minute, second); }

	// Inicializa usando outro objeto Time2.
	public Time2(Time2 time)
	{ SetTime(time.hour, time.minute, time.second); }

	// Verifica os valores e os configura.
	// Se inválidos, configura como 0.
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
		return String.Format("{0}:{1:D2}:{2:D2} {3}",
			((hour == 12 || hour == 0) ? 12 : hour % 12),
			minute, second, (hour < 12 ? "AM" : "PM")
		);
	}
}

static class Program
{
	static void Main(string[] args)
	{
		string output = "";
		Time2 TestTime1 = new Time2();
		TestTime1.SetTime(18, 01, 20);

		output += $"Universal time is: {TestTime1.ToUniversalString()}\n";
		output += $"Standard time is: {TestTime1.ToStandardString()}";

		Console.WriteLine($"Testing Class Time1\n{output}");
	}
}
