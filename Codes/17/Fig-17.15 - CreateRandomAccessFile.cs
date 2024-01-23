// Fig. 17.15: CreateRandomAccessFile.cs
// Criando um arquivo aleatório.

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

// Cole a classe BankUIForm (Fig-17.07 - BankUI) aqui.

// Cole a classe RandomAccessRecord (Fig-17.14 - RandomAccessRecord) aqui.

class CreateRandomAccessFile
{
	// Número de registro a gravar no disco.
	private const int NUMBER_OF_RECORDS = 100;

	[STAThread]
	static void Main(string[] args)
	{
		// Cria arquivo aleatório e depois salva em disco.
		CreateRandomAccessFile file = new CreateRandomAccessFile();
		file.SaveFile();
	}

	// Grava registros no disco.
	private void SaveFile()
	{
		// Registro para gravar no disco.
		RandomAccessRecord blankRecord = new RandomAccessRecord();

		// Fluxo por meio do qual os dados serializáveis são gravados no arquivo.
		FileStream fileOutput = null;

		// Fluxo para gravar bytes no arquivo.
		BinaryWriter binaryOutput = null;

		// Cria uma caixa de diálogo permitindo que o usuário salve o arquivo.
		SaveFileDialog fileChooser = new SaveFileDialog();
		DialogResult result = fileChooser.ShowDialog();

		// Obtém o nome do arquivo do usuário.
		string fileName = fileChooser.FileName;

		// Sai do manipulador de evento se o usuário clicou em Cancelar.
		if (result == DialogResult.Cancel)
			return;

		// Mostra erro se o usuário especificou um arquivo inválido.
		if (fileName == "" || fileName == null)
			MessageBox.Show("Invalid File Name", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		else
		{
			// Grava registros no arquivo.
			try
			{
				// Cria FileStream para conter registros.
				fileOutput = new FileStream(fileName, FileMode.Create, FileAccess.Write);

				// Configura o tamanho do arquivo.
				fileOutput.SetLength(RandomAccessRecord.SIZE * NUMBER_OF_RECORDS);

				// Cria objetos para gravar bytes no arquivo.
				binaryOutput = new BinaryWriter(fileOutput);

				// Grava registros vazios no arquivo.
				for (int i = 0; i < NUMBER_OF_RECORDS; i++)
				{
					// Configura o ponteiro de posição no arquivo do arquivo.
					fileOutput.Position = i * RandomAccessRecord.SIZE;

					// Grava registros em branco no arquivo.
					binaryOutput.Write(blankRecord.Account);
					binaryOutput.Write(blankRecord.FirstName);
					binaryOutput.Write(blankRecord.LastName);
					binaryOutput.Write(blankRecord.Balance);
				}

				//  Notifica o usuário do êxito.
				MessageBox.Show("File Created", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (IOException)
			{
				// Notifica o usuário do erro.
				MessageBox.Show("Cannot write to file", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Fecha FileStream.
		if (fileOutput == null)
			fileOutput.Close();

		// Fecha BinaryWriter.
		if (BinaryWriter == null)
			BinaryWriter.Close();
	}
}
