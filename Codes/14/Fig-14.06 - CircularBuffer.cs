// Fig. 14.6: CircularBuffer.cs
// Implementando o relacionamento produtor/consumidor com um buffer circular.

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

public class HoldIntegerSynchronized
{
	// Cada elemento de array é um buffer.
	private int[] buffers = { -1, -1, -1 };

	// occupiedBufferCount mantém a contagem de buffers ocupados.
	private int occupiedBufferCount = 0;

	// Variável que mantém as posições do buffer de leitura e gravação.
	private int readLocation = 0, writeLocation = 0;

	private TextBox outputTextBox;

	public HoldIntegerSynchronized(TextBox output)
	{ outputTextBox = output; }

	public int Buffer
	{
		get
		{
			// Bloqueia esse objeto enquanto obtém o valor do array buffers
			lock (this)
			{
				if (occupiedBufferCount == 0)
				{
					outputTextBox.Text += "\r\nAll buffers empty. " +
						Thread.CurrentThread.Name + " waits.";

					outputTextBox.ScrollToCaret();

					Monitor.Wait(this);
				}

				// Obtém o valor na readLocation atual, então
				// adiciona uma string indicando o valor consumido na saída.
				int readValue = buffers[readLocation];

				outputTextBox.Text += "\r\n" +
						Thread.CurrentThread.Name + " reads " +
						buffers[readLocation] + " ";

				// Acabou de consumir um valor; portanto, decrementa o número de
				// buffers ocupados
				--occupiedBufferCount;

				readLocation = (readLocation + 1) % buffers.Length;
				outputTextBox.Text += CreateStateOutput();
				outputTextBox.ScrollToCaret();

				// Retorna a linha de execução que está esperando (se houver uma)
				// ao estado iniciada.
				Monitor.Pulse(this);

				return readValue;
			}
		}
		set
		{
			// Bloqueia esse objeto enquanto o valor
			// no array buffers.
			lock (this)
			{
				// Se não houver posições vazias, coloca a linha de execução
				// chamadora no estado dormente/espera/união.
				if (occupiedBufferCount == buffers.Length)
				{
					outputTextBox.Text += "\r\nAll buffers full. " +
						Thread.CurrentThread.Name + " waits.";
					outputTextBox.ScrollToCaret();

					Monitor.Wait(this);
				}

				buffers[writeLocation] = value;

				outputTextBox.Text += "\r\n" +
					Thread.CurrentThread.Name + " write " +
					buffers[writeLocation] + " ";

				// Acabou de produzir um valor; portanto, incrementa o número de
				// buffers ocupados.
				++occupiedBufferCount;

				writeLocation = (writeLocation + 1) % buffers.Length;
				outputTextBox.Text += CreateStateOutput();
				outputTextBox.ScrollToCaret();

				// Retorna a linha de execução que está esperando (se houver)
				// ao estado iniciada.
				Monitor.Pulse(this);
			}
		}
	}

	public string CreateStateOutput()
	{
		string output = "(buffers occupied: " +
			occupiedBufferCount + ")\r\nbuffers: ";

		for (int i = 0; i < buffers.Length; i++)
			output += " " + buffers[i] + " ";

		output += "\r\n";
		output += "         ";

		for (int i = 0; i < buffers.Length; i++)
			output += "---- ";

		output += "\r\n";
		output += "         ";

		for (int i = 0; i < buffers.Length; i++)
			if (i == writeLocation && writeLocation == readLocation)
				output += " WR  ";
			else if (i == writeLocation)
				output += " W   ";
			else if (i == readLocation)
				output += "  R  ";
			else
				output += "    ";

		output += "\r\n";

		return output;
	}
}

public class Producer
{
	private HoldIntegerSynchronized sharedLocation;
	private TextBox outputTextBox;
	private Random randomSleepTime;

	public Producer(HoldIntegerSynchronized shared, Random random, TextBox output)
	{
		sharedLocation = shared;
		outputTextBox = output;
		randomSleepTime = random;
	}

	public void Produce()
	{
		// Fica dormente por um intervalo aleatório de até 3000 milissegundos
		// então configura a propriedade Buffer de sharedLocation.
		for (int count = 11; count <= 20; count++)
		{
			Thread.Sleep(randomSleepTime.Next(1, 3000));
			sharedLocation.Buffer = count;
		}

		string name = Thread.CurrentThread.Name;

		outputTextBox.Text += "\r\n" + name +
			" done producing.\r\n" + name + " terminated.\r\n";

		outputTextBox.ScrollToCaret();
	}
}

public class Consumer
{
	private HoldIntegerSynchronized sharedLocation;
	private TextBox outputTextBox;
	private Random randomSleepTime;

	public Consumer(HoldIntegerSynchronized shared, Random random, TextBox output)
	{
		sharedLocation = shared;
		outputTextBox = output;
		randomSleepTime = random;
	}

	public void Consume()
	{
		int sum = 0;

		for (int count = 1; count <= 10; count++)
		{
			Thread.Sleep(randomSleepTime.Next(1, 3000));
			sum += sharedLocation.Buffer;
		}

		string name = Thread.CurrentThread.Name;

		outputTextBox.Text += "\r\nTotal " + name +
			" consumed: " + sum + ".\r\n" + name +
			" terminated.\r\n";

		outputTextBox.ScrollToCaret();
	}
}

partial class CircularBuffer : Form
{
	private TextBox outputTextBox;

	private void InitializeComponent()
	{
		this.outputTextBox = new TextBox();

		// outputTextBox.
		this.outputTextBox.Name = "outputTextBox";
		this.outputTextBox.Text = "";
		this.outputTextBox.ScrollBars = ScrollBars.Both;
		this.outputTextBox.Location = new Point(10, 10);

		// CircularBuffer.
		this.Controls.Add(this.outputTextBox);
		this.Load += new EventHandler(CircularBuffer_Load);
		this.Name = "CircularBuffer";
		this.Text = "CircularBuffer";
		this.AutoSize = true;
		this.ResumeLayout(false);
	}

	private void CircularBuffer_Load(object? sender, EventArgs e)
	{
		// Cria objeto compartilhado.
		HoldIntegerSynchronized sharedLocation = new HoldIntegerSynchronized(outputTextBox);

		outputTextBox.Text = sharedLocation.CreateStateOutput();

		Random random = new Random();

		Producer producer = new Producer(sharedLocation, random, outputTextBox);
		Consumer consumer = new Consumer(sharedLocation, random, outputTextBox);

		Thread producerThread = new Thread(new ThreadStart(producer.Produce));
		producerThread.Name = "Producer";

		Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
		producerThread.Name = "Consumer";

		producerThread.Start();
		consumerThread.Start();
	}
}

partial class CircularBuffer
{
	private Container? components = null;

	public CircularBuffer()
	{ InitializeComponent(); }

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{ components.Dispose(); }

		base.Dispose(disposing);
	}
}

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new CircularBuffer());
	}
}
