// 8.2: Implementando um tipo de dado abstrato de tempo com uma classe.
// Tipos de Dados Abstratos (TDAs), ocultam a implementação dos clientes.
// Fig. 8.1: Time1.
// A classe Time1 mantém o tempo no formato de 24h.
// Fig: 8.2: TimeTest1.

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
		Time1 TestTime1 = new Time1();
		TestTime1.SetTime(18, 01, 20);

		output += $"Universal time is: {TestTime1.ToUniversalString()}\n";
		output += $"Standard time is: {TestTime1.ToStandardString()}";

		Console.WriteLine($"Testing Class Time1\n{output}");
	}
}
