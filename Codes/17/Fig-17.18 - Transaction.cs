// Fig. 17.18: Transaction.cs
// Manipula transações de registros.

using System;
using System.IO;
using System.Windows.Forms;

// using BankLibrary;

// Cole a classe BankUIForm (Fig-17.07 - BankUI.cs) aqui.

// Cole a classe RandomAccessRecord (Fig-17.14 - RandomAccessRecord.cs) aqui.

public class Transaction
{
	// Número de registros a gravar no disco.
	private const int NUMBER_OF_RECORDS = 100;

	// Fluxo por meio do qual os dados se movem no arquivo.
	private FileStream file;

	// Fluxo para ler bytes do arquivo.
	private BinaryReader binaryInput;

	// Fluxo para gravar bytes no arquivo.
	private BinaryWriter binaryOutput;

	// Cria/Abre arquivo contendo registros vazios.
	public void OpenFile(string fileName)
	{
		// Grava registros vazios no arquivo.
		try
		{
			// Cria FileStream a partir do novo arquivo ou de um arquivo existente.
			file = new FileStream(fileName, FileMode.OpenOrCreate);

			// Usa FileStream para BinaryReader para ler bytes do arquivo.
			binaryInput = new BinaryReader(file);

			// Usa FileStream para BinaryWriter para gravar bytes do arquivo.
			binaryOutput = new BinaryWriter(file);

			// Determina se o arquivo acabou de ser criado.
			if (file.Length == 0)
			{
				// Registro a ser gravado no arquivo.
				RandomAccessRecord blankRecord = new RandomAccessRecord();

				// O novo registro pode conter NUMBER_OF_RECORDS registros.
				file.SetLength(RandomAccessRecord.SIZE * NUMBER_OF_RECORDS);

				// Grava registro em branco no arquivo.
				for (int i = 0; i < NUMBER_OF_RECORDS; i++)
				{
					// Move o ponteiro de posição no arquivo para a próxima posição.
					file.Position = i * RandomAccessRecord.SIZE;

					// Grava registro em branco no arquivo.
					binaryOutput.Write(blankRecord.Account);
					binaryOutput.Write(blankRecord.FirstName);
					binaryOutput.Write(blankRecord.LastName);
					binaryOutput.Write(blankRecord.Balance);
				}
			}
		}
		catch (IOException)
		{
			MessageBox.Show("Cannot create file", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	// Recupera registro dependendo de a contar ser válida.
	public RandomAccessRecord GetRecord(string accountValue)
	{
		// Armazena dados do arquivo associado à conta no registro.
		try
		{
			// Registro para armazenar dados do arquivo.
			RandomAccessRecord record = new RandomAccessRecord();

			// Obtém o valor do campo de conta de TextBox.
			int accountNumber = Int32.Parse(accountValue);

			// Se a conta for inválida, não lê dados.
			if (accountNumber < 1 || accountNumber > NUMBER_OF_RECORDS)
			{
				// Configura o campo de conta do registro com o número da conta.
				record.Account = accountNumber;
			}

			// Obtém dados do arquivo se a conta for válida.
			else
			{
				// Localiza a posição no arquivo onde o registro existe.
				file.Seek((accountNumber - 1) * RandomAccessRecord.SIZE, 0);

				// Lê dados do registro.
				record.Account = binaryInput.ReadInt32();
				record.FirstName = binaryInput.ReadString();
				record.LastName = binaryInput.ReadString();
				record.Balance = binaryInput.ReadDouble();
			}

			return record;
		}
		// Notifica o usuário de erro durante a leitura.
		catch (IOException)
		{
			MessageBox.Show("Cannot read file", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		return null;
	}

	// Adiciona registro no arquivo, na posição determinada por accountNumber.
	public bool AddRecord(RandomAccessRecord record, int accountNumber)
	{
		// Grava registro no arquivo.
		try
		{
			// Move o ponteiro de posição no arquivo para o lugar apropriado.
			file.Seek((accountNumber - 1) * RandomAccessRecord.SIZE, 0);

			// Grava dados no arquivo.
			binaryOutput.Write(record.Account);
			binaryOutput.Write(record.FirstName);
			binaryOutput.Write(record.LastName);
			binaryOutput.Write(record.Balance);
		}
		// Notifica o usuário se ocorrer erro durante a gravação,
		catch (IOException)
		{
			MessageBox.Show("Error Writing To File", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			return false;
		}

		return true;
	}
}
