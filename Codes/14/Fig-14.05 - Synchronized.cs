// Fig. 14.5: Synchronized.cs
// Mostrando várias linhas de execução modificando um objeto compartilhado com sincronização.

using System;
using System.Threading;

class HoldIntegerSynchronized
{
	// Buffer compartilhado pelas linhas de execução produtora e consumidora.
	private int buffer = -1;

	// occupiedBufferCount faz a contagem de buffers ocupados.
	private int occupiedBufferCount = 0;

	public int Buffer
	{
		get
		{
			// Obtém o bloqueio desse objeto.
			Monitor.Enter(this);

			// Se não houver dados para ler, coloca a linha de execução
			// chamadora no estado dormente/espera/união.
			if (occupiedBufferCount == 0)
			{
				Console.WriteLine((Thread.CurrentThread.Name + " tries to read."));

				DisplayState("Buffer empty. " + Thread.CurrentThread.Name + " waits.");

				Monitor.Wait(this);
			}

			--occupiedBufferCount;

			DisplayState(Thread.CurrentThread.Name + " reads " + buffer);

			// Diz à linha de execução que está esperando (se houver alguma) para
			// que se apronte para executar (estado iniciada).
			Monitor.Pulse(this);

			// Obtém a cópia do buffer antes de liberar o bloqueio.
			// É possível que o produtor pudesse ser
			// atribuído ao processador imediatamente após o
			// monitor ser liberado e antes da execução da
			// instrução return. Nesse caso, o produtor
			// atribuiria um novo valor ao buffer, antes da instrução
			// return retornar o valor para o
			// consumidor. Assim, o consumidor receberia o
			// novo valor. Facer uma cópia do buffer e
			// retornar a cópia garante que o
			// consumidor receba o valor correto.
			int bufferCopy = buffer;

			// Libera o bloqueio desse objeto.
			Monitor.Exit(this);

			return bufferCopy;
		}
		set
		{
			// Adquire o bloqueio para esse objeto.
			Monitor.Enter(this);

			// Se não houver posições vazias, coloca a linha de execução
			// chamadora no estado dormente/espera/união.
			if (occupiedBufferCount == 1)
			{
				Console.WriteLine((Thread.CurrentThread.Name + " tries to writes."));

				DisplayState("Buffer full. " +
					Thread.CurrentThread.Name + " waits.");

				Monitor.Wait(this);
			}

			buffer = value;

			// Indica que o produtor não pode armazenar outro valor
			// até que o consumidor recupere o valor atual do buffer.
			++occupiedBufferCount;

			DisplayState(Thread.CurrentThread.Name + " writes " + buffer);

			// Diz à linha de execução (se houver uma) qe está esperando para
			// que se apronte para executar (estado iniciada).
			Monitor.Pulse(this);

			// Libera o bloqueio desse objeto.
			Monitor.Exit(this);
		}
	}

	public void DisplayState(string operation)
	{
		Console.WriteLine("{0, -35} {1, -9} {2}",
			operation, buffer, occupiedBufferCount);
	}
}

class Producer
{
	private HoldIntegerSynchronized sharedLocation;
	private Random randomSleepTime;

	public Producer(HoldIntegerSynchronized shared, Random random)
	{
		sharedLocation = shared;
		randomSleepTime = random;
	}

	public void Produce()
	{
		for (int count = 1; count <= 4; count++)
		{
			Thread.Sleep(randomSleepTime.Next(1, 3000));
			sharedLocation.Buffer = count;
		}

		Console.WriteLine(
			Thread.CurrentThread.Name +
			" done producing.\nTerminating" +
			Thread.CurrentThread.Name + "."
		);
	}
}

class Consumer
{
	private HoldIntegerSynchronized sharedLocation;
	private Random randomSleepTime;

	public Consumer(HoldIntegerSynchronized shared, Random random)
	{
		sharedLocation = shared;
		randomSleepTime = random;
	}

	public void Consume()
	{
		int sum = 0;

		for (int count = 1; count <= 4; count++)
		{
			Thread.Sleep(randomSleepTime.Next(1, 3000));
			sum += sharedLocation.Buffer;
		}

		Console.WriteLine(
			Thread.CurrentThread.Name +
			" read values totaling: " +
			sum + ".\nTerminating " +
			Thread.CurrentThread.Name + "."
		);
	}
}

class SharedCell
{
	static void Main(string[] args)
	{
		HoldIntegerSynchronized holdInteger = new HoldIntegerSynchronized();

		Random random = new Random();

		Producer producer = new Producer(holdInteger, random);
		Consumer consumer = new Consumer(holdInteger, random);

		Console.WriteLine("{0, -35}{1, -9}{2}",
			"Operation", "Buffer", "Occupied Count");

		holdInteger.DisplayState("Initial state");

		Thread producerThread = new Thread(new ThreadStart(producer.Produce));
		producerThread.Name = "Producer";

		Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
		consumerThread.Name = "Consumer";

		producerThread.Start();
		consumerThread.Start();
	}
}
