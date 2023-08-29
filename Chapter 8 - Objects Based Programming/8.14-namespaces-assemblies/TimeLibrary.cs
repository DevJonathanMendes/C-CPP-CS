// Fig. 8.17: TimeLibrary.
// Colocando a classe Time3 em um assembly para reutilização.

using System;

namespace TimeLibrary // Especifica o espaço de nomes da classe Time3.
{
	public class Time3
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
			return String.Format("{0}:{1:D2}:{2:D2} {3}",
				((hour == 12 || hour == 0) ? 12 : hour % 12),
				minute, second, (hour < 12 ? "AM" : "PM")
			);
		}
	}
}